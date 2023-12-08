namespace Bullet_Email_Sender
{
    partial class addProxy
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
            this.label1 = new System.Windows.Forms.Label();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.btnAddProxy = new MaterialSkin.Controls.MaterialButton();
            this.label7 = new System.Windows.Forms.Label();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbUser = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbPort = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbHost = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbType = new System.Windows.Forms.ComboBox();
            this.materialCard1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Dubai", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 45);
            this.label1.TabIndex = 35;
            this.label1.Text = "Add Proxy";
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.tbType);
            this.materialCard1.Controls.Add(this.label7);
            this.materialCard1.Controls.Add(this.tbPass);
            this.materialCard1.Controls.Add(this.label5);
            this.materialCard1.Controls.Add(this.tbUser);
            this.materialCard1.Controls.Add(this.label4);
            this.materialCard1.Controls.Add(this.tbPort);
            this.materialCard1.Controls.Add(this.label2);
            this.materialCard1.Controls.Add(this.tbHost);
            this.materialCard1.Controls.Add(this.label6);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(43, 95);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(458, 274);
            this.materialCard1.TabIndex = 36;
            // 
            // btnAddProxy
            // 
            this.btnAddProxy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddProxy.AutoSize = false;
            this.btnAddProxy.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAddProxy.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAddProxy.Depth = 0;
            this.btnAddProxy.HighEmphasis = true;
            this.btnAddProxy.Icon = null;
            this.btnAddProxy.Location = new System.Drawing.Point(335, 390);
            this.btnAddProxy.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAddProxy.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAddProxy.Name = "btnAddProxy";
            this.btnAddProxy.Size = new System.Drawing.Size(168, 36);
            this.btnAddProxy.TabIndex = 41;
            this.btnAddProxy.Text = "Add Proxy";
            this.btnAddProxy.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAddProxy.UseAccentColor = true;
            this.btnAddProxy.UseVisualStyleBackColor = true;
            this.btnAddProxy.Click += new System.EventHandler(this.btnAddProxy_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(30, 222);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 27);
            this.label7.TabIndex = 61;
            this.label7.Text = "Type:";
            // 
            // tbPass
            // 
            this.tbPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbPass.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPass.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.tbPass.Location = new System.Drawing.Point(162, 169);
            this.tbPass.Name = "tbPass";
            this.tbPass.Size = new System.Drawing.Size(221, 29);
            this.tbPass.TabIndex = 56;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(30, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 27);
            this.label5.TabIndex = 60;
            this.label5.Text = "Password:";
            // 
            // tbUser
            // 
            this.tbUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbUser.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUser.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.tbUser.Location = new System.Drawing.Point(162, 118);
            this.tbUser.Name = "tbUser";
            this.tbUser.Size = new System.Drawing.Size(221, 29);
            this.tbUser.TabIndex = 55;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(30, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 27);
            this.label4.TabIndex = 59;
            this.label4.Text = "Username:";
            // 
            // tbPort
            // 
            this.tbPort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbPort.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbPort.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPort.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.tbPort.Location = new System.Drawing.Point(162, 69);
            this.tbPort.Name = "tbPort";
            this.tbPort.Size = new System.Drawing.Size(221, 29);
            this.tbPort.TabIndex = 54;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(30, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 27);
            this.label2.TabIndex = 58;
            this.label2.Text = "Port:";
            // 
            // tbHost
            // 
            this.tbHost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbHost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbHost.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbHost.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.tbHost.Location = new System.Drawing.Point(162, 20);
            this.tbHost.Name = "tbHost";
            this.tbHost.Size = new System.Drawing.Size(221, 29);
            this.tbHost.TabIndex = 53;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(30, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 27);
            this.label6.TabIndex = 52;
            this.label6.Text = "Host:";
            // 
            // tbType
            // 
            this.tbType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tbType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tbType.Font = new System.Drawing.Font("Dubai", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbType.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.tbType.FormattingEnabled = true;
            this.tbType.Items.AddRange(new object[] {
            "Http",
            "Sock4",
            "Sock5"});
            this.tbType.Location = new System.Drawing.Point(162, 219);
            this.tbType.Name = "tbType";
            this.tbType.Size = new System.Drawing.Size(221, 26);
            this.tbType.TabIndex = 62;
            // 
            // addProxy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 450);
            this.Controls.Add(this.btnAddProxy);
            this.Controls.Add(this.materialCard1);
            this.Controls.Add(this.label1);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_None;
            this.Name = "addProxy";
            this.Padding = new System.Windows.Forms.Padding(3, 24, 3, 3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "addProxy";
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialButton btnAddProxy;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbPass;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbUser;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbPort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbHost;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox tbType;
    }
}