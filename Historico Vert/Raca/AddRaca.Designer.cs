namespace Historico_Vert
{
    partial class AddRaca
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
            this.grbRaca = new System.Windows.Forms.GroupBox();
            this.txtEspecie = new System.Windows.Forms.TextBox();
            this.lblEspecie = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.btnAcao = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.grbRaca.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbRaca
            // 
            this.grbRaca.Controls.Add(this.txtEspecie);
            this.grbRaca.Controls.Add(this.lblEspecie);
            this.grbRaca.Controls.Add(this.txtDescricao);
            this.grbRaca.Controls.Add(this.lblDescricao);
            this.grbRaca.Controls.Add(this.btnAcao);
            this.grbRaca.Controls.Add(this.txtNome);
            this.grbRaca.Controls.Add(this.lblNome);
            this.grbRaca.Location = new System.Drawing.Point(12, 13);
            this.grbRaca.Name = "grbRaca";
            this.grbRaca.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.grbRaca.Size = new System.Drawing.Size(626, 234);
            this.grbRaca.TabIndex = 10;
            this.grbRaca.TabStop = false;
            this.grbRaca.Text = "Raça";
            // 
            // txtEspecie
            // 
            this.txtEspecie.AutoCompleteCustomSource.AddRange(new string[] {
            "Cão",
            "Gato",
            "Periquito",
            "Cavalo"});
            this.txtEspecie.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtEspecie.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtEspecie.Location = new System.Drawing.Point(82, 61);
            this.txtEspecie.Name = "txtEspecie";
            this.txtEspecie.Size = new System.Drawing.Size(205, 20);
            this.txtEspecie.TabIndex = 19;
            // 
            // lblEspecie
            // 
            this.lblEspecie.AutoSize = true;
            this.lblEspecie.Location = new System.Drawing.Point(6, 64);
            this.lblEspecie.Name = "lblEspecie";
            this.lblEspecie.Size = new System.Drawing.Size(48, 13);
            this.lblEspecie.TabIndex = 18;
            this.lblEspecie.Text = "Espécie:";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(82, 92);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(367, 125);
            this.txtDescricao.TabIndex = 17;
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(6, 92);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(58, 13);
            this.lblDescricao.TabIndex = 16;
            this.lblDescricao.Text = "Descrição:";
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
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(82, 28);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(205, 20);
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
            // AddRaca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grbRaca);
            this.Name = "AddRaca";
            this.Size = new System.Drawing.Size(651, 262);
            this.grbRaca.ResumeLayout(false);
            this.grbRaca.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbRaca;
        private System.Windows.Forms.TextBox txtEspecie;
        private System.Windows.Forms.Label lblEspecie;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Button btnAcao;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
    }
}
