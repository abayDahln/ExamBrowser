namespace ExamBrowser
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TBLogin_pw = new System.Windows.Forms.TextBox();
            this.TBLogin_usn = new System.Windows.Forms.TextBox();
            this.btnLogin = new MaterialSkin.Controls.MaterialButton();
            this.btnKeluar = new MaterialSkin.Controls.MaterialButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnKeluar);
            this.panel1.Controls.Add(this.btnLogin);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.TBLogin_pw);
            this.panel1.Controls.Add(this.TBLogin_usn);
            this.panel1.Location = new System.Drawing.Point(731, 151);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(544, 791);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.Location = new System.Drawing.Point(195, 79);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(149, 149);
            this.panel4.TabIndex = 11;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel3.Location = new System.Drawing.Point(108, 468);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(38, 37);
            this.panel3.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(88, 264);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(391, 100);
            this.label2.TabIndex = 8;
            this.label2.Text = "Silahkan login menggunakan username dan password yang anda miliki";
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel2.Location = new System.Drawing.Point(108, 391);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(38, 37);
            this.panel2.TabIndex = 6;
            // 
            // TBLogin_pw
            // 
            this.TBLogin_pw.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.TBLogin_pw.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TBLogin_pw.Location = new System.Drawing.Point(152, 468);
            this.TBLogin_pw.Multiline = true;
            this.TBLogin_pw.Name = "TBLogin_pw";
            this.TBLogin_pw.PasswordChar = '*';
            this.TBLogin_pw.Size = new System.Drawing.Size(278, 38);
            this.TBLogin_pw.TabIndex = 5;
            this.TBLogin_pw.TextChanged += new System.EventHandler(this.TBLogin_pw_TextChanged);
            // 
            // TBLogin_usn
            // 
            this.TBLogin_usn.BackColor = System.Drawing.Color.White;
            this.TBLogin_usn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.TBLogin_usn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TBLogin_usn.Location = new System.Drawing.Point(152, 391);
            this.TBLogin_usn.Multiline = true;
            this.TBLogin_usn.Name = "TBLogin_usn";
            this.TBLogin_usn.Size = new System.Drawing.Size(278, 37);
            this.TBLogin_usn.TabIndex = 3;
            this.TBLogin_usn.TextChanged += new System.EventHandler(this.TBLogin_usn_TextChanged);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.White;
            this.btnLogin.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnLogin.Depth = 0;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.Transparent;
            this.btnLogin.HighEmphasis = true;
            this.btnLogin.Icon = null;
            this.btnLogin.Location = new System.Drawing.Point(343, 593);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnLogin.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnLogin.Size = new System.Drawing.Size(111, 48);
            this.btnLogin.TabIndex = 12;
            this.btnLogin.Text = "login";
            this.btnLogin.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnLogin.UseAccentColor = false;
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnKeluar
            // 
            this.btnKeluar.BackColor = System.Drawing.Color.White;
            this.btnKeluar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnKeluar.Depth = 0;
            this.btnKeluar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKeluar.ForeColor = System.Drawing.Color.Transparent;
            this.btnKeluar.HighEmphasis = true;
            this.btnKeluar.Icon = null;
            this.btnKeluar.Location = new System.Drawing.Point(68, 593);
            this.btnKeluar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnKeluar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnKeluar.Name = "btnKeluar";
            this.btnKeluar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnKeluar.Size = new System.Drawing.Size(111, 48);
            this.btnKeluar.TabIndex = 13;
            this.btnKeluar.Text = "keluar";
            this.btnKeluar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnKeluar.UseAccentColor = false;
            this.btnKeluar.UseVisualStyleBackColor = false;
            this.btnKeluar.Click += new System.EventHandler(this.btnKeluar_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1761, 964);
            this.Controls.Add(this.panel1);
            this.Name = "Login";
            this.Text = "Login";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TBLogin_pw;
        private System.Windows.Forms.TextBox TBLogin_usn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private MaterialSkin.Controls.MaterialButton btnLogin;
        private MaterialSkin.Controls.MaterialButton btnKeluar;
    }
}

