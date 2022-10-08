
namespace Hash
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
            this.lbRA = new System.Windows.Forms.Label();
            this.lbNome = new System.Windows.Forms.Label();
            this.txtRA = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.gpTipo = new System.Windows.Forms.GroupBox();
            this.rbHashingDuplo = new System.Windows.Forms.RadioButton();
            this.rbSondagemQuadratica = new System.Windows.Forms.RadioButton();
            this.rbSondagemLinear = new System.Windows.Forms.RadioButton();
            this.dgvAluno = new System.Windows.Forms.DataGridView();
            this.posicao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gpTipo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAluno)).BeginInit();
            this.SuspendLayout();
            // 
            // lbRA
            // 
            this.lbRA.AutoSize = true;
            this.lbRA.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRA.Location = new System.Drawing.Point(31, 25);
            this.lbRA.Name = "lbRA";
            this.lbRA.Size = new System.Drawing.Size(31, 20);
            this.lbRA.TabIndex = 0;
            this.lbRA.Text = "RA:";
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Location = new System.Drawing.Point(184, 25);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(53, 20);
            this.lbNome.TabIndex = 1;
            this.lbNome.Text = "Nome:";
            // 
            // txtRA
            // 
            this.txtRA.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRA.Location = new System.Drawing.Point(25, 48);
            this.txtRA.Name = "txtRA";
            this.txtRA.Size = new System.Drawing.Size(123, 34);
            this.txtRA.TabIndex = 2;
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(178, 48);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(479, 34);
            this.txtNome.TabIndex = 3;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionar.Location = new System.Drawing.Point(663, 45);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(122, 41);
            this.btnAdicionar.TabIndex = 4;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnDeletar
            // 
            this.btnDeletar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletar.Location = new System.Drawing.Point(791, 45);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(122, 41);
            this.btnDeletar.TabIndex = 5;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.UseVisualStyleBackColor = true;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // gpTipo
            // 
            this.gpTipo.Controls.Add(this.rbHashingDuplo);
            this.gpTipo.Controls.Add(this.rbSondagemQuadratica);
            this.gpTipo.Controls.Add(this.rbSondagemLinear);
            this.gpTipo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpTipo.Location = new System.Drawing.Point(25, 106);
            this.gpTipo.Name = "gpTipo";
            this.gpTipo.Size = new System.Drawing.Size(586, 88);
            this.gpTipo.TabIndex = 6;
            this.gpTipo.TabStop = false;
            this.gpTipo.Text = "Tipo de endereçamento:";
            // 
            // rbHashingDuplo
            // 
            this.rbHashingDuplo.AutoSize = true;
            this.rbHashingDuplo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbHashingDuplo.Location = new System.Drawing.Point(421, 42);
            this.rbHashingDuplo.Name = "rbHashingDuplo";
            this.rbHashingDuplo.Size = new System.Drawing.Size(142, 27);
            this.rbHashingDuplo.TabIndex = 2;
            this.rbHashingDuplo.TabStop = true;
            this.rbHashingDuplo.Text = "Hashing duplo";
            this.rbHashingDuplo.UseVisualStyleBackColor = true;
            this.rbHashingDuplo.CheckedChanged += new System.EventHandler(this.rbHashingDuplo_CheckedChanged);
            // 
            // rbSondagemQuadratica
            // 
            this.rbSondagemQuadratica.AutoSize = true;
            this.rbSondagemQuadratica.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSondagemQuadratica.Location = new System.Drawing.Point(196, 42);
            this.rbSondagemQuadratica.Name = "rbSondagemQuadratica";
            this.rbSondagemQuadratica.Size = new System.Drawing.Size(199, 27);
            this.rbSondagemQuadratica.TabIndex = 1;
            this.rbSondagemQuadratica.TabStop = true;
            this.rbSondagemQuadratica.Text = "Sondagem quadrática";
            this.rbSondagemQuadratica.UseVisualStyleBackColor = true;
            this.rbSondagemQuadratica.CheckedChanged += new System.EventHandler(this.rbSondagemQuadratica_CheckedChanged);
            // 
            // rbSondagemLinear
            // 
            this.rbSondagemLinear.AutoSize = true;
            this.rbSondagemLinear.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSondagemLinear.Location = new System.Drawing.Point(10, 42);
            this.rbSondagemLinear.Name = "rbSondagemLinear";
            this.rbSondagemLinear.Size = new System.Drawing.Size(160, 27);
            this.rbSondagemLinear.TabIndex = 0;
            this.rbSondagemLinear.TabStop = true;
            this.rbSondagemLinear.Text = "Sondagem linear";
            this.rbSondagemLinear.UseVisualStyleBackColor = true;
            this.rbSondagemLinear.CheckedChanged += new System.EventHandler(this.rbSondagemLinear_CheckedChanged);
            // 
            // dgvAluno
            // 
            this.dgvAluno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAluno.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.posicao,
            this.ra,
            this.nome});
            this.dgvAluno.Location = new System.Drawing.Point(12, 218);
            this.dgvAluno.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvAluno.Name = "dgvAluno";
            this.dgvAluno.RowHeadersWidth = 51;
            this.dgvAluno.RowTemplate.Height = 24;
            this.dgvAluno.Size = new System.Drawing.Size(901, 452);
            this.dgvAluno.TabIndex = 0;
            // 
            // posicao
            // 
            this.posicao.HeaderText = "Posição";
            this.posicao.MinimumWidth = 6;
            this.posicao.Name = "posicao";
            this.posicao.Width = 125;
            // 
            // ra
            // 
            this.ra.HeaderText = "RA";
            this.ra.MinimumWidth = 6;
            this.ra.Name = "ra";
            this.ra.Width = 175;
            // 
            // nome
            // 
            this.nome.HeaderText = "Nome";
            this.nome.MinimumWidth = 6;
            this.nome.Name = "nome";
            this.nome.Width = 550;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 682);
            this.Controls.Add(this.dgvAluno);
            this.Controls.Add(this.gpTipo);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtRA);
            this.Controls.Add(this.lbNome);
            this.Controls.Add(this.lbRA);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gpTipo.ResumeLayout(false);
            this.gpTipo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAluno)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbRA;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.TextBox txtRA;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.GroupBox gpTipo;
        private System.Windows.Forms.RadioButton rbHashingDuplo;
        private System.Windows.Forms.RadioButton rbSondagemQuadratica;
        private System.Windows.Forms.RadioButton rbSondagemLinear;
        private System.Windows.Forms.DataGridView dgvAluno;
        private System.Windows.Forms.DataGridViewTextBoxColumn posicao;
        private System.Windows.Forms.DataGridViewTextBoxColumn ra;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
    }
}

