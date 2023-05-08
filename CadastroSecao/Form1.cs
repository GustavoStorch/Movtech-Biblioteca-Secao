using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroSecao
{
    public partial class Form1 : Form
    {

        private SqlConnection conn;
        private bool btnAtivo;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            table_load();
            CarregaID();
            btnAtivo = false;
            botaoAtivado();
        }

        //Cria a conexão com o banco de dados.
        private SqlConnection Conexao()
        {
            conn = new SqlConnection(@"Data Source=localhost\sqlexpress;Initial Catalog=Treinamento;Integrated Security=True");
            return conn;
        }

        //Método para ativar ou desativar o botão de excluir do usuário.
        private void botaoAtivado()
        {
            if (btnAtivo)
            {
                btnExcluir.Enabled = true;
            }
            else
            {
                btnExcluir.Enabled = false;
            }
        }

        //Recupera o próximo id a ser cadastrado e joga ele para o textBox.
        private void CarregaID()
        {
            conn = Conexao();
            conn.Open();

            SqlCommand cm = new SqlCommand("SELECT IDENT_CURRENT('mvtBibSecao') + 1", conn);
            int nextCod = Convert.ToInt32(cm.ExecuteScalar());

            txtCodSecao.Text = nextCod.ToString();
            conn.Close();
        }

        private void lblCadSecao_Click(object sender, EventArgs e)
        {

        }

        //Botão com a funcionalidade de salvar/persistir os dados inseridos no banco de dados.
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            conn = Conexao();
            String sql;

            try
            {
                //Verifica se o campo do código está vazio e realiza o insert.
                if (string.IsNullOrEmpty(this.txtCodSecao.Text))
                {
                    sql = "INSERT INTO mvtBibSecao(descricaoSecao) VALUES(@descricaoSecao)";
                    SqlCommand c = new SqlCommand(sql, conn);

                    if (String.IsNullOrWhiteSpace(txtDescricaoSecao.Text))
                    {
                        MessageBox.Show("Erro: Preencha a descrição da seção!");
                    }
                    else
                    {
                        c.Parameters.Add(new SqlParameter("@descricaoSecao", this.txtDescricaoSecao.Text));
                    }

                    conn.Open();
                    c.ExecuteNonQuery();
                    conn.Close();

                    MessageBox.Show("Enviado com sucesso!");

                    limparForm();
                    table_load();
                    CarregaID();
                }
                else
                {
                    //Verifica se o código presente no textbox já está registrado dentro do banco de dados.
                    conn.Open();
                    string sql2 = "SELECT COUNT(*) FROM mvtBibSecao WHERE codSecao = @codSecao";
                    SqlCommand cmdSelect = new SqlCommand(sql2, conn);
                    cmdSelect.Parameters.AddWithValue("@codSecao", txtCodSecao.Text);
                    int count = Convert.ToInt32(cmdSelect.ExecuteScalar());
                    conn.Close();

                    //Se o código estiver registrado no banco de dados realiza apenas o update.
                    if (count > 0)
                    {
                        sql = "UPDATE mvtBibSecao SET descricaoSecao = @descricaoSecao WHERE codSecao = @codSecao";
                        SqlCommand c = new SqlCommand(sql, conn);

                        c.Parameters.AddWithValue("@codSecao", txtCodSecao.Text);

                        if (String.IsNullOrWhiteSpace(txtDescricaoSecao.Text))
                        {
                            MessageBox.Show("Erro: Preencha a descrição da seção!");
                        }
                        else
                        {
                            c.Parameters.Add(new SqlParameter("@descricaoSecao", this.txtDescricaoSecao.Text));
                        }
                        conn.Open();

                        c.ExecuteNonQuery();

                        conn.Close();

                        MessageBox.Show("Atualizado com sucesso!");

                        limparForm();
                        table_load();
                        CarregaID();
                        btnAtivo = false;
                        botaoAtivado();
                    }
                    else
                    {
                        //Se não estiver registrado no banco de dados realiza o insert.
                        sql = "INSERT INTO mvtBibSecao(descricaoSecao) VALUES(@descricaoSecao)";
                        SqlCommand c = new SqlCommand(sql, conn);

                        if (String.IsNullOrWhiteSpace(txtDescricaoSecao.Text))
                        {
                            MessageBox.Show("Erro: Preencha a descrição da seção!");
                        }
                        else
                        {
                            c.Parameters.Add(new SqlParameter("@descricaoSecao", this.txtDescricaoSecao.Text));
                        }

                        conn.Open();
                        c.ExecuteNonQuery();
                        conn.Close();

                        MessageBox.Show("Enviado com sucesso!");

                        limparForm();
                        table_load();
                        CarregaID();
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Ocorreu o erro: " + ex);
            }
            finally
            {
                conn.Close();
            }
        }

        //Botão que realiza o Delete de um registro no banco de dados.
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            conn = Conexao();
            String sql = "DELETE mvtBibSecao WHERE codSecao = @codSecao";

            try
            {
                SqlCommand c = new SqlCommand(sql, conn);

                c.Parameters.AddWithValue("@codSecao", txtCodSecao.Text);

                conn.Open();
                c.ExecuteNonQuery();

                limparForm();
                table_load();
                CarregaID();
                //btnAtivo = false;
                botaoAtivado();

                MessageBox.Show("Excluído com sucesso!");

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Ocorreu o erro: " + ex);
            }
            finally
            {
                conn.Close();
            }
        }

        //Método que limpa o formulário toda vez que é salvo ou deletado um registro.
        public void limparForm()
        {
            txtCodSecao.Text = String.Empty;
            txtDescricaoSecao.Text = String.Empty;
        }

        //Carrega todos os registros contidos no banco de dados para a DataGridView.
        private void table_load()
        {
            conn = Conexao();
            String sql = "SELECT codSecao AS Código, descricaoSecao AS Descrição FROM mvtBibSecao ORDER BY Código";

            try
            {
                DataSet ds = new DataSet();
                DataTable dt = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(sql, conn);

                conn.Open();
                da.Fill(ds);
                gridCadSecao.DataSource = ds.Tables[0];
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Ocorreu o erro: " + ex);
            }
            finally
            {
                conn.Close();
            }
        }

        //Método que realiza o double click em uma linha da grid e joga todos os seus dados para as textBox.
        private void gridCadSecao_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (gridCadSecao.SelectedRows.Count > 0)
            {
                txtCodSecao.Text = gridCadSecao.SelectedRows[0].Cells[0].Value.ToString();
                txtDescricaoSecao.Text = gridCadSecao.SelectedRows[0].Cells[1].Value.ToString();

                if (string.IsNullOrEmpty(this.txtDescricaoSecao.Text))
                {
                    btnExcluir.Enabled = false;
                    CarregaID();
                }
                else
                {
                    btnExcluir.Enabled = true;
                }

            }
        }
    }
}
