namespace Historico_Vert.Pessoa
{
    partial class AddVacina
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
            this.grbVacina = new System.Windows.Forms.GroupBox();
            this.cbDuracao = new System.Windows.Forms.ComboBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.txtDuracao = new System.Windows.Forms.MaskedTextBox();
            this.lblDuracao = new System.Windows.Forms.Label();
            this.btnAcao = new System.Windows.Forms.Button();
            this.txtNomeVacina = new System.Windows.Forms.TextBox();
            this.lblNomeVacina = new System.Windows.Forms.Label();
            this.grbVacina.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbVacina
            // 
            this.grbVacina.Controls.Add(this.cbDuracao);
            this.grbVacina.Controls.Add(this.txtDescricao);
            this.grbVacina.Controls.Add(this.lblDescricao);
            this.grbVacina.Controls.Add(this.txtDuracao);
            this.grbVacina.Controls.Add(this.lblDuracao);
            this.grbVacina.Controls.Add(this.btnAcao);
            this.grbVacina.Controls.Add(this.txtNomeVacina);
            this.grbVacina.Controls.Add(this.lblNomeVacina);
            this.grbVacina.Location = new System.Drawing.Point(12, 17);
            this.grbVacina.Name = "grbVacina";
            this.grbVacina.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.grbVacina.Size = new System.Drawing.Size(626, 234);
            this.grbVacina.TabIndex = 8;
            this.grbVacina.TabStop = false;
            this.grbVacina.Text = "Vacina";
            // 
            // cbDuracao
            // 
            this.cbDuracao.FormattingEnabled = true;
            this.cbDuracao.Items.AddRange(new object[] {
            "Dia(s)",
            "Mês(es)",
            "Ano(s)"});
            this.cbDuracao.Location = new System.Drawing.Point(134, 64);
            this.cbDuracao.Name = "cbDuracao";
            this.cbDuracao.Size = new System.Drawing.Size(121, 21);
            this.cbDuracao.TabIndex = 18;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(98, 90);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(367, 125);
            this.txtDescricao.TabIndex = 17;
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(6, 93);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(58, 13);
            this.lblDescricao.TabIndex = 16;
            this.lblDescricao.Text = "Descrição:";
            // 
            // txtDuracao
            // 
            this.txtDuracao.Location = new System.Drawing.Point(98, 64);
            this.txtDuracao.Mask = "0###";
            this.txtDuracao.Name = "txtDuracao";
            this.txtDuracao.Size = new System.Drawing.Size(30, 20);
            this.txtDuracao.TabIndex = 15;
            // 
            // lblDuracao
            // 
            this.lblDuracao.AutoSize = true;
            this.lblDuracao.Location = new System.Drawing.Point(6, 64);
            this.lblDuracao.Name = "lblDuracao";
            this.lblDuracao.Size = new System.Drawing.Size(51, 13);
            this.lblDuracao.TabIndex = 13;
            this.lblDuracao.Text = "Duração:";
            // 
            // btnAcao
            // 
            this.btnAcao.Location = new System.Drawing.Point(486, 183);
            this.btnAcao.Name = "btnAcao";
            this.btnAcao.Size = new System.Drawing.Size(114, 32);
            this.btnAcao.TabIndex = 12;
            this.btnAcao.Text = "Cadastrar";
            this.btnAcao.UseVisualStyleBackColor = true;
            this.btnAcao.Click += new System.EventHandler(this.btnAcao_Click);
            // 
            // txtNomeVacina
            // 
            this.txtNomeVacina.Location = new System.Drawing.Point(98, 28);
            this.txtNomeVacina.Name = "txtNomeVacina";
            this.txtNomeVacina.Size = new System.Drawing.Size(205, 20);
            this.txtNomeVacina.TabIndex = 3;
            // 
            // lblNomeVacina
            // 
            this.lblNomeVacina.AutoSize = true;
            this.lblNomeVacina.Location = new System.Drawing.Point(6, 31);
            this.lblNomeVacina.Name = "lblNomeVacina";
            this.lblNomeVacina.Size = new System.Drawing.Size(74, 13);
            this.lblNomeVacina.TabIndex = 2;
            this.lblNomeVacina.Text = "Nome Vacina:";
            // 
            // AddVacina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grbVacina);
            this.Name = "AddVacina";
            this.Size = new System.Drawing.Size(651, 265);
            this.grbVacina.ResumeLayout(false);
            this.grbVacina.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbVacina;
        private System.Windows.Forms.Label lblDuracao;
        private System.Windows.Forms.Button btnAcao;
        private System.Windows.Forms.TextBox txtNomeVacina;
        private System.Windows.Forms.Label lblNomeVacina;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.MaskedTextBox txtDuracao;
        private System.Windows.Forms.ComboBox cbDuracao;
    }
}
