using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bullet_Email_Sender
{
    public partial class addProductKey : MaterialForm
    {

        public readonly MaterialSkinManager materialSkinManagerMail;
        private readonly Form1 frm1;
        string parentDirectory = System.IO.Directory.GetParent(Environment.CurrentDirectory.ToString()).FullName;

        public addProductKey(Form1 frm)
        {
            InitializeComponent();

            frm1 = frm;

            this.MaximizeBox = false;

            //Getting Material Skin Library
            materialSkinManagerMail = MaterialSkinManager.Instance;

            // Set this to false to disable backcolor enforcing on non-materialSkin components
            // This HAS to be set before the AddFormToManage()
            materialSkinManagerMail.EnforceBackcolorOnAllComponents = true;

            // MaterialSkinManager properties
            materialSkinManagerMail.AddFormToManage(this);
            materialSkinManagerMail.Theme = frm1.materialSkinManager.Theme;
            //materialSkinManager.ColorScheme =
            //    new ColorScheme(Primary.Red700, Primary.Red400,
            //    Primary.Red300, Accent.Red700, TextShade.WHITE);

            materialSkinManagerMail.ColorScheme =
               new ColorScheme(Primary.Red700, Primary.Red900,
               Primary.Red300, Accent.Red200, TextShade.WHITE);

            label1.Font = new Font("Dubai", 14, FontStyle.Bold);
            tbProductKey.Font = new Font("Dubai", 12, FontStyle.Bold);

            //DARK/LIGHT THEME SETTING UI
            if (frm1.materialSkinManager.Theme.ToString() == "DARK")
            {
                //label
                label1.ForeColor = Color.FromArgb(229, 229, 229);
                tbProductKey.BackColor = Color.FromArgb(50, 50, 50); //DARK GRAY
                tbProductKey.ForeColor = Color.FromArgb(242, 242, 242); //WHITE GRAY
            }
            else if (frm1.materialSkinManager.Theme.ToString() == "LIGHT")
            {

                //Label
                label1.ForeColor = Color.FromArgb(66, 66, 66);
                tbProductKey.BackColor = Color.FromArgb(242, 242, 242);
                tbProductKey.ForeColor = Color.FromArgb(66, 66, 66);
            }

        }

        private void btnAddKey_Click(object sender, EventArgs e)
        {

            string[] license30 = { "1E48559A5D2818BD4725644BCB22B",
                "1E68559A5D2818BD4725644BCB24B",
                "1E88559A5D2818BD4725644BCB26B",
                "1E28559A5D2818BD4725644BCB28B" };

            string[] licenseFull = { "1E58559A5D2818BD4725644BCB23B",
                "1E78559A5D2818BD4725644BCB25B",
                "1E38559A5D2818BD4725644BCB27B",
                "1E78559A5D2818BD4725644BCB25B" };

            string licenseKeyLive = tbProductKey.Text.ToString().Trim();

            int pos = Array.IndexOf(license30, licenseKeyLive);
            if (pos > -1)
            {
                if(Form1.licenseFull == "Yes")
                {
                    MaterialMessageBox.Show("Kindly Add A Full-Time License Key");
                    return;
                }
                else if(Form1.licenseFull == "No")
                {
                    //add key for 30 days
                    File.WriteAllText(parentDirectory + "license.txt", licenseKeyLive);

                    MaterialMessageBox.Show("You Have Activated the Trial Version");
                    Form1.licenseDetails = "30";
                    this.Close();
                    return;
                }
                                
            }

            pos = Array.IndexOf(licenseFull, licenseKeyLive);
            if (pos > -1)
            {
                //add key for full 
                File.WriteAllText(parentDirectory + "license.txt", licenseKeyLive);

                MaterialMessageBox.Show("You Have Activated the Full Version");
                Form1.licenseDetails = "Full";
                this.Close();
                return;
                
            }

            MaterialMessageBox.Show("Kindly Add A Valid Product Key");
            
        }

        private void addProductKey_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(Form1.licenseDetails == "NA")
            {
                Application.Exit();
            }
        }
    }
}
