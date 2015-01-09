namespace Historico_Vert.Vacina
{
    partial class PesquisaVacina
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grbPesquisa = new System.Windows.Forms.GroupBox();
            this.btnPesquisa = new System.Windows.Forms.Button();
            this.txtNomeVacina = new System.Windows.Forms.TextBox();
            this.lblNomeVacina = new System.Windows.Forms.Label();
            this.grbVacina = new System.Windows.Forms.GroupBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.grbPesquisa.SuspendLayout();
            this.grbVacina.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbPesquisa
            // 
            this.grbPesquisa.Controls.Add(this.btnPesquisa);
            this.grbPesquisa.Controls.Add(this.txtNomeVacina);
            this.grbPesquisa.Controls.Add(this.lblNomeVacina);
            this.grbPesquisa.Location = new System.Drawing.Point(12, 13);
            this.grbPesquisa.Name = "grbPesquisa";
            this.grbPesquisa.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.grbPesquisa.Size = new System.Drawing.Size(605, 63);
            this.grbPesquisa.TabIndex = 18;
            this.grbPesquisa.TabStop = false;
            this.grbPesquisa.Text = "Pesquisa Vacina";
            // 
            // btnPesquisa
            // 
            this.btnPesquisa.Location = new System.Drawing.Point(468, 21);
            this.btnPesquisa.Name = "btnPesquisa";
            this.btnPesquisa.Size = new System.Drawing.Size(114, 32);
            this.btnPesquisa.TabIndex = 12;
            this.btnPesquisa.Text = "Pesquisar";
            this.btnPesquisa.UseVisualStyleBackColor = true;
            this.btnPesquisa.Click += new System.EventHandler(this.btnPesquisa_Click);
            // 
            // txtNomeVacina
            // 
            this.txtNomeVacina.Location = new System.Drawing.Point(98, 28);
            this.txtNomeVacina.Name = "txtNomeVacina";
            this.txtNomeVacina.Size = new System.Drawing.Size(351, 20);
            this.txtNomeVacina.TabIndex = 3;
            // 
            // lblNomeVacina
            // 
            this.lblNomeVacina.AutoSize = true;
            this.lblNomeVacina.Location = new System.Drawing.Point(6, 31);
            this.lblNomeVacina.Name = "lblNomeVacina";
            this.lblNomeVacina.Size = new System.Drawing.Size(71, 13);
            this.lblNomeVacina.TabIndex = 2;
            this.lblNomeVacina.Text = "Nome Vacina";
            // 
            // grbVacina
            // 
            this.grbVacina.Controls.Add(this.btnEditar);
            this.grbVacina.Controls.Add(this.btnAtualizar);
            this.grbVacina.Controls.Add(this.txtDescricao);
            this.grbVacina.Controls.Add(this.lblDescricao);
            this.grbVacina.Controls.Add(this.txtNome);
            this.grbVacina.Controls.Add(this.lblNome);
            this.grbVacina.Location = new System.Drawing.Point(12, 82);
            this.grbVacina.Name = "grbVacina";
            this.grbVacina.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.grbVacina.Size = new System.Drawing.Size(605, 193);
            this.grbVacina.TabIndex = 17;
            this.grbVacina.TabStop = false;
            this.grbVacina.Text = "Vacina";
            this.grbVacina.Visible = false;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(82, 54);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.ReadOnly = true;
            this.txtDescricao.Size = new System.Drawing.Size(367, 125);
            this.txtDescricao.TabIndex = 17;
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(6, 54);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(58, 13);
            this.lblDescricao.TabIndex = 16;
            this.lblDescricao.Text = "Descrição:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(82, 28);
            this.txtNome.Name = "txtNome";
            this.txtNome.ReadOnly = true;
            this.txtNome.Size = new System.Drawing.Size(367, 20);
            this.txtNome.TabIndex = 3;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(6, 31);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 2;
            this.lblNome.Text = "Nome:";
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(468, 65);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(114, 32);
            this.btnEditar.TabIndex = 30;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(468, 103);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(114, 32);
            this.btnAtualizar.TabIndex = 29;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // PesquisaVacina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grbPesquisa);
            this.Controls.Add(this.grbVacina);
            this.Name = "PesquisaVacina";
            this.Size = new System.Drawing.Size(709, 307);
            this.grbPesquisa.ResumeLayout(false);
            this.grbPesquisa.PerformLayout();
            this.grbVacina.ResumeLayout(false);
            this.grbVacina.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbPesquisa;
        private System.Windows.Forms.Button btnPesquisa;
        private System.Windows.Forms.TextBox txtNomeVacina;
        private System.Windows.Forms.Label lblNomeVacina;
        private System.Windows.Forms.GroupBox grbVacina;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnAtualizar;
    }
}
