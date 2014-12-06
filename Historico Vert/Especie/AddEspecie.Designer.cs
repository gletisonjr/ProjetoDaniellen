namespace Historico_Vert
{
    partial class AddEspecie
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
            this.grbEspecie = new System.Windows.Forms.GroupBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.btnAcao = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.grbEspecie.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbEspecie
            // 
            this.grbEspecie.Controls.Add(this.txtDescricao);
            this.grbEspecie.Controls.Add(this.lblDescricao);
            this.grbEspecie.Controls.Add(this.btnAcao);
            this.grbEspecie.Controls.Add(this.txtNome);
            this.grbEspecie.Controls.Add(this.lblNome);
            this.grbEspecie.Location = new System.Drawing.Point(12, 13);
            this.grbEspecie.Name = "grbEspecie";
            this.grbEspecie.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.grbEspecie.Size = new System.Drawing.Size(626, 193);
            this.grbEspecie.TabIndex = 9;
            this.grbEspecie.TabStop = false;
            this.grbEspecie.Text = "Espécie";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(82, 54);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
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
            // btnAcao
            // 
            this.btnAcao.Location = new System.Drawing.Point(486, 145);
            this.btnAcao.Name = "btnAcao";
            this.btnAcao.Size = new System.Drawing.Size(114, 32);
            this.btnAcao.TabIndex = 12;
            this.btnAcao.Text = "Cadastrar";
            this.btnAcao.UseVisualStyleBackColor = true;
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
            // Especie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grbEspecie);
            this.Name = "Especie";
            this.Size = new System.Drawing.Size(651, 220);
            this.Load += new System.EventHandler(this.Especie_Load);
            this.grbEspecie.ResumeLayout(false);
            this.grbEspecie.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbEspecie;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Button btnAcao;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
    }
}
