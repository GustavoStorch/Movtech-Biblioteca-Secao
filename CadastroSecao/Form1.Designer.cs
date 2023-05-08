namespace CadastroSecao
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblCadSecao = new System.Windows.Forms.Label();
            this.lblCodSecao = new System.Windows.Forms.Label();
            this.lblDescricaoSecao = new System.Windows.Forms.Label();
            this.txtCodSecao = new System.Windows.Forms.TextBox();
            this.txtDescricaoSecao = new System.Windows.Forms.TextBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.gridCadSecao = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridCadSecao)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCadSecao
            // 
            this.lblCadSecao.AutoSize = true;
            this.lblCadSecao.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadSecao.Location = new System.Drawing.Point(470, 36);
            this.lblCadSecao.Name = "lblCadSecao";
            this.lblCadSecao.Size = new System.Drawing.Size(227, 36);
            this.lblCadSecao.TabIndex = 1;
            this.lblCadSecao.Text = "Cadastro Seção";
            this.lblCadSecao.Click += new System.EventHandler(this.lblCadSecao_Click);
            // 
            // lblCodSecao
            // 
            this.lblCodSecao.AutoSize = true;
            this.lblCodSecao.Location = new System.Drawing.Point(156, 155);
            this.lblCodSecao.Name = "lblCodSecao";
            this.lblCodSecao.Size = new System.Drawing.Size(63, 20);
            this.lblCodSecao.TabIndex = 2;
            this.lblCodSecao.Text = "Código:";
            // 
            // lblDescricaoSecao
            // 
            this.lblDescricaoSecao.AutoSize = true;
            this.lblDescricaoSecao.Location = new System.Drawing.Point(156, 248);
            this.lblDescricaoSecao.Name = "lblDescricaoSecao";
            this.lblDescricaoSecao.Size = new System.Drawing.Size(84, 20);
            this.lblDescricaoSecao.TabIndex = 3;
            this.lblDescricaoSecao.Text = "Descrição:";
            // 
            // txtCodSecao
            // 
            this.txtCodSecao.Enabled = false;
            this.txtCodSecao.Location = new System.Drawing.Point(316, 152);
            this.txtCodSecao.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCodSecao.MaxLength = 3;
            this.txtCodSecao.Name = "txtCodSecao";
            this.txtCodSecao.Size = new System.Drawing.Size(205, 26);
            this.txtCodSecao.TabIndex = 5;
            // 
            // txtDescricaoSecao
            // 
            this.txtDescricaoSecao.Location = new System.Drawing.Point(316, 242);
            this.txtDescricaoSecao.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDescricaoSecao.MaxLength = 50;
            this.txtDescricaoSecao.Name = "txtDescricaoSecao";
            this.txtDescricaoSecao.Size = new System.Drawing.Size(796, 26);
            this.txtDescricaoSecao.TabIndex = 6;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(707, 295);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(176, 57);
            this.btnExcluir.TabIndex = 11;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(368, 295);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(176, 57);
            this.btnSalvar.TabIndex = 10;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // gridCadSecao
            // 
            this.gridCadSecao.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridCadSecao.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridCadSecao.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridCadSecao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCadSecao.Location = new System.Drawing.Point(160, 377);
            this.gridCadSecao.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gridCadSecao.Name = "gridCadSecao";
            this.gridCadSecao.RowHeadersWidth = 62;
            this.gridCadSecao.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridCadSecao.Size = new System.Drawing.Size(952, 309);
            this.gridCadSecao.TabIndex = 12;
            this.gridCadSecao.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.gridCadSecao_MouseDoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1214, 728);
            this.Controls.Add(this.gridCadSecao);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtDescricaoSecao);
            this.Controls.Add(this.txtCodSecao);
            this.Controls.Add(this.lblDescricaoSecao);
            this.Controls.Add(this.lblCodSecao);
            this.Controls.Add(this.lblCadSecao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Nova Seção";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridCadSecao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCadSecao;
        private System.Windows.Forms.Label lblCodSecao;
        private System.Windows.Forms.Label lblDescricaoSecao;
        private System.Windows.Forms.TextBox txtCodSecao;
        private System.Windows.Forms.TextBox txtDescricaoSecao;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.DataGridView gridCadSecao;
    }
}

