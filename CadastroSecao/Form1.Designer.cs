namespace CadastroSecao
{
    partial class FormCadSecao
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
            this.lblCodSecao = new System.Windows.Forms.Label();
            this.lblDescricaoSecao = new System.Windows.Forms.Label();
            this.txtCodSecao = new System.Windows.Forms.TextBox();
            this.txtDescricaoSecao = new System.Windows.Forms.TextBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.dtgDadosSecao = new System.Windows.Forms.DataGridView();
            this.colCodSecao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNomeSecao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDadosSecao)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCodSecao
            // 
            this.lblCodSecao.AutoSize = true;
            this.lblCodSecao.Location = new System.Drawing.Point(8, 6);
            this.lblCodSecao.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCodSecao.Name = "lblCodSecao";
            this.lblCodSecao.Size = new System.Drawing.Size(43, 13);
            this.lblCodSecao.TabIndex = 2;
            this.lblCodSecao.Text = "Código:";
            // 
            // lblDescricaoSecao
            // 
            this.lblDescricaoSecao.AutoSize = true;
            this.lblDescricaoSecao.Location = new System.Drawing.Point(8, 27);
            this.lblDescricaoSecao.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDescricaoSecao.Name = "lblDescricaoSecao";
            this.lblDescricaoSecao.Size = new System.Drawing.Size(58, 13);
            this.lblDescricaoSecao.TabIndex = 3;
            this.lblDescricaoSecao.Text = "Descrição:";
            // 
            // txtCodSecao
            // 
            this.txtCodSecao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCodSecao.Enabled = false;
            this.txtCodSecao.Location = new System.Drawing.Point(69, 4);
            this.txtCodSecao.MaxLength = 3;
            this.txtCodSecao.Name = "txtCodSecao";
            this.txtCodSecao.Size = new System.Drawing.Size(38, 20);
            this.txtCodSecao.TabIndex = 1;
            // 
            // txtDescricaoSecao
            // 
            this.txtDescricaoSecao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescricaoSecao.Location = new System.Drawing.Point(69, 27);
            this.txtDescricaoSecao.MaxLength = 50;
            this.txtDescricaoSecao.Name = "txtDescricaoSecao";
            this.txtDescricaoSecao.Size = new System.Drawing.Size(475, 20);
            this.txtDescricaoSecao.TabIndex = 2;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExcluir.Location = new System.Drawing.Point(467, 51);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(77, 22);
            this.btnExcluir.TabIndex = 4;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalvar.Location = new System.Drawing.Point(385, 51);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(77, 22);
            this.btnSalvar.TabIndex = 3;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // dtgDadosSecao
            // 
            this.dtgDadosSecao.AllowUserToAddRows = false;
            this.dtgDadosSecao.AllowUserToDeleteRows = false;
            this.dtgDadosSecao.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgDadosSecao.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgDadosSecao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDadosSecao.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCodSecao,
            this.colNomeSecao});
            this.dtgDadosSecao.Location = new System.Drawing.Point(11, 78);
            this.dtgDadosSecao.Margin = new System.Windows.Forms.Padding(2);
            this.dtgDadosSecao.Name = "dtgDadosSecao";
            this.dtgDadosSecao.ReadOnly = true;
            this.dtgDadosSecao.RowHeadersWidth = 62;
            this.dtgDadosSecao.RowTemplate.Height = 28;
            this.dtgDadosSecao.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgDadosSecao.Size = new System.Drawing.Size(533, 239);
            this.dtgDadosSecao.TabIndex = 5;
            this.dtgDadosSecao.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgDadosSecao_CellDoubleClick);
            // 
            // colCodSecao
            // 
            this.colCodSecao.FillWeight = 50F;
            this.colCodSecao.HeaderText = "Código";
            this.colCodSecao.MinimumWidth = 8;
            this.colCodSecao.Name = "colCodSecao";
            this.colCodSecao.ReadOnly = true;
            // 
            // colNomeSecao
            // 
            this.colNomeSecao.HeaderText = "Seção";
            this.colNomeSecao.MinimumWidth = 8;
            this.colNomeSecao.Name = "colNomeSecao";
            this.colNomeSecao.ReadOnly = true;
            // 
            // FormCadSecao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 321);
            this.Controls.Add(this.dtgDadosSecao);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtDescricaoSecao);
            this.Controls.Add(this.txtCodSecao);
            this.Controls.Add(this.lblDescricaoSecao);
            this.Controls.Add(this.lblCodSecao);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormCadSecao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nova Seção";
            this.Load += new System.EventHandler(this.FormCadSecao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgDadosSecao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblCodSecao;
        private System.Windows.Forms.Label lblDescricaoSecao;
        private System.Windows.Forms.TextBox txtCodSecao;
        private System.Windows.Forms.TextBox txtDescricaoSecao;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.DataGridView dtgDadosSecao;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodSecao;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNomeSecao;
    }
}

