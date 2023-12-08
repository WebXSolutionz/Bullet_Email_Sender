namespace Bullet_Email_Sender
{
    partial class addProductKey
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
            this.tbProductKey = new System.Windows.Forms.TextBox();
            this.btnAddKey = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Dubai", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(156, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 45);
            this.label1.TabIndex = 35;
            this.label1.Text = "Enter A Valid Product Key";
            // 
            // tbProductKey
            // 
            this.tbProductKey.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbProductKey.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbProductKey.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbProductKey.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.tbProductKey.Location = new System.Drawing.Point(98, 114);
            this.tbProductKey.Name = "tbProductKey";
            this.tbProductKey.Size = new System.Drawing.Size(348, 29);
            this.tbProductKey.TabIndex = 38;
            // 
            // btnAddKey
            // 
            this.btnAddKey.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddKey.AutoSize = false;
            this.btnAddKey.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAddKey.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAddKey.Depth = 0;
            this.btnAddKey.HighEmphasis = true;
            this.btnAddKey.Icon = null;
            this.btnAddKey.Location = new System.Drawing.Point(189, 173);
            this.btnAddKey.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAddKey.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAddKey.Name = "btnAddKey";
            this.btnAddKey.Size = new System.Drawing.Size(168, 36);
            this.btnAddKey.TabIndex = 41;
            this.btnAddKey.Text = "Add";
            this.btnAddKey.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAddKey.UseAccentColor = true;
            this.btnAddKey.UseVisualStyleBackColor = true;
            this.btnAddKey.Click += new System.EventHandler(this.btnAddKey_Click);
            // 
            // addProductKey
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 239);
            this.Controls.Add(this.btnAddKey);
            this.Controls.Add(this.tbProductKey);
            this.Controls.Add(this.label1);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_None;
            this.Name = "addProductKey";
            this.Padding = new System.Windows.Forms.Padding(3, 24, 3, 3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "addProductKey";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.addProductKey_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbProductKey;
        private MaterialSkin.Controls.MaterialButton btnAddKey;
    }
}