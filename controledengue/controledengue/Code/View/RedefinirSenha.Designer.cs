namespace controledengue.Code.View
{
    partial class RedefinirSenha
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
            this.btVoltar = new System.Windows.Forms.Button();
            this.btSalvar = new System.Windows.Forms.Button();
            this.tbConfirmarSenha = new System.Windows.Forms.TextBox();
            this.tbNovaSenha = new System.Windows.Forms.TextBox();
            this.tbSenha = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btVoltar
            // 
            this.btVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btVoltar.Location = new System.Drawing.Point(30, 359);
            this.btVoltar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btVoltar.Name = "btVoltar";
            this.btVoltar.Size = new System.Drawing.Size(115, 33);
            this.btVoltar.TabIndex = 21;
            this.btVoltar.Text = "Voltar";
            this.btVoltar.UseVisualStyleBackColor = true;
            this.btVoltar.Click += new System.EventHandler(this.btVoltar_Click);
            // 
            // btSalvar
            // 
            this.btSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSalvar.Location = new System.Drawing.Point(305, 359);
            this.btSalvar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(115, 33);
            this.btSalvar.TabIndex = 20;
            this.btSalvar.Text = "Salvar";
            this.btSalvar.UseVisualStyleBackColor = true;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // tbConfirmarSenha
            // 
            this.tbConfirmarSenha.Location = new System.Drawing.Point(30, 270);
            this.tbConfirmarSenha.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbConfirmarSenha.Name = "tbConfirmarSenha";
            this.tbConfirmarSenha.Size = new System.Drawing.Size(222, 23);
            this.tbConfirmarSenha.TabIndex = 19;
            this.tbConfirmarSenha.UseSystemPasswordChar = true;
            this.tbConfirmarSenha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbConfirmarSenha_KeyPress);
            // 
            // tbNovaSenha
            // 
            this.tbNovaSenha.Location = new System.Drawing.Point(30, 197);
            this.tbNovaSenha.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbNovaSenha.Name = "tbNovaSenha";
            this.tbNovaSenha.Size = new System.Drawing.Size(222, 23);
            this.tbNovaSenha.TabIndex = 18;
            this.tbNovaSenha.UseSystemPasswordChar = true;
            this.tbNovaSenha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNovaSenha_KeyPress);
            // 
            // tbSenha
            // 
            this.tbSenha.Location = new System.Drawing.Point(30, 125);
            this.tbSenha.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbSenha.Name = "tbSenha";
            this.tbSenha.Size = new System.Drawing.Size(222, 23);
            this.tbSenha.TabIndex = 17;
            this.tbSenha.UseSystemPasswordChar = true;
            this.tbSenha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSenha_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "Confirmar nova senha";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Nova senha";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Senha atual";
            // 
            // RedefinirSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 418);
            this.Controls.Add(this.btVoltar);
            this.Controls.Add(this.btSalvar);
            this.Controls.Add(this.tbConfirmarSenha);
            this.Controls.Add(this.tbNovaSenha);
            this.Controls.Add(this.tbSenha);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "RedefinirSenha";
            this.Padding = new System.Windows.Forms.Padding(23, 79, 23, 27);
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Redefinir Senha";
            this.Load += new System.EventHandler(this.RedefinirSenha_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btVoltar;
        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.TextBox tbConfirmarSenha;
        private System.Windows.Forms.TextBox tbNovaSenha;
        private System.Windows.Forms.TextBox tbSenha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}