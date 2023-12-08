namespace Bullet_Email_Sender
{
    partial class addLetter
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
            this.lbLetter = new System.Windows.Forms.Label();
            this.tbAttachLocation = new System.Windows.Forms.TextBox();
            this.tbLetterName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.rtLetterBody = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSpam = new MaterialSkin.Controls.MaterialButton();
            this.btnClear = new MaterialSkin.Controls.MaterialButton();
            this.btnAdd = new MaterialSkin.Controls.MaterialButton();
            this.btnBrowse = new MaterialSkin.Controls.MaterialButton();
            this.btnRest = new MaterialSkin.Controls.MaterialButton();
            this.materialCard1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbLetter
            // 
            this.lbLetter.AutoSize = true;
            this.lbLetter.BackColor = System.Drawing.Color.Transparent;
            this.lbLetter.Font = new System.Drawing.Font("Dubai", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLetter.Location = new System.Drawing.Point(37, 58);
            this.lbLetter.Name = "lbLetter";
            this.lbLetter.Size = new System.Drawing.Size(90, 45);
            this.lbLetter.TabIndex = 35;
            this.lbLetter.Text = "Letter";
            // 
            // tbAttachLocation
            // 
            this.tbAttachLocation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbAttachLocation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbAttachLocation.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAttachLocation.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.tbAttachLocation.Location = new System.Drawing.Point(24, 131);
            this.tbAttachLocation.Name = "tbAttachLocation";
            this.tbAttachLocation.Size = new System.Drawing.Size(348, 29);
            this.tbAttachLocation.TabIndex = 42;
            // 
            // tbLetterName
            // 
            this.tbLetterName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbLetterName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbLetterName.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLetterName.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.tbLetterName.Location = new System.Drawing.Point(22, 44);
            this.tbLetterName.Name = "tbLetterName";
            this.tbLetterName.Size = new System.Drawing.Size(348, 29);
            this.tbLetterName.TabIndex = 37;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(17, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 27);
            this.label6.TabIndex = 36;
            this.label6.Text = "Letter Title:";
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.btnBrowse);
            this.materialCard1.Controls.Add(this.btnRest);
            this.materialCard1.Controls.Add(this.label1);
            this.materialCard1.Controls.Add(this.tbAttachLocation);
            this.materialCard1.Controls.Add(this.label6);
            this.materialCard1.Controls.Add(this.tbLetterName);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(492, 104);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(389, 258);
            this.materialCard1.TabIndex = 43;
            // 
            // rtLetterBody
            // 
            this.rtLetterBody.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.rtLetterBody.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtLetterBody.Depth = 0;
            this.rtLetterBody.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.rtLetterBody.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rtLetterBody.Location = new System.Drawing.Point(45, 104);
            this.rtLetterBody.MouseState = MaterialSkin.MouseState.HOVER;
            this.rtLetterBody.Name = "rtLetterBody";
            this.rtLetterBody.Size = new System.Drawing.Size(430, 502);
            this.rtLetterBody.TabIndex = 32;
            this.rtLetterBody.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(17, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 27);
            this.label1.TabIndex = 43;
            this.label1.Text = "Attachment:";
            // 
            // btnSpam
            // 
            this.btnSpam.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSpam.AutoSize = false;
            this.btnSpam.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSpam.BackColor = System.Drawing.SystemColors.Control;
            this.btnSpam.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSpam.Depth = 0;
            this.btnSpam.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpam.HighEmphasis = true;
            this.btnSpam.Icon = null;
            this.btnSpam.Location = new System.Drawing.Point(45, 618);
            this.btnSpam.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSpam.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSpam.Name = "btnSpam";
            this.btnSpam.Size = new System.Drawing.Size(120, 35);
            this.btnSpam.TabIndex = 44;
            this.btnSpam.Text = "Check Spam";
            this.btnSpam.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSpam.UseAccentColor = false;
            this.btnSpam.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnClear.AutoSize = false;
            this.btnClear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnClear.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnClear.Depth = 0;
            this.btnClear.HighEmphasis = true;
            this.btnClear.Icon = null;
            this.btnClear.Location = new System.Drawing.Point(173, 618);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnClear.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(120, 35);
            this.btnClear.TabIndex = 45;
            this.btnClear.Text = "Clear";
            this.btnClear.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnClear.UseAccentColor = true;
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAdd.AutoSize = false;
            this.btnAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAdd.BackColor = System.Drawing.SystemColors.Control;
            this.btnAdd.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAdd.Depth = 0;
            this.btnAdd.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.HighEmphasis = true;
            this.btnAdd.Icon = null;
            this.btnAdd.Location = new System.Drawing.Point(355, 618);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAdd.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(120, 35);
            this.btnAdd.TabIndex = 46;
            this.btnAdd.Text = "Add";
            this.btnAdd.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAdd.UseAccentColor = false;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBrowse.AutoSize = false;
            this.btnBrowse.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBrowse.BackColor = System.Drawing.SystemColors.Control;
            this.btnBrowse.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnBrowse.Depth = 0;
            this.btnBrowse.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowse.HighEmphasis = true;
            this.btnBrowse.Icon = null;
            this.btnBrowse.Location = new System.Drawing.Point(251, 177);
            this.btnBrowse.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnBrowse.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(120, 35);
            this.btnBrowse.TabIndex = 48;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnBrowse.UseAccentColor = false;
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnRest
            // 
            this.btnRest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRest.AutoSize = false;
            this.btnRest.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRest.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnRest.Depth = 0;
            this.btnRest.HighEmphasis = true;
            this.btnRest.Icon = null;
            this.btnRest.Location = new System.Drawing.Point(123, 177);
            this.btnRest.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnRest.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRest.Name = "btnRest";
            this.btnRest.Size = new System.Drawing.Size(120, 35);
            this.btnRest.TabIndex = 47;
            this.btnRest.Text = "Reset";
            this.btnRest.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnRest.UseAccentColor = true;
            this.btnRest.UseVisualStyleBackColor = true;
            this.btnRest.Click += new System.EventHandler(this.btnRest_Click);
            // 
            // addLetter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 669);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnSpam);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.rtLetterBody);
            this.Controls.Add(this.materialCard1);
            this.Controls.Add(this.lbLetter);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_None;
            this.Name = "addLetter";
            this.Padding = new System.Windows.Forms.Padding(3, 24, 3, 3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "addLetter";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.addLetter_FormClosed);
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbLetter;
        private System.Windows.Forms.TextBox tbAttachLocation;
        private System.Windows.Forms.TextBox tbLetterName;
        private System.Windows.Forms.Label label6;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialMultiLineTextBox rtLetterBody;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialButton btnSpam;
        private MaterialSkin.Controls.MaterialButton btnClear;
        private MaterialSkin.Controls.MaterialButton btnAdd;
        private MaterialSkin.Controls.MaterialButton btnBrowse;
        private MaterialSkin.Controls.MaterialButton btnRest;
    }
}