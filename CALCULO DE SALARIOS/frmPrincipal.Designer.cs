namespace CALCULO_DE_SALARIOS
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.btnAcercaDe = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnCalcularS = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlVista = new System.Windows.Forms.Panel();
            this.pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(94)))), ((int)(((byte)(138)))));
            this.pnlTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitulo.Location = new System.Drawing.Point(0, 0);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Size = new System.Drawing.Size(977, 88);
            this.pnlTitulo.TabIndex = 0;
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(63)))), ((int)(((byte)(94)))));
            this.pnlMenu.Controls.Add(this.button3);
            this.pnlMenu.Controls.Add(this.btnAcercaDe);
            this.pnlMenu.Controls.Add(this.button1);
            this.pnlMenu.Controls.Add(this.btnCalcularS);
            this.pnlMenu.Controls.Add(this.pictureBox1);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 88);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(238, 653);
            this.pnlMenu.TabIndex = 1;
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.MediumPurple;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.Window;
            this.button3.Image = global::CALCULO_DE_SALARIOS.Properties.Resources.logout;
            this.button3.Location = new System.Drawing.Point(61, 537);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 3, 3, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(85, 100);
            this.button3.TabIndex = 4;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnAcercaDe
            // 
            this.btnAcercaDe.FlatAppearance.BorderColor = System.Drawing.Color.MediumPurple;
            this.btnAcercaDe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAcercaDe.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcercaDe.ForeColor = System.Drawing.SystemColors.Window;
            this.btnAcercaDe.Image = global::CALCULO_DE_SALARIOS.Properties.Resources.information;
            this.btnAcercaDe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAcercaDe.Location = new System.Drawing.Point(2, 350);
            this.btnAcercaDe.Margin = new System.Windows.Forms.Padding(2, 3, 3, 3);
            this.btnAcercaDe.Name = "btnAcercaDe";
            this.btnAcercaDe.Size = new System.Drawing.Size(227, 65);
            this.btnAcercaDe.TabIndex = 3;
            this.btnAcercaDe.Text = "ACERCA DE ...";
            this.btnAcercaDe.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAcercaDe.UseVisualStyleBackColor = true;
            this.btnAcercaDe.Click += new System.EventHandler(this.btnAcercaDe_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.MediumPurple;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Window;
            this.button1.Image = global::CALCULO_DE_SALARIOS.Properties.Resources.analytics;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(2, 266);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 3, 3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(227, 65);
            this.button1.TabIndex = 2;
            this.button1.Text = "VER EMPLEADOS";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCalcularS
            // 
            this.btnCalcularS.FlatAppearance.BorderColor = System.Drawing.Color.MediumPurple;
            this.btnCalcularS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcularS.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcularS.ForeColor = System.Drawing.SystemColors.Window;
            this.btnCalcularS.Image = ((System.Drawing.Image)(resources.GetObject("btnCalcularS.Image")));
            this.btnCalcularS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCalcularS.Location = new System.Drawing.Point(2, 185);
            this.btnCalcularS.Margin = new System.Windows.Forms.Padding(2, 3, 3, 3);
            this.btnCalcularS.Name = "btnCalcularS";
            this.btnCalcularS.Size = new System.Drawing.Size(227, 65);
            this.btnCalcularS.TabIndex = 1;
            this.btnCalcularS.Text = "CALCULAR SALARIO";
            this.btnCalcularS.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCalcularS.UseVisualStyleBackColor = true;
            this.btnCalcularS.Click += new System.EventHandler(this.btnCalcularS_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CALCULO_DE_SALARIOS.Properties.Resources.people;
            this.pictureBox1.Location = new System.Drawing.Point(29, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(162, 130);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pnlVista
            // 
            this.pnlVista.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlVista.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlVista.Location = new System.Drawing.Point(238, 88);
            this.pnlVista.Name = "pnlVista";
            this.pnlVista.Size = new System.Drawing.Size(739, 653);
            this.pnlVista.TabIndex = 2;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(977, 741);
            this.Controls.Add(this.pnlVista);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.pnlTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.HelpButton = true;
            this.Name = "frmPrincipal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.pnlMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel pnlVista;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCalcularS;
        private System.Windows.Forms.Button btnAcercaDe;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
    }
}