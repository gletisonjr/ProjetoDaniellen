namespace Historico_Vert
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmiPrincipal = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiProntuario = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiProntuarioNovo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiProntuarioPesquisar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPaciente = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPacienteNovo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPacientePesquisar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDono = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDonoNovo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDonoPesquisar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEspecie = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEspecieNovo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEspeciePesquisar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRaca = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRacaNovo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRacaPesquisar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMedico = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMedicoNovo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMedicoPesquisar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiVacina = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiVacinaNovo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiVacinaPesquisar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiBanhoTosa = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiBanhoTosaNovo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiBanhoTosaPesquisar = new System.Windows.Forms.ToolStripMenuItem();
            this.configuraçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiPrincipal,
            this.tsmiProntuario,
            this.tsmiPaciente,
            this.tsmiDono,
            this.tsmiEspecie,
            this.tsmiRaca,
            this.tsmiMedico,
            this.tsmiVacina,
            this.tsmiBanhoTosa,
            this.configuraçõesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(819, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmiPrincipal
            // 
            this.tsmiPrincipal.Name = "tsmiPrincipal";
            this.tsmiPrincipal.Size = new System.Drawing.Size(48, 20);
            this.tsmiPrincipal.Text = "Inicio";
            this.tsmiPrincipal.Click += new System.EventHandler(this.tsmiPrincipal_Click);
            // 
            // tsmiProntuario
            // 
            this.tsmiProntuario.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiProntuarioNovo,
            this.tsmiProntuarioPesquisar});
            this.tsmiProntuario.Name = "tsmiProntuario";
            this.tsmiProntuario.Size = new System.Drawing.Size(75, 20);
            this.tsmiProntuario.Text = "Prontuário";
            // 
            // tsmiProntuarioNovo
            // 
            this.tsmiProntuarioNovo.Name = "tsmiProntuarioNovo";
            this.tsmiProntuarioNovo.Size = new System.Drawing.Size(124, 22);
            this.tsmiProntuarioNovo.Text = "Novo";
            this.tsmiProntuarioNovo.Click += new System.EventHandler(this.tsmiProntuarioNovo_Click);
            // 
            // tsmiProntuarioPesquisar
            // 
            this.tsmiProntuarioPesquisar.Name = "tsmiProntuarioPesquisar";
            this.tsmiProntuarioPesquisar.Size = new System.Drawing.Size(124, 22);
            this.tsmiProntuarioPesquisar.Text = "Pesquisar";
            this.tsmiProntuarioPesquisar.Click += new System.EventHandler(this.tsmiProntuarioPesquisar_Click);
            // 
            // tsmiPaciente
            // 
            this.tsmiPaciente.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiPacienteNovo,
            this.tsmiPacientePesquisar});
            this.tsmiPaciente.Name = "tsmiPaciente";
            this.tsmiPaciente.Size = new System.Drawing.Size(64, 20);
            this.tsmiPaciente.Text = "Paciente";
            // 
            // tsmiPacienteNovo
            // 
            this.tsmiPacienteNovo.Name = "tsmiPacienteNovo";
            this.tsmiPacienteNovo.Size = new System.Drawing.Size(124, 22);
            this.tsmiPacienteNovo.Text = "Novo";
            this.tsmiPacienteNovo.Click += new System.EventHandler(this.tsmiPacienteNovo_Click);
            // 
            // tsmiPacientePesquisar
            // 
            this.tsmiPacientePesquisar.Name = "tsmiPacientePesquisar";
            this.tsmiPacientePesquisar.Size = new System.Drawing.Size(124, 22);
            this.tsmiPacientePesquisar.Text = "Pesquisar";
            this.tsmiPacientePesquisar.Click += new System.EventHandler(this.tsmiPacientePesquisar_Click);
            // 
            // tsmiDono
            // 
            this.tsmiDono.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiDonoNovo,
            this.tsmiDonoPesquisar});
            this.tsmiDono.Name = "tsmiDono";
            this.tsmiDono.Size = new System.Drawing.Size(48, 20);
            this.tsmiDono.Text = "Dono";
            // 
            // tsmiDonoNovo
            // 
            this.tsmiDonoNovo.Name = "tsmiDonoNovo";
            this.tsmiDonoNovo.Size = new System.Drawing.Size(124, 22);
            this.tsmiDonoNovo.Text = "Novo";
            this.tsmiDonoNovo.Click += new System.EventHandler(this.tsmiDonoNovo_Click);
            // 
            // tsmiDonoPesquisar
            // 
            this.tsmiDonoPesquisar.Name = "tsmiDonoPesquisar";
            this.tsmiDonoPesquisar.Size = new System.Drawing.Size(124, 22);
            this.tsmiDonoPesquisar.Text = "Pesquisar";
            this.tsmiDonoPesquisar.Click += new System.EventHandler(this.tsmiDonoPesquisar_Click);
            // 
            // tsmiEspecie
            // 
            this.tsmiEspecie.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiEspecieNovo,
            this.tsmiEspeciePesquisar});
            this.tsmiEspecie.Name = "tsmiEspecie";
            this.tsmiEspecie.Size = new System.Drawing.Size(58, 20);
            this.tsmiEspecie.Text = "Espécie";
            // 
            // tsmiEspecieNovo
            // 
            this.tsmiEspecieNovo.Name = "tsmiEspecieNovo";
            this.tsmiEspecieNovo.Size = new System.Drawing.Size(124, 22);
            this.tsmiEspecieNovo.Text = "Novo";
            this.tsmiEspecieNovo.Click += new System.EventHandler(this.tsmiEspecieNovo_Click);
            // 
            // tsmiEspeciePesquisar
            // 
            this.tsmiEspeciePesquisar.Name = "tsmiEspeciePesquisar";
            this.tsmiEspeciePesquisar.Size = new System.Drawing.Size(124, 22);
            this.tsmiEspeciePesquisar.Text = "Pesquisar";
            this.tsmiEspeciePesquisar.Click += new System.EventHandler(this.tsmiEspeciePesquisar_Click);
            // 
            // tsmiRaca
            // 
            this.tsmiRaca.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiRacaNovo,
            this.tsmiRacaPesquisar});
            this.tsmiRaca.Name = "tsmiRaca";
            this.tsmiRaca.Size = new System.Drawing.Size(44, 20);
            this.tsmiRaca.Text = "Raça";
            // 
            // tsmiRacaNovo
            // 
            this.tsmiRacaNovo.Name = "tsmiRacaNovo";
            this.tsmiRacaNovo.Size = new System.Drawing.Size(124, 22);
            this.tsmiRacaNovo.Text = "Novo";
            this.tsmiRacaNovo.Click += new System.EventHandler(this.tsmiRacaNovo_Click);
            // 
            // tsmiRacaPesquisar
            // 
            this.tsmiRacaPesquisar.Name = "tsmiRacaPesquisar";
            this.tsmiRacaPesquisar.Size = new System.Drawing.Size(124, 22);
            this.tsmiRacaPesquisar.Text = "Pesquisar";
            this.tsmiRacaPesquisar.Click += new System.EventHandler(this.tsmiRacaPesquisar_Click);
            // 
            // tsmiMedico
            // 
            this.tsmiMedico.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiMedicoNovo,
            this.tsmiMedicoPesquisar});
            this.tsmiMedico.Name = "tsmiMedico";
            this.tsmiMedico.Size = new System.Drawing.Size(59, 20);
            this.tsmiMedico.Text = "Médico";
            // 
            // tsmiMedicoNovo
            // 
            this.tsmiMedicoNovo.Name = "tsmiMedicoNovo";
            this.tsmiMedicoNovo.Size = new System.Drawing.Size(124, 22);
            this.tsmiMedicoNovo.Text = "Novo";
            this.tsmiMedicoNovo.Click += new System.EventHandler(this.tsmiMedicoNovo_Click);
            // 
            // tsmiMedicoPesquisar
            // 
            this.tsmiMedicoPesquisar.Name = "tsmiMedicoPesquisar";
            this.tsmiMedicoPesquisar.Size = new System.Drawing.Size(124, 22);
            this.tsmiMedicoPesquisar.Text = "Pesquisar";
            this.tsmiMedicoPesquisar.Click += new System.EventHandler(this.tsmiMedicoPesquisar_Click);
            // 
            // tsmiVacina
            // 
            this.tsmiVacina.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiVacinaNovo,
            this.tsmiVacinaPesquisar});
            this.tsmiVacina.Name = "tsmiVacina";
            this.tsmiVacina.Size = new System.Drawing.Size(54, 20);
            this.tsmiVacina.Text = "Vacina";
            // 
            // tsmiVacinaNovo
            // 
            this.tsmiVacinaNovo.Name = "tsmiVacinaNovo";
            this.tsmiVacinaNovo.Size = new System.Drawing.Size(124, 22);
            this.tsmiVacinaNovo.Text = "Novo";
            this.tsmiVacinaNovo.Click += new System.EventHandler(this.tsmiVacinaNovo_Click);
            // 
            // tsmiVacinaPesquisar
            // 
            this.tsmiVacinaPesquisar.Name = "tsmiVacinaPesquisar";
            this.tsmiVacinaPesquisar.Size = new System.Drawing.Size(124, 22);
            this.tsmiVacinaPesquisar.Text = "Pesquisar";
            this.tsmiVacinaPesquisar.Click += new System.EventHandler(this.tsmiVacinaPesquisar_Click);
            // 
            // tsmiBanhoTosa
            // 
            this.tsmiBanhoTosa.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiBanhoTosaNovo,
            this.tsmiBanhoTosaPesquisar});
            this.tsmiBanhoTosa.Name = "tsmiBanhoTosa";
            this.tsmiBanhoTosa.Size = new System.Drawing.Size(83, 20);
            this.tsmiBanhoTosa.Text = "Banho/Tosa";
            // 
            // tsmiBanhoTosaNovo
            // 
            this.tsmiBanhoTosaNovo.Name = "tsmiBanhoTosaNovo";
            this.tsmiBanhoTosaNovo.Size = new System.Drawing.Size(152, 22);
            this.tsmiBanhoTosaNovo.Text = "Novo";
            this.tsmiBanhoTosaNovo.Click += new System.EventHandler(this.tsmiBanhoTosaNovo_Click);
            // 
            // tsmiBanhoTosaPesquisar
            // 
            this.tsmiBanhoTosaPesquisar.Name = "tsmiBanhoTosaPesquisar";
            this.tsmiBanhoTosaPesquisar.Size = new System.Drawing.Size(152, 22);
            this.tsmiBanhoTosaPesquisar.Text = "Pesquisar";
            this.tsmiBanhoTosaPesquisar.Click += new System.EventHandler(this.tsmiBanhoTosaPesquisar_Click);
            // 
            // configuraçõesToolStripMenuItem
            // 
            this.configuraçõesToolStripMenuItem.Name = "configuraçõesToolStripMenuItem";
            this.configuraçõesToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.configuraçõesToolStripMenuItem.Text = "Configurações";
            this.configuraçõesToolStripMenuItem.Click += new System.EventHandler(this.configuraçõesToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(819, 429);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Sistema de ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiPrincipal;
        private System.Windows.Forms.ToolStripMenuItem tsmiProntuario;
        private System.Windows.Forms.ToolStripMenuItem tsmiProntuarioNovo;
        private System.Windows.Forms.ToolStripMenuItem tsmiProntuarioPesquisar;
        private System.Windows.Forms.ToolStripMenuItem tsmiPaciente;
        private System.Windows.Forms.ToolStripMenuItem tsmiPacienteNovo;
        private System.Windows.Forms.ToolStripMenuItem tsmiPacientePesquisar;
        private System.Windows.Forms.ToolStripMenuItem tsmiDono;
        private System.Windows.Forms.ToolStripMenuItem tsmiDonoNovo;
        private System.Windows.Forms.ToolStripMenuItem tsmiDonoPesquisar;
        private System.Windows.Forms.ToolStripMenuItem tsmiEspecie;
        private System.Windows.Forms.ToolStripMenuItem tsmiEspecieNovo;
        private System.Windows.Forms.ToolStripMenuItem tsmiEspeciePesquisar;
        private System.Windows.Forms.ToolStripMenuItem tsmiRaca;
        private System.Windows.Forms.ToolStripMenuItem tsmiRacaNovo;
        private System.Windows.Forms.ToolStripMenuItem tsmiRacaPesquisar;
        private System.Windows.Forms.ToolStripMenuItem tsmiMedico;
        private System.Windows.Forms.ToolStripMenuItem tsmiMedicoNovo;
        private System.Windows.Forms.ToolStripMenuItem tsmiMedicoPesquisar;
        private System.Windows.Forms.ToolStripMenuItem tsmiVacina;
        private System.Windows.Forms.ToolStripMenuItem tsmiVacinaNovo;
        private System.Windows.Forms.ToolStripMenuItem tsmiVacinaPesquisar;
        private System.Windows.Forms.ToolStripMenuItem tsmiBanhoTosa;
        private System.Windows.Forms.ToolStripMenuItem tsmiBanhoTosaNovo;
        private System.Windows.Forms.ToolStripMenuItem tsmiBanhoTosaPesquisar;
        private System.Windows.Forms.ToolStripMenuItem configuraçõesToolStripMenuItem;
    }
}

