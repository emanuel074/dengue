namespace controledengue.Code.View
{
    partial class menu
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
            this.SuspendLayout();
            // 
            // btCadUni
            // 
            this.btCadUni.Location = new System.Drawing.Point(217, 207);
            this.btCadUni.Name = "btCadUni";
            this.btCadUni.Size = new System.Drawing.Size(367, 34);
            this.btCadUni.TabIndex = 7;
            this.btCadUni.Text = "Cadastro de unidades ";
            this.btCadUni.UseVisualStyleBackColor = true;
            this.btCadUni.Click += new System.EventHandler(this.btCadUni_Click);
            // 
            // btCadAgente
            // 
            this.btCadAgente.Location = new System.Drawing.Point(217, 146);
            this.btCadAgente.Name = "btCadAgente";
            this.btCadAgente.Size = new System.Drawing.Size(367, 34);
            this.btCadAgente.TabIndex = 8;
            this.btCadAgente.Text = "Cadastrar  agentes ";
            this.btCadAgente.UseVisualStyleBackColor = true;
            this.btCadAgente.Click += new System.EventHandler(this.btCadAgente_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 63.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(292, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 96);
            this.label1.TabIndex = 9;
            this.label1.Text = "A2Z";
            // 
            // btAgenda
            // 
            this.btAgenda.Location = new System.Drawing.Point(217, 265);
            this.btAgenda.Name = "btAgenda";
            this.btAgenda.Size = new System.Drawing.Size(367, 34);
            this.btAgenda.TabIndex = 10;
            this.btAgenda.Text = "Agendamentos";
            this.btAgenda.UseVisualStyleBackColor = true;
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 335);
            this.Controls.Add(this.btAgenda);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btCadAgente);
            this.Controls.Add(this.btCadUni);
            this.Name = "menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btCadUni;
        private System.Windows.Forms.Button btCadAgente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btAgenda;
    }
}