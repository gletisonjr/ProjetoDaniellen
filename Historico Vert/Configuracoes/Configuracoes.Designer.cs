namespace Historico_Vert.Configuracoes
{
    partial class Configuracoes
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
            this.grpConfiguracoes = new System.Windows.Forms.GroupBox();
            this.txtCidadeEstado = new System.Windows.Forms.TextBox();
            this.lblCidadeEstado = new System.Windows.Forms.Label();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.lblLogo = new System.Windows.Forms.Label();
            this.pctLogo = new System.Windows.Forms.PictureBox();
            this.fileDialog = new System.Windows.Forms.OpenFileDialog();
            this.btnLogo = new System.Windows.Forms.Button();
            this.grpConfiguracoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // grpConfiguracoes
            // 
            this.grpConfiguracoes.Controls.Add(this.btnLogo);
            this.grpConfiguracoes.Controls.Add(this.pctLogo);
            this.grpConfiguracoes.Controls.Add(this.lblLogo);
            this.grpConfiguracoes.Controls.Add(this.txtTelefone);
            this.grpConfiguracoes.Controls.Add(this.lblTelefone);
            this.grpConfiguracoes.Controls.Add(this.lblEndereco);
            this.grpConfiguracoes.Controls.Add(this.txtEndereco);
            this.grpConfiguracoes.Controls.Add(this.lblCidadeEstado);
            this.grpConfiguracoes.Controls.Add(this.txtCidadeEstado);
            this.grpConfiguracoes.Location = new System.Drawing.Point(3, 3);
            this.grpConfiguracoes.Name = "grpConfiguracoes";
            this.grpConfiguracoes.Size = new System.Drawing.Size(673, 352);
            this.grpConfiguracoes.TabIndex = 0;
            this.grpConfiguracoes.TabStop = false;
            this.grpConfiguracoes.Text = "Configurações";
            // 
            // txtCidadeEstado
            // 
            this.txtCidadeEstado.Location = new System.Drawing.Point(91, 42);
            this.txtCidadeEstado.Name = "txtCidadeEstado";
            this.txtCidadeEstado.Size = new System.Drawing.Size(302, 20);
            this.txtCidadeEstado.TabIndex = 0;
            // 
            // lblCidadeEstado
            // 
            this.lblCidadeEstado.AutoSize = true;
            this.lblCidadeEstado.Location = new System.Drawing.Point(7, 45);
            this.lblCidadeEstado.Name = "lblCidadeEstado";
            this.lblCidadeEstado.Size = new System.Drawing.Size(78, 13);
            this.lblCidadeEstado.TabIndex = 1;
            this.lblCidadeEstado.Text = "Cidade/Estado";
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Location = new System.Drawing.Point(7, 98);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(53, 13);
            this.lblEndereco.TabIndex = 3;
            this.lblEndereco.Text = "Endereço";
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(91, 95);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(409, 20);
            this.txtEndereco.TabIndex = 2;
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(7, 156);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(49, 13);
            this.lblTelefone.TabIndex = 5;
            this.lblTelefone.Text = "Telefone";
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(91, 156);
            this.txtTelefone.Mask = "(99) 9999-9999";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(90, 20);
            this.txtTelefone.TabIndex = 6;
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.Location = new System.Drawing.Point(10, 222);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(31, 13);
            this.lblLogo.TabIndex = 7;
            this.lblLogo.Text = "Logo";
            // 
            // pctLogo
            // 
            this.pctLogo.Location = new System.Drawing.Point(249, 156);
            this.pctLogo.Name = "pctLogo";
            this.pctLogo.Size = new System.Drawing.Size(251, 190);
            this.pctLogo.TabIndex = 8;
            this.pctLogo.TabStop = false;
            // 
            // fileDialog
            // 
            this.fileDialog.FileName = "FileDialog";
            // 
            // btnLogo
            // 
            this.btnLogo.Location = new System.Drawing.Point(91, 222);
            this.btnLogo.Name = "btnLogo";
            this.btnLogo.Size = new System.Drawing.Size(73, 44);
            this.btnLogo.TabIndex = 9;
            this.btnLogo.Text = "Escolher Imagem";
            this.btnLogo.UseVisualStyleBackColor = true;
            this.btnLogo.Click += new System.EventHandler(this.button1_Click);
            // 
            // Configuracoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grpConfiguracoes);
            this.Name = "Configuracoes";
            this.Size = new System.Drawing.Size(679, 358);
            this.grpConfiguracoes.ResumeLayout(false);
            this.grpConfiguracoes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpConfiguracoes;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label lblCidadeEstado;
        private System.Windows.Forms.TextBox txtCidadeEstado;
        private System.Windows.Forms.MaskedTextBox txtTelefone;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Button btnLogo;
        private System.Windows.Forms.PictureBox pctLogo;
        private System.Windows.Forms.OpenFileDialog fileDialog;
    }
}
