﻿namespace controledengue.Code.View
{
    partial class CadastrarUnidade
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
            this.cadastro = new System.Windows.Forms.TabControl();
            this.tpCadastro = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbMunici = new System.Windows.Forms.MaskedTextBox();
            this.btAlterar = new System.Windows.Forms.Button();
            this.txtCep = new System.Windows.Forms.MaskedTextBox();
            this.mkdCnpj = new System.Windows.Forms.MaskedTextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.MaskedTextBox();
            this.cbUf = new System.Windows.Forms.ComboBox();
            this.txtTel = new System.Windows.Forms.MaskedTextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCodigoUf = new System.Windows.Forms.TextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label27 = new System.Windows.Forms.Label();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.gridUnidade = new System.Windows.Forms.DataGridView();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.cadastro.SuspendLayout();
            this.tpCadastro.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridUnidade)).BeginInit();
            this.SuspendLayout();
            // 
            // cadastro
            // 
            this.cadastro.Controls.Add(this.tpCadastro);
            this.cadastro.Controls.Add(this.tabPage1);
            this.cadastro.Location = new System.Drawing.Point(12, 12);
            this.cadastro.Name = "cadastro";
            this.cadastro.SelectedIndex = 0;
            this.cadastro.Size = new System.Drawing.Size(876, 472);
            this.cadastro.TabIndex = 4;
            // 
            // tpCadastro
            // 
            this.tpCadastro.Controls.Add(this.panel2);
            this.tpCadastro.Controls.Add(this.panel1);
            this.tpCadastro.Controls.Add(this.cbMunici);
            this.tpCadastro.Controls.Add(this.btAlterar);
            this.tpCadastro.Controls.Add(this.txtCep);
            this.tpCadastro.Controls.Add(this.mkdCnpj);
            this.tpCadastro.Controls.Add(this.txtNumero);
            this.tpCadastro.Controls.Add(this.label13);
            this.tpCadastro.Controls.Add(this.label11);
            this.tpCadastro.Controls.Add(this.txtBairro);
            this.tpCadastro.Controls.Add(this.cbUf);
            this.tpCadastro.Controls.Add(this.txtTel);
            this.tpCadastro.Controls.Add(this.txtId);
            this.tpCadastro.Controls.Add(this.label5);
            this.tpCadastro.Controls.Add(this.btnSair);
            this.tpCadastro.Controls.Add(this.btnSalvar);
            this.tpCadastro.Controls.Add(this.btnLimpar);
            this.tpCadastro.Controls.Add(this.label10);
            this.tpCadastro.Controls.Add(this.label9);
            this.tpCadastro.Controls.Add(this.label8);
            this.tpCadastro.Controls.Add(this.txtEmail);
            this.tpCadastro.Controls.Add(this.label12);
            this.tpCadastro.Controls.Add(this.label7);
            this.tpCadastro.Controls.Add(this.label6);
            this.tpCadastro.Controls.Add(this.txtEndereco);
            this.tpCadastro.Controls.Add(this.label2);
            this.tpCadastro.Controls.Add(this.txtNome);
            this.tpCadastro.Controls.Add(this.label4);
            this.tpCadastro.Controls.Add(this.label1);
            this.tpCadastro.Controls.Add(this.label3);
            this.tpCadastro.Controls.Add(this.txtCodigoUf);
            this.tpCadastro.Location = new System.Drawing.Point(4, 22);
            this.tpCadastro.Name = "tpCadastro";
            this.tpCadastro.Padding = new System.Windows.Forms.Padding(3);
            this.tpCadastro.Size = new System.Drawing.Size(868, 446);
            this.tpCadastro.TabIndex = 0;
            this.tpCadastro.Text = "Cadastro";
            this.tpCadastro.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightCoral;
            this.panel2.Location = new System.Drawing.Point(46, 281);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(769, 23);
            this.panel2.TabIndex = 32782;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightCoral;
            this.panel1.Location = new System.Drawing.Point(41, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(788, 23);
            this.panel1.TabIndex = 32781;
            // 
            // cbMunici
            // 
            this.cbMunici.Location = new System.Drawing.Point(483, 161);
            this.cbMunici.Name = "cbMunici";
            this.cbMunici.Size = new System.Drawing.Size(136, 20);
            this.cbMunici.TabIndex = 32780;
            this.cbMunici.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbMunici_KeyPress);
            // 
            // btAlterar
            // 
            this.btAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAlterar.Location = new System.Drawing.Point(611, 323);
            this.btAlterar.Name = "btAlterar";
            this.btAlterar.Size = new System.Drawing.Size(99, 25);
            this.btAlterar.TabIndex = 32779;
            this.btAlterar.Text = "Alterar ";
            this.btAlterar.UseVisualStyleBackColor = true;
            this.btAlterar.Click += new System.EventHandler(this.btAlterar_Click);
            // 
            // txtCep
            // 
            this.txtCep.Location = new System.Drawing.Point(130, 203);
            this.txtCep.Mask = "000-00-000";
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(64, 20);
            this.txtCep.TabIndex = 32778;
            // 
            // mkdCnpj
            // 
            this.mkdCnpj.Location = new System.Drawing.Point(483, 77);
            this.mkdCnpj.Mask = "00.000.000/0000-00";
            this.mkdCnpj.Name = "mkdCnpj";
            this.mkdCnpj.Size = new System.Drawing.Size(136, 20);
            this.mkdCnpj.TabIndex = 32777;
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(303, 161);
            this.txtNumero.MaxLength = 5;
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(41, 20);
            this.txtNumero.TabIndex = 32776;
            this.txtNumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumero_KeyPress);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(247, 164);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(50, 13);
            this.label13.TabIndex = 32775;
            this.label13.Text = "Número :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(43, 164);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 13);
            this.label11.TabIndex = 32773;
            this.label11.Text = "Bairro :";
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(130, 161);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(111, 20);
            this.txtBairro.TabIndex = 32772;
            this.txtBairro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBairro_KeyPress);
            // 
            // cbUf
            // 
            this.cbUf.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbUf.FormattingEnabled = true;
            this.cbUf.Items.AddRange(new object[] {
            "AC ",
            "AL ",
            "AP ",
            "AM ",
            "BA ",
            "CE ",
            "DF ",
            "ES ",
            "GO ",
            "MA ",
            "MT ",
            "MS ",
            "MG ",
            "PA ",
            "PB ",
            "PR ",
            "PE ",
            "PI ",
            "RJ ",
            "RN",
            "RS ",
            "RO ",
            "RR ",
            "SC ",
            "SP ",
            "SE ",
            "TO"});
            this.cbUf.Location = new System.Drawing.Point(483, 118);
            this.cbUf.Name = "cbUf";
            this.cbUf.Size = new System.Drawing.Size(136, 21);
            this.cbUf.TabIndex = 32770;
            this.cbUf.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbUf_KeyPress);
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(483, 245);
            this.txtTel.Mask = "(99) 0000-0000";
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(83, 20);
            this.txtTel.TabIndex = 79;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(78, 15);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(40, 20);
            this.txtId.TabIndex = 77;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 13);
            this.label5.TabIndex = 76;
            this.label5.Text = "ID:";
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(41, 323);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(99, 25);
            this.btnSair.TabIndex = 72;
            this.btnSair.Text = "Voltar";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(716, 323);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(99, 25);
            this.btnSalvar.TabIndex = 0;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(506, 323);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(99, 25);
            this.btnLimpar.TabIndex = 1;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(411, 248);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 13);
            this.label10.TabIndex = 35;
            this.label10.Text = "Telefone : ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(411, 206);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 13);
            this.label9.TabIndex = 34;
            this.label9.Text = "E-mail :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(43, 206);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 33;
            this.label8.Text = "CEP :";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(483, 203);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(197, 20);
            this.txtEmail.TabIndex = 32;
            this.txtEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEmail_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(411, 164);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 13);
            this.label12.TabIndex = 29;
            this.label12.Text = "Município :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(411, 121);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "UF :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Endereço  :";
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(130, 118);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(193, 20);
            this.txtEndereco.TabIndex = 21;
            this.txtEndereco.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEndereco_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Nome Fantasia :";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(133, 77);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(193, 20);
            this.txtNome.TabIndex = 10;
            this.txtNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNome_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Código da UF :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(411, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "CNPJ/CEI  :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 8;
            // 
            // txtCodigoUf
            // 
            this.txtCodigoUf.Location = new System.Drawing.Point(130, 245);
            this.txtCodigoUf.MaxLength = 3;
            this.txtCodigoUf.Name = "txtCodigoUf";
            this.txtCodigoUf.Size = new System.Drawing.Size(64, 20);
            this.txtCodigoUf.TabIndex = 5;
            this.txtCodigoUf.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigoUf_KeyPress);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.linkLabel1);
            this.tabPage1.Controls.Add(this.label27);
            this.tabPage1.Controls.Add(this.btnExcluir);
            this.tabPage1.Controls.Add(this.btnNovo);
            this.tabPage1.Controls.Add(this.gridUnidade);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(868, 446);
            this.tabPage1.TabIndex = 1;
            this.tabPage1.Text = "Controle";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.ForeColor = System.Drawing.Color.Red;
            this.label27.Location = new System.Drawing.Point(266, 41);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(368, 31);
            this.label27.TabIndex = 18;
            this.label27.Text = "UNIDADES CADASTRADAS";
            // 
            // btnExcluir
            // 
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Location = new System.Drawing.Point(3, 99);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(99, 25);
            this.btnExcluir.TabIndex = 17;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.Location = new System.Drawing.Point(3, 130);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(99, 25);
            this.btnNovo.TabIndex = 16;
            this.btnNovo.Text = "Voltar";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // gridUnidade
            // 
            this.gridUnidade.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridUnidade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridUnidade.Location = new System.Drawing.Point(105, 99);
            this.gridUnidade.Name = "gridUnidade";
            this.gridUnidade.ReadOnly = true;
            this.gridUnidade.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridUnidade.Size = new System.Drawing.Size(746, 322);
            this.gridUnidade.TabIndex = 15;
            this.gridUnidade.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridUnidade_CellContentClick);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.Red;
            this.linkLabel1.Location = new System.Drawing.Point(610, 3);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(252, 16);
            this.linkLabel1.TabIndex = 34;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "OBS.: Para apagar, selecione a Unidade";
            // 
            // CadastrarUnidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 496);
            this.Controls.Add(this.cadastro);
            this.MaximizeBox = false;
            this.Name = "CadastrarUnidade";
            this.Load += new System.EventHandler(this.CadastrarUnidade_Load);
            this.cadastro.ResumeLayout(false);
            this.tpCadastro.ResumeLayout(false);
            this.tpCadastro.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridUnidade)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl cadastro;
        private System.Windows.Forms.TabPage tpCadastro;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.MaskedTextBox txtBairro;
        private System.Windows.Forms.ComboBox cbUf;
        private System.Windows.Forms.MaskedTextBox txtTel;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCodigoUf;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.DataGridView gridUnidade;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.MaskedTextBox mkdCnpj;
        private System.Windows.Forms.MaskedTextBox txtCep;
        private System.Windows.Forms.Button btAlterar;
        private System.Windows.Forms.MaskedTextBox cbMunici;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}