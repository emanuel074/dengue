namespace controledengue.Code.View
{
    partial class A2Z
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(A2Z));
            this.panel1 = new System.Windows.Forms.Panel();
            this.BarraProgressoA2Z = new System.Windows.Forms.ProgressBar();
            this.TelaA2Z = new System.Windows.Forms.PictureBox();
            this.TempoBarraProgresso = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TelaA2Z)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BarraProgressoA2Z);
            this.panel1.Controls.Add(this.TelaA2Z);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(912, 533);
            this.panel1.TabIndex = 0;
            // 
            // BarraProgressoA2Z
            // 
            this.BarraProgressoA2Z.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BarraProgressoA2Z.Location = new System.Drawing.Point(177, 306);
            this.BarraProgressoA2Z.Name = "BarraProgressoA2Z";
            this.BarraProgressoA2Z.Size = new System.Drawing.Size(401, 23);
            this.BarraProgressoA2Z.TabIndex = 1;
            this.BarraProgressoA2Z.Visible = false;
            // 
            // TelaA2Z
            // 
            this.TelaA2Z.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TelaA2Z.Image = ((System.Drawing.Image)(resources.GetObject("TelaA2Z.Image")));
            this.TelaA2Z.Location = new System.Drawing.Point(0, 0);
            this.TelaA2Z.Name = "TelaA2Z";
            this.TelaA2Z.Size = new System.Drawing.Size(912, 533);
            this.TelaA2Z.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.TelaA2Z.TabIndex = 0;
            this.TelaA2Z.TabStop = false;
            this.TelaA2Z.Click += new System.EventHandler(this.TelaA2Z_Click);
            // 
            // TempoBarraProgresso
            // 
            this.TempoBarraProgresso.Enabled = true;
            this.TempoBarraProgresso.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // A2Z
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 533);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "A2Z";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "A2Z";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TelaA2Z)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox TelaA2Z;
        private System.Windows.Forms.ProgressBar BarraProgressoA2Z;
        private System.Windows.Forms.Timer TempoBarraProgresso;
    }
}