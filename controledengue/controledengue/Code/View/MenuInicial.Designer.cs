﻿namespace controledengue.Code.View
{
    partial class MenuInicial
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
            this.btCadUni = new System.Windows.Forms.Button();
            this.btCadAgente = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btAgenda = new System.Windows.Forms.Button();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.configuraçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redefinirSenhaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redefinirSenhaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.entrarComOutraContaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btCadUni
            // 
            this.btCadUni.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btCadUni.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.btCadUni.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btCadUni.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCadUni.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCadUni.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btCadUni.Location = new System.Drawing.Point(246, 226);
            this.btCadUni.Name = "btCadUni";
            this.btCadUni.Size = new System.Drawing.Size(367, 59);
            this.btCadUni.TabIndex = 7;
            this.btCadUni.Text = "Cadastro de unidades ";
            this.btCadUni.UseVisualStyleBackColor = true;
            this.btCadUni.Click += new System.EventHandler(this.btCadUni_Click);
            // 
            // btCadAgente
            // 
            this.btCadAgente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.btCadAgente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btCadAgente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCadAgente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCadAgente.Location = new System.Drawing.Point(246, 308);
            this.btCadAgente.Name = "btCadAgente";
            this.btCadAgente.Size = new System.Drawing.Size(367, 59);
            this.btCadAgente.TabIndex = 8;
            this.btCadAgente.Text = "Cadastrar  agentes ";
            this.btCadAgente.UseVisualStyleBackColor = true;
            this.btCadAgente.Click += new System.EventHandler(this.btCadAgente_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 68.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(319, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 102);
            this.label1.TabIndex = 9;
            this.label1.Text = "A2Z";
            // 
            // btAgenda
            // 
            this.btAgenda.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.btAgenda.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btAgenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAgenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAgenda.Location = new System.Drawing.Point(246, 391);
            this.btAgenda.Name = "btAgenda";
            this.btAgenda.Size = new System.Drawing.Size(367, 59);
            this.btAgenda.TabIndex = 10;
            this.btAgenda.Text = "Agendamentos";
            this.btAgenda.UseVisualStyleBackColor = true;
            this.btAgenda.Click += new System.EventHandler(this.btAgenda_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(0, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(100, 23);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "A2Z";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Blue;
            this.menuStrip1.BackgroundImage = global::controledengue.Properties.Resources.azul;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configuraçõesToolStripMenuItem,
            this.ajudaToolStripMenuItem,
            this.sobreToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(20, 60);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(809, 28);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // configuraçõesToolStripMenuItem
            // 
            this.configuraçõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.redefinirSenhaToolStripMenuItem,
            this.entrarComOutraContaToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.configuraçõesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.configuraçõesToolStripMenuItem.Name = "configuraçõesToolStripMenuItem";
            this.configuraçõesToolStripMenuItem.Size = new System.Drawing.Size(116, 24);
            this.configuraçõesToolStripMenuItem.Text = "Configurações";
            // 
            // redefinirSenhaToolStripMenuItem
            // 
            this.redefinirSenhaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.redefinirSenhaToolStripMenuItem1});
            this.redefinirSenhaToolStripMenuItem.Name = "redefinirSenhaToolStripMenuItem";
            this.redefinirSenhaToolStripMenuItem.Size = new System.Drawing.Size(230, 24);
            this.redefinirSenhaToolStripMenuItem.Text = "Conta de usuário ";
            this.redefinirSenhaToolStripMenuItem.Click += new System.EventHandler(this.redefinirSenhaToolStripMenuItem_Click);
            // 
            // redefinirSenhaToolStripMenuItem1
            // 
            this.redefinirSenhaToolStripMenuItem1.Name = "redefinirSenhaToolStripMenuItem1";
            this.redefinirSenhaToolStripMenuItem1.Size = new System.Drawing.Size(180, 24);
            this.redefinirSenhaToolStripMenuItem1.Text = "Redefinir senha";
            this.redefinirSenhaToolStripMenuItem1.Click += new System.EventHandler(this.redefinirSenhaToolStripMenuItem1_Click);
            // 
            // entrarComOutraContaToolStripMenuItem
            // 
            this.entrarComOutraContaToolStripMenuItem.Name = "entrarComOutraContaToolStripMenuItem";
            this.entrarComOutraContaToolStripMenuItem.Size = new System.Drawing.Size(230, 24);
            this.entrarComOutraContaToolStripMenuItem.Text = "Entrar com outra conta";
            this.entrarComOutraContaToolStripMenuItem.Click += new System.EventHandler(this.entrarComOutraContaToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(230, 24);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.ajudaToolStripMenuItem.Text = "Ajuda";
            this.ajudaToolStripMenuItem.Click += new System.EventHandler(this.ajudaToolStripMenuItem_Click);
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.sobreToolStripMenuItem.Text = "Sobre";
            this.sobreToolStripMenuItem.Click += new System.EventHandler(this.sobreToolStripMenuItem_Click);
            // 
            // MenuInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 480);
            this.Controls.Add(this.btAgenda);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btCadAgente);
            this.Controls.Add(this.btCadUni);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MenuInicial";
            this.Text = "Menu Inicial";
            this.Load += new System.EventHandler(this.MenuInicial_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btCadUni;
        private System.Windows.Forms.Button btCadAgente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btAgenda;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem configuraçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redefinirSenhaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redefinirSenhaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entrarComOutraContaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}