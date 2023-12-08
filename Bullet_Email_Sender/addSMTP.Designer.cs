namespace Bullet_Email_Sender
{
    partial class addSMTP
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
            this.label16 = new System.Windows.Forms.Label();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.tbToEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbSSL = new System.Windows.Forms.CheckBox();
            this.tbLimit = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbUser = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbPort = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbHost = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAddSMTP = new MaterialSkin.Controls.MaterialButton();
            this.btnTestSMTP = new MaterialSkin.Controls.MaterialButton();
            this.materialCard1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Dubai", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(37, 58);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(88, 45);
            this.label16.TabIndex = 36;
            this.label16.Text = "SMTP";
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.tbToEmail);
            this.materialCard1.Controls.Add(this.label2);
            this.materialCard1.Controls.Add(this.cbSSL);
            this.materialCard1.Controls.Add(this.tbLimit);
            this.materialCard1.Controls.Add(this.label7);
            this.materialCard1.Controls.Add(this.tbPass);
            this.materialCard1.Controls.Add(this.label5);
            this.materialCard1.Controls.Add(this.tbUser);
            this.materialCard1.Controls.Add(this.label4);
            this.materialCard1.Controls.Add(this.tbPort);
            this.materialCard1.Controls.Add(this.label1);
            this.materialCard1.Controls.Add(this.tbHost);
            this.materialCard1.Controls.Add(this.label6);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(42, 103);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(533, 346);
            this.materialCard1.TabIndex = 37;
            // 
            // tbToEmail
            // 
            this.tbToEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbToEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbToEmail.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbToEmail.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.tbToEmail.Location = new System.Drawing.Point(145, 298);
            this.tbToEmail.Name = "tbToEmail";
            this.tbToEmail.Size = new System.Drawing.Size(265, 29);
            this.tbToEmail.TabIndex = 44;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(33, 298);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 27);
            this.label2.TabIndex = 50;
            this.label2.Text = "To Email:";
            // 
            // cbSSL
            // 
            this.cbSSL.AutoSize = true;
            this.cbSSL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbSSL.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSSL.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cbSSL.Location = new System.Drawing.Point(435, 304);
            this.cbSSL.Name = "cbSSL";
            this.cbSSL.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbSSL.Size = new System.Drawing.Size(54, 31);
            this.cbSSL.TabIndex = 45;
            this.cbSSL.Text = "SSL";
            this.cbSSL.UseVisualStyleBackColor = true;
            // 
            // tbLimit
            // 
            this.tbLimit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbLimit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbLimit.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLimit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.tbLimit.Location = new System.Drawing.Point(145, 244);
            this.tbLimit.Name = "tbLimit";
            this.tbLimit.Size = new System.Drawing.Size(265, 29);
            this.tbLimit.TabIndex = 43;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(33, 244);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 27);
            this.label7.TabIndex = 48;
            this.label7.Text = "SMTP Limit:";
            // 
            // tbPass
            // 
            this.tbPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbPass.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPass.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.tbPass.Location = new System.Drawing.Point(145, 185);
            this.tbPass.Name = "tbPass";
            this.tbPass.PasswordChar = '*';
            this.tbPass.Size = new System.Drawing.Size(265, 29);
            this.tbPass.TabIndex = 42;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(36, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 27);
            this.label5.TabIndex = 47;
            this.label5.Text = "Password:";
            // 
            // tbUser
            // 
            this.tbUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbUser.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUser.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.tbUser.Location = new System.Drawing.Point(145, 127);
            this.tbUser.Name = "tbUser";
            this.tbUser.Size = new System.Drawing.Size(265, 29);
            this.tbUser.TabIndex = 41;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(36, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 27);
            this.label4.TabIndex = 46;
            this.label4.Text = "Username:";
            // 
            // tbPort
            // 
            this.tbPort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbPort.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbPort.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPort.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.tbPort.Location = new System.Drawing.Point(145, 71);
            this.tbPort.Name = "tbPort";
            this.tbPort.Size = new System.Drawing.Size(265, 29);
            this.tbPort.TabIndex = 40;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(36, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 27);
            this.label1.TabIndex = 44;
            this.label1.Text = "Port:";
            // 
            // tbHost
            // 
            this.tbHost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbHost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbHost.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbHost.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.tbHost.Location = new System.Drawing.Point(145, 17);
            this.tbHost.Name = "tbHost";
            this.tbHost.Size = new System.Drawing.Size(265, 29);
            this.tbHost.TabIndex = 39;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(33, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 27);
            this.label6.TabIndex = 38;
            this.label6.Text = "Host:";
            // 
            // btnAddSMTP
            // 
            this.btnAddSMTP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddSMTP.AutoSize = false;
            this.btnAddSMTP.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAddSMTP.BackColor = System.Drawing.SystemColors.Control;
            this.btnAddSMTP.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAddSMTP.Depth = 0;
            this.btnAddSMTP.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSMTP.HighEmphasis = true;
            this.btnAddSMTP.Icon = null;
            this.btnAddSMTP.Location = new System.Drawing.Point(458, 469);
            this.btnAddSMTP.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAddSMTP.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAddSMTP.Name = "btnAddSMTP";
            this.btnAddSMTP.Size = new System.Drawing.Size(120, 35);
            this.btnAddSMTP.TabIndex = 50;
            this.btnAddSMTP.Text = "Add SMTP";
            this.btnAddSMTP.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAddSMTP.UseAccentColor = false;
            this.btnAddSMTP.UseVisualStyleBackColor = true;
            this.btnAddSMTP.Click += new System.EventHandler(this.btnAddSMTP_Click);
            // 
            // btnTestSMTP
            // 
            this.btnTestSMTP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnTestSMTP.AutoSize = false;
            this.btnTestSMTP.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnTestSMTP.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnTestSMTP.Depth = 0;
            this.btnTestSMTP.HighEmphasis = true;
            this.btnTestSMTP.Icon = null;
            this.btnTestSMTP.Location = new System.Drawing.Point(330, 469);
            this.btnTestSMTP.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnTestSMTP.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnTestSMTP.Name = "btnTestSMTP";
            this.btnTestSMTP.Size = new System.Drawing.Size(120, 35);
            this.btnTestSMTP.TabIndex = 49;
            this.btnTestSMTP.Text = "Test SMTP";
            this.btnTestSMTP.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnTestSMTP.UseAccentColor = true;
            this.btnTestSMTP.UseVisualStyleBackColor = true;
            this.btnTestSMTP.Click += new System.EventHandler(this.btnTestSMTP_Click);
            // 
            // addSMTP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 524);
            this.Controls.Add(this.btnAddSMTP);
            this.Controls.Add(this.btnTestSMTP);
            this.Controls.Add(this.materialCard1);
            this.Controls.Add(this.label16);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_None;
            this.Name = "addSMTP";
            this.Padding = new System.Windows.Forms.Padding(3, 24, 3, 3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "addSMTP";
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label16;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialButton btnAddSMTP;
        private MaterialSkin.Controls.MaterialButton btnTestSMTP;
        private System.Windows.Forms.CheckBox cbSSL;
        private System.Windows.Forms.TextBox tbLimit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbPass;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbUser;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbHost;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbToEmail;
        private System.Windows.Forms.Label label2;
    }
}