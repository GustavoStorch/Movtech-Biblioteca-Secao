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
    public partial class FormCadSecao : Form
    {
        public FormCadSecao()
        {
            InitializeComponent();
        }

        private void FormCadSecao_Load(object sender, EventArgs e)
        {
            InitializeTable();
            CarregaID();
            btnExcluir.Enabled = false;
        }        

        //Botão com a funcionalidade de salvar/persistir os dados inseridos no banco de dados.
        private void btnSalvar_Click(object sender, EventArgs e)
        {
                try
            {
                using (SqlConnection connection = DaoConnection.GetConexao())
                {
                    SecaoDAO dao = new SecaoDAO(connection);

                    bool verificaCampos = dao.VerificaCampos(new SecaoModel()
                    {
                        CodSecao = txtCodSecao.Text,
                        NomeSecao = txtDescricaoSecao.Text
                    });

                    if (verificaCampos)
                    {

                        int count = dao.VerificaRegistros(new SecaoModel()
                        {
                            CodSecao = txtCodSecao.Text
                        });

                        if (count > 0)
                        {
                            dao.Editar(new SecaoModel()
                            {
                                CodSecao = txtCodSecao.Text,
                                NomeSecao = txtDescricaoSecao.Text
                            });
                            MessageBox.Show("seção Atualizada com sucesso!");
                        }
                        else
                        {
                            dao.Salvar(new SecaoModel()
                            {
                                CodSecao = txtCodSecao.Text,
                                NomeSecao = txtDescricaoSecao.Text
                            });
                            MessageBox.Show("seção salva com sucesso!");
                        }
                    }
                }
                InitializeTable();
                limparForm();
                CarregaID();
                btnExcluir.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Houve um problema ao salvar a seção!\n{ex.Message}");
            }
        }

        //Botão que realiza o Delete de um registro no banco de dados.
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult conf = MessageBox.Show("Tem certeza que deseja excluir a Seção?", "Ops, tem certeza?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            try
            {
                if (conf == DialogResult.Yes)
                {
                    using (SqlConnection connection = DaoConnection.GetConexao())
                    {
                        SecaoDAO dao = new SecaoDAO(connection);

                        bool verificaCampos = dao.VerificaCampos(new SecaoModel()
                        {
                            CodSecao = txtCodSecao.Text,
                            NomeSecao = txtDescricaoSecao.Text
                        });

                        if (verificaCampos)
                        {
                            dao.Excluir(new SecaoModel()
                            {
                                CodSecao = txtCodSecao.Text
                            });
                            MessageBox.Show("Seção excluído com sucesso!");
                        }
                    }
                    
                    InitializeTable();
                    limparForm();
                    CarregaID();
                    btnExcluir.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Houve um problema ao excluir a Seção!\n{ex.Message}");
            }
        }

        //Método que limpa o formulário toda vez que é salvo ou deletado um registro.
        public void limparForm()
        {
            txtCodSecao.Text = String.Empty;
            txtDescricaoSecao.Text = String.Empty;
        }

        //Carrega todos os registros contidos no banco de dados para a DataGridView.
        private void InitializeTable()
        {
            dtgDadosSecao.Rows.Clear();
            using (SqlConnection connection = DaoConnection.GetConexao())
            {
                SecaoDAO dao = new SecaoDAO(connection);
                List<SecaoModel> secoes = dao.GetSecoes();
                foreach (SecaoModel secao in secoes)
                {
                    DataGridViewRow row = dtgDadosSecao.Rows[dtgDadosSecao.Rows.Add()];
                    row.Cells[colCodSecao.Index].Value = secao.CodSecao;
                    row.Cells[colNomeSecao.Index].Value = secao.NomeSecao;
                }
            }
        }

        //Recupera o próximo id a ser cadastrado e joga ele para o textBox.
        private void CarregaID()
        {
            using (SqlConnection connection = DaoConnection.GetConexao())
            {
                SqlCommand command = new SqlCommand("SELECT IDENT_CURRENT('mvtBibSecao') + 1", connection);
                int nextCod = Convert.ToInt32(command.ExecuteScalar());

                txtCodSecao.Text = nextCod.ToString();
            }
        }

        //Método que realiza o double click em uma linha da grid e joga todos os seus dados para as textBox.
        private void dtgDadosSecao_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                txtCodSecao.Text = dtgDadosSecao.Rows[e.RowIndex].Cells[colCodSecao.Index].Value + "";
                txtDescricaoSecao.Text = dtgDadosSecao.Rows[e.RowIndex].Cells[colNomeSecao.Index].Value + "";

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
