namespace controledengue.Code.View
{
    partial class CadastroLogin
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
            this.btCadastrar = new System.Windows.Forms.Button();
            this.lbConfirmarSenha = new System.Windows.Forms.Label();
            this.tbConfirmarSenha = new System.Windows.Forms.TextBox();
            this.lbSenha = new System.Windows.Forms.Label();
            this.tbSenha = new System.Windows.Forms.TextBox();
            this.lbUsuario = new System.Windows.Forms.Label();
            this.tbUsuario = new System.Windows.Forms.TextBox();
            this.linklbObs = new System.Windows.Forms.LinkLabel();
            this.pictureBox_Usu = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Usu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btVoltar
            // 
            this.btVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btVoltar.Location = new System.Drawing.Point(23, 312);
            this.btVoltar.Name = "btVoltar";
            this.btVoltar.Size = new System.Drawing.Size(99, 25);
            this.btVoltar.TabIndex = 20;
            this.btVoltar.Text = "Voltar";
            this.btVoltar.UseVisualStyleBackColor = true;
            this.btVoltar.Click += new System.EventHandler(this.btVoltar_Click);
            // 
            // btCadastrar
            // 
            this.btCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCadastrar.Location = new System.Drawing.Point(287, 312);
            this.btCadastrar.Name = "btCadastrar";
            this.btCadastrar.Size = new System.Drawing.Size(99, 25);
            this.btCadastrar.TabIndex = 19;
            this.btCadastrar.Text = "Cadastrar";
            this.btCadastrar.UseVisualStyleBackColor = true;
            this.btCadastrar.Click += new System.EventHandler(this.btCadastrar_Click);
            // 
            // lbConfirmarSenha
            // 
            this.lbConfirmarSenha.AutoSize = true;
            this.lbConfirmarSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbConfirmarSenha.Location = new System.Drawing.Point(58, 208);
            this.lbConfirmarSenha.Name = "lbConfirmarSenha";
            this.lbConfirmarSenha.Size = new System.Drawing.Size(122, 18);
            this.lbConfirmarSenha.TabIndex = 18;
            this.lbConfirmarSenha.Text = "Confirmar senha:";
            // 
            // tbConfirmarSenha
            // 
            this.tbConfirmarSenha.Location = new System.Drawing.Point(61, 229);
            this.tbConfirmarSenha.Name = "tbConfirmarSenha";
            this.tbConfirmarSenha.Size = new System.Drawing.Size(253, 20);
            this.tbConfirmarSenha.TabIndex = 17;
            this.tbConfirmarSenha.UseSystemPasswordChar = true;
            this.tbConfirmarSenha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbConfirmarSenha_KeyPress);
            // 
            // lbSenha
            // 
            this.lbSenha.AutoSize = true;
            this.lbSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSenha.Location = new System.Drawing.Point(58, 142);
            this.lbSenha.Name = "lbSenha";
            this.lbSenha.Size = new System.Drawing.Size(54, 18);
            this.lbSenha.TabIndex = 16;
            this.lbSenha.Text = "Senha:";
            // 
            // tbSenha
            // 
            this.tbSenha.Location = new System.Drawing.Point(61, 163);
            this.tbSenha.Name = "tbSenha";
            this.tbSenha.Size = new System.Drawing.Size(253, 20);
            this.tbSenha.TabIndex = 15;
            this.tbSenha.UseSystemPasswordChar = true;
            this.tbSenha.TextChanged += new System.EventHandler(this.tbSenha_TextChanged);
            this.tbSenha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSenha_KeyPress);
            // 
            // lbUsuario
            // 
            this.lbUsuario.AutoSize = true;
            this.lbUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsuario.Location = new System.Drawing.Point(58, 88);
            this.lbUsuario.Name = "lbUsuario";
            this.lbUsuario.Size = new System.Drawing.Size(64, 18);
            this.lbUsuario.TabIndex = 14;
            this.lbUsuario.Text = "Usuário:";
            // 
            // tbUsuario
            // 
            this.tbUsuario.Location = new System.Drawing.Point(61, 109);
            this.tbUsuario.Name = "tbUsuario";
            this.tbUsuario.Size = new System.Drawing.Size(253, 20);
            this.tbUsuario.TabIndex = 13;
            this.tbUsuario.TextChanged += new System.EventHandler(this.tbUsuario_TextChanged);
            // 
            // linklbObs
            // 
            this.linklbObs.AutoSize = true;
            this.linklbObs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linklbObs.LinkColor = System.Drawing.Color.Gray;
            this.linklbObs.Location = new System.Drawing.Point(61, 252);
            this.linklbObs.Name = "linklbObs";
            this.linklbObs.Size = new System.Drawing.Size(191, 16);
            this.linklbObs.TabIndex = 23;
            this.linklbObs.TabStop = true;
            this.linklbObs.Text = "OBS: Senha somente números";
            // 
            // pictureBox_Usu
            // 
            this.pictureBox_Usu.BackgroundImage = global::controledengue.Properties.Resources.Password_32;
            this.pictureBox_Usu.Location = new System.Drawing.Point(8, 153);
            this.pictureBox_Usu.Name = "pictureBox_Usu";
            this.pictureBox_Usu.Size = new System.Drawing.Size(35, 30);
            this.pictureBox_Usu.TabIndex = 24;
            this.pictureBox_Usu.TabStop = false;
            this.pictureBox_Usu.Click += new System.EventHandler(this.pictureBox_Usu_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::controledengue.Properties.Resources.Contacts_32;
            this.pictureBox1.Location = new System.Drawing.Point(8, 99);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 30);
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // CadastroLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 360);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox_Usu);
            this.Controls.Add(this.linklbObs);
            this.Controls.Add(this.btVoltar);
            this.Controls.Add(this.btCadastrar);
            this.Controls.Add(this.lbConfirmarSenha);
            this.Controls.Add(this.tbConfirmarSenha);
            this.Controls.Add(this.lbSenha);
            this.Controls.Add(this.tbSenha);
            this.Controls.Add(this.lbUsuario);
            this.Controls.Add(this.tbUsuario);
            this.MaximizeBox = false;
            this.Name = "CadastroLogin";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Style = MetroFramework.MetroColorStyle.Lime;
            this.Text = "Cadastro de Usuários";
            this.Load += new System.EventHandler(this.CadastroLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Usu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btVoltar;
        private System.Windows.Forms.Button btCadastrar;
        private System.Windows.Forms.Label lbConfirmarSenha;
        private System.Windows.Forms.TextBox tbConfirmarSenha;
        private System.Windows.Forms.Label lbSenha;
        private System.Windows.Forms.TextBox tbSenha;
        private System.Windows.Forms.Label lbUsuario;
        private System.Windows.Forms.TextBox tbUsuario;
        private System.Windows.Forms.LinkLabel linklbObs;
        private System.Windows.Forms.PictureBox pictureBox_Usu;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}