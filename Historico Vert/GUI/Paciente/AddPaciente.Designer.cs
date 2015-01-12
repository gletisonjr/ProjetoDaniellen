namespace Historico_Vert
{
    partial class AddPaciente
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
            this.grbAnimal = new System.Windows.Forms.GroupBox();
            this.dtpDataEntrada = new System.Windows.Forms.DateTimePicker();
            this.lblDataEntrada = new System.Windows.Forms.Label();
            this.txtCor = new System.Windows.Forms.TextBox();
            this.lblCor = new System.Windows.Forms.Label();
            this.btAcao = new System.Windows.Forms.Button();
            this.rdbOutra = new System.Windows.Forms.RadioButton();
            this.rdbGato = new System.Windows.Forms.RadioButton();
            this.rdbCao = new System.Windows.Forms.RadioButton();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.txtRaca = new System.Windows.Forms.TextBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblRaca = new System.Windows.Forms.Label();
            this.txtEspecie = new System.Windows.Forms.TextBox();
            this.lblEspecie = new System.Windows.Forms.Label();
            this.txtIdade = new System.Windows.Forms.TextBox();
            this.lblIdade = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.grbAnimal.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbAnimal
            // 
            this.grbAnimal.Controls.Add(this.dtpDataEntrada);
            this.grbAnimal.Controls.Add(this.lblDataEntrada);
            this.grbAnimal.Controls.Add(this.txtCor);
            this.grbAnimal.Controls.Add(this.lblCor);
            this.grbAnimal.Controls.Add(this.btAcao);
            this.grbAnimal.Controls.Add(this.rdbOutra);
            this.grbAnimal.Controls.Add(this.rdbGato);
            this.grbAnimal.Controls.Add(this.rdbCao);
            this.grbAnimal.Controls.Add(this.txtCliente);
            this.grbAnimal.Controls.Add(this.txtRaca);
            this.grbAnimal.Controls.Add(this.lblCliente);
            this.grbAnimal.Controls.Add(this.lblRaca);
            this.grbAnimal.Controls.Add(this.txtEspecie);
            this.grbAnimal.Controls.Add(this.lblEspecie);
            this.grbAnimal.Controls.Add(this.txtIdade);
            this.grbAnimal.Controls.Add(this.lblIdade);
            this.grbAnimal.Controls.Add(this.txtNome);
            this.grbAnimal.Controls.Add(this.lblNome);
            this.grbAnimal.Location = new System.Drawing.Point(13, 13);
            this.grbAnimal.Name = "grbAnimal";
            this.grbAnimal.Size = new System.Drawing.Size(576, 249);
            this.grbAnimal.TabIndex = 0;
            this.grbAnimal.TabStop = false;
            this.grbAnimal.Text = "Paciente";
            // 
            // dtpDataEntrada
            // 
            this.dtpDataEntrada.Location = new System.Drawing.Point(77, 216);
            this.dtpDataEntrada.Name = "dtpDataEntrada";
            this.dtpDataEntrada.Size = new System.Drawing.Size(240, 20);
            this.dtpDataEntrada.TabIndex = 34;
            // 
            // lblDataEntrada
            // 
            this.lblDataEntrada.AutoSize = true;
            this.lblDataEntrada.Location = new System.Drawing.Point(18, 200);
            this.lblDataEntrada.Name = "lblDataEntrada";
            this.lblDataEntrada.Size = new System.Drawing.Size(70, 13);
            this.lblDataEntrada.TabIndex = 33;
            this.lblDataEntrada.Text = "Data Entrada";
            // 
            // txtCor
            // 
            this.txtCor.AutoCompleteCustomSource.AddRange(new string[] {
            "Felipe",
            "Lucas",
            "Geraldo"});
            this.txtCor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtCor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtCor.Location = new System.Drawing.Point(77, 167);
            this.txtCor.Name = "txtCor";
            this.txtCor.Size = new System.Drawing.Size(222, 20);
            this.txtCor.TabIndex = 32;
            // 
            // lblCor
            // 
            this.lblCor.AutoSize = true;
            this.lblCor.Location = new System.Drawing.Point(18, 174);
            this.lblCor.Name = "lblCor";
            this.lblCor.Size = new System.Drawing.Size(23, 13);
            this.lblCor.TabIndex = 31;
            this.lblCor.Text = "Cor";
            // 
            // btAcao
            // 
            this.btAcao.Location = new System.Drawing.Point(420, 200);
            this.btAcao.Name = "btAcao";
            this.btAcao.Size = new System.Drawing.Size(113, 36);
            this.btAcao.TabIndex = 30;
            this.btAcao.Text = "Cadastrar";
            this.btAcao.UseVisualStyleBackColor = true;
            this.btAcao.Click += new System.EventHandler(this.btAcao_Click);
            // 
            // rdbOutra
            // 
            this.rdbOutra.AutoSize = true;
            this.rdbOutra.Location = new System.Drawing.Point(226, 115);
            this.rdbOutra.Name = "rdbOutra";
            this.rdbOutra.Size = new System.Drawing.Size(51, 17);
            this.rdbOutra.TabIndex = 14;
            this.rdbOutra.TabStop = true;
            this.rdbOutra.Text = "Outra";
            this.rdbOutra.UseVisualStyleBackColor = true;
            this.rdbOutra.CheckedChanged += new System.EventHandler(this.rdbOutra_CheckedChanged);
            // 
            // rdbGato
            // 
            this.rdbGato.AutoSize = true;
            this.rdbGato.Location = new System.Drawing.Point(151, 115);
            this.rdbGato.Name = "rdbGato";
            this.rdbGato.Size = new System.Drawing.Size(48, 17);
            this.rdbGato.TabIndex = 13;
            this.rdbGato.TabStop = true;
            this.rdbGato.Text = "Gato";
            this.rdbGato.UseVisualStyleBackColor = true;
            this.rdbGato.CheckedChanged += new System.EventHandler(this.rdbGato_CheckedChanged);
            // 
            // rdbCao
            // 
            this.rdbCao.AutoSize = true;
            this.rdbCao.Location = new System.Drawing.Point(77, 115);
            this.rdbCao.Name = "rdbCao";
            this.rdbCao.Size = new System.Drawing.Size(44, 17);
            this.rdbCao.TabIndex = 12;
            this.rdbCao.TabStop = true;
            this.rdbCao.Text = "Cao";
            this.rdbCao.UseVisualStyleBackColor = true;
            this.rdbCao.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // txtCliente
            // 
            this.txtCliente.AutoCompleteCustomSource.AddRange(new string[] {
            "Felipe",
            "Lucas",
            "Geraldo"});
            this.txtCliente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtCliente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtCliente.Location = new System.Drawing.Point(77, 19);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(222, 20);
            this.txtCliente.TabIndex = 5;
            // 
            // txtRaca
            // 
            this.txtRaca.Location = new System.Drawing.Point(77, 141);
            this.txtRaca.Name = "txtRaca";
            this.txtRaca.Size = new System.Drawing.Size(222, 20);
            this.txtRaca.TabIndex = 11;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(18, 26);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(33, 13);
            this.lblCliente.TabIndex = 4;
            this.lblCliente.Text = "Dono";
            // 
            // lblRaca
            // 
            this.lblRaca.AutoSize = true;
            this.lblRaca.Location = new System.Drawing.Point(18, 148);
            this.lblRaca.Name = "lblRaca";
            this.lblRaca.Size = new System.Drawing.Size(33, 13);
            this.lblRaca.TabIndex = 10;
            this.lblRaca.Text = "Raça";
            // 
            // txtEspecie
            // 
            this.txtEspecie.Location = new System.Drawing.Point(311, 114);
            this.txtEspecie.Name = "txtEspecie";
            this.txtEspecie.Size = new System.Drawing.Size(222, 20);
            this.txtEspecie.TabIndex = 9;
            this.txtEspecie.Visible = false;
            // 
            // lblEspecie
            // 
            this.lblEspecie.AutoSize = true;
            this.lblEspecie.Location = new System.Drawing.Point(18, 117);
            this.lblEspecie.Name = "lblEspecie";
            this.lblEspecie.Size = new System.Drawing.Size(45, 13);
            this.lblEspecie.TabIndex = 8;
            this.lblEspecie.Text = "Espécie";
            // 
            // txtIdade
            // 
            this.txtIdade.Location = new System.Drawing.Point(77, 79);
            this.txtIdade.Name = "txtIdade";
            this.txtIdade.Size = new System.Drawing.Size(222, 20);
            this.txtIdade.TabIndex = 7;
            // 
            // lblIdade
            // 
            this.lblIdade.AutoSize = true;
            this.lblIdade.Location = new System.Drawing.Point(18, 86);
            this.lblIdade.Name = "lblIdade";
            this.lblIdade.Size = new System.Drawing.Size(34, 13);
            this.lblIdade.TabIndex = 6;
            this.lblIdade.Text = "Idade";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(77, 49);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(222, 20);
            this.txtNome.TabIndex = 5;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(18, 56);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 4;
            this.lblNome.Text = "Nome";
            // 
            // AddPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grbAnimal);
            this.Name = "AddPaciente";
            this.Size = new System.Drawing.Size(592, 275);
            this.Load += new System.EventHandler(this.AddPaciente_Load);
            this.grbAnimal.ResumeLayout(false);
            this.grbAnimal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbAnimal;
        private System.Windows.Forms.RadioButton rdbCao;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.TextBox txtRaca;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblRaca;
        private System.Windows.Forms.TextBox txtEspecie;
        private System.Windows.Forms.Label lblEspecie;
        private System.Windows.Forms.TextBox txtIdade;
        private System.Windows.Forms.Label lblIdade;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.RadioButton rdbOutra;
        private System.Windows.Forms.RadioButton rdbGato;
        private System.Windows.Forms.Button btAcao;
        private System.Windows.Forms.TextBox txtCor;
        private System.Windows.Forms.Label lblCor;
        private System.Windows.Forms.DateTimePicker dtpDataEntrada;
        private System.Windows.Forms.Label lblDataEntrada;
    }
}
