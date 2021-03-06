﻿namespace Historico_Vert.GUI.Especie
{
    partial class PesquisaEspecie
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
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.grbPesquisa = new System.Windows.Forms.GroupBox();
            this.btnPesquisa = new System.Windows.Forms.Button();
            this.txtNomeEspecie = new System.Windows.Forms.TextBox();
            this.lblNomeEspecie = new System.Windows.Forms.Label();
            this.grbEspecie.SuspendLayout();
            this.grbPesquisa.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbEspecie
            // 
            this.grbEspecie.Controls.Add(this.btnEditar);
            this.grbEspecie.Controls.Add(this.btnAtualizar);
            this.grbEspecie.Controls.Add(this.txtDescricao);
            this.grbEspecie.Controls.Add(this.lblDescricao);
            this.grbEspecie.Controls.Add(this.txtNome);
            this.grbEspecie.Controls.Add(this.lblNome);
            this.grbEspecie.Location = new System.Drawing.Point(12, 82);
            this.grbEspecie.Name = "grbEspecie";
            this.grbEspecie.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.grbEspecie.Size = new System.Drawing.Size(578, 193);
            this.grbEspecie.TabIndex = 10;
            this.grbEspecie.TabStop = false;
            this.grbEspecie.Text = "Espécie";
            this.grbEspecie.Visible = false;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(458, 69);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(114, 32);
            this.btnEditar.TabIndex = 5;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(458, 107);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(114, 32);
            this.btnAtualizar.TabIndex = 6;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(82, 54);
            this.txtDescricao.MaxLength = 50;
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.ReadOnly = true;
            this.txtDescricao.Size = new System.Drawing.Size(367, 125);
            this.txtDescricao.TabIndex = 4;
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
            this.txtNome.MaxLength = 100;
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
            // grbPesquisa
            // 
            this.grbPesquisa.Controls.Add(this.btnPesquisa);
            this.grbPesquisa.Controls.Add(this.txtNomeEspecie);
            this.grbPesquisa.Controls.Add(this.lblNomeEspecie);
            this.grbPesquisa.Location = new System.Drawing.Point(12, 13);
            this.grbPesquisa.Name = "grbPesquisa";
            this.grbPesquisa.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.grbPesquisa.Size = new System.Drawing.Size(578, 63);
            this.grbPesquisa.TabIndex = 16;
            this.grbPesquisa.TabStop = false;
            this.grbPesquisa.Text = "Pesquisa Espécie";
            // 
            // btnPesquisa
            // 
            this.btnPesquisa.Location = new System.Drawing.Point(458, 21);
            this.btnPesquisa.Name = "btnPesquisa";
            this.btnPesquisa.Size = new System.Drawing.Size(114, 32);
            this.btnPesquisa.TabIndex = 12;
            this.btnPesquisa.Text = "Pesquisar";
            this.btnPesquisa.UseVisualStyleBackColor = true;
            this.btnPesquisa.Click += new System.EventHandler(this.btnPesquisa_Click);
            // 
            // txtNomeEspecie
            // 
            this.txtNomeEspecie.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtNomeEspecie.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtNomeEspecie.Location = new System.Drawing.Point(98, 28);
            this.txtNomeEspecie.MaxLength = 100;
            this.txtNomeEspecie.Name = "txtNomeEspecie";
            this.txtNomeEspecie.Size = new System.Drawing.Size(338, 20);
            this.txtNomeEspecie.TabIndex = 3;
            // 
            // lblNomeEspecie
            // 
            this.lblNomeEspecie.AutoSize = true;
            this.lblNomeEspecie.Location = new System.Drawing.Point(6, 31);
            this.lblNomeEspecie.Name = "lblNomeEspecie";
            this.lblNomeEspecie.Size = new System.Drawing.Size(79, 13);
            this.lblNomeEspecie.TabIndex = 2;
            this.lblNomeEspecie.Text = "Nome Espécie:";
            // 
            // PesquisaEspecie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grbPesquisa);
            this.Controls.Add(this.grbEspecie);
            this.Name = "PesquisaEspecie";
            this.Size = new System.Drawing.Size(751, 305);
            this.grbEspecie.ResumeLayout(false);
            this.grbEspecie.PerformLayout();
            this.grbPesquisa.ResumeLayout(false);
            this.grbPesquisa.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbEspecie;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.GroupBox grbPesquisa;
        private System.Windows.Forms.Button btnPesquisa;
        private System.Windows.Forms.TextBox txtNomeEspecie;
        private System.Windows.Forms.Label lblNomeEspecie;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.TextBox txtNome;
    }
}
