namespace Bullet_Email_Sender
{
    partial class addMailRecepient
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
            this.rtEmails = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.rtTotalEmails = new System.Windows.Forms.RichTextBox();
            this.btnImport = new MaterialSkin.Controls.MaterialButton();
            this.btnAdd = new MaterialSkin.Controls.MaterialButton();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.materialCard1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Dubai", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 45);
            this.label1.TabIndex = 34;
            this.label1.Text = "Add One Email Per Line";
            // 
            // rtEmails
            // 
            this.rtEmails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.rtEmails.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtEmails.Depth = 0;
            this.rtEmails.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.rtEmails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rtEmails.Location = new System.Drawing.Point(5, 5);
            this.rtEmails.MouseState = MaterialSkin.MouseState.HOVER;
            this.rtEmails.Name = "rtEmails";
            this.rtEmails.Size = new System.Drawing.Size(695, 290);
            this.rtEmails.TabIndex = 35;
            this.rtEmails.Text = "";
            this.rtEmails.TextChanged += new System.EventHandler(this.rtEmails_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(43, 427);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 22);
            this.label9.TabIndex = 36;
            this.label9.Text = "Total Emails :";
            // 
            // rtTotalEmails
            // 
            this.rtTotalEmails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rtTotalEmails.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtTotalEmails.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtTotalEmails.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.rtTotalEmails.Location = new System.Drawing.Point(133, 426);
            this.rtTotalEmails.Multiline = false;
            this.rtTotalEmails.Name = "rtTotalEmails";
            this.rtTotalEmails.ReadOnly = true;
            this.rtTotalEmails.Size = new System.Drawing.Size(103, 27);
            this.rtTotalEmails.TabIndex = 38;
            this.rtTotalEmails.Text = "0";
            this.rtTotalEmails.TextChanged += new System.EventHandler(this.rtTotalEmails_TextChanged);
            // 
            // btnImport
            // 
            this.btnImport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnImport.AutoSize = false;
            this.btnImport.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnImport.BackColor = System.Drawing.SystemColors.Control;
            this.btnImport.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnImport.Depth = 0;
            this.btnImport.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImport.HighEmphasis = true;
            this.btnImport.Icon = null;
            this.btnImport.Location = new System.Drawing.Point(406, 419);
            this.btnImport.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnImport.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(168, 36);
            this.btnImport.TabIndex = 39;
            this.btnImport.Text = "Import";
            this.btnImport.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnImport.UseAccentColor = false;
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAdd.AutoSize = false;
            this.btnAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAdd.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAdd.Depth = 0;
            this.btnAdd.HighEmphasis = true;
            this.btnAdd.Icon = null;
            this.btnAdd.Location = new System.Drawing.Point(582, 419);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAdd.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(168, 36);
            this.btnAdd.TabIndex = 40;
            this.btnAdd.Text = "Add";
            this.btnAdd.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAdd.UseAccentColor = true;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.rtEmails);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(45, 102);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(708, 300);
            this.materialCard1.TabIndex = 34;
            // 
            // addMailRecepient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.materialCard1);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.rtTotalEmails);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label1);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_None;
            this.Name = "addMailRecepient";
            this.Padding = new System.Windows.Forms.Padding(3, 24, 3, 3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "addMailRecepient";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.addMailRecepient_FormClosed);
            this.materialCard1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialMultiLineTextBox rtEmails;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RichTextBox rtTotalEmails;
        private MaterialSkin.Controls.MaterialButton btnImport;
        private MaterialSkin.Controls.MaterialButton btnAdd;
        private MaterialSkin.Controls.MaterialCard materialCard1;
    }
}