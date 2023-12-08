using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bullet_Email_Sender
{
    public partial class addProxy : MaterialForm
    {
        public readonly MaterialSkinManager materialSkinManagerMail;
        private readonly Form1 frm1;
        string parentDirectory = System.IO.Directory.GetParent(Environment.CurrentDirectory.ToString()).FullName;


        public addProxy(Form1 frm)
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

            label1.Font = new Font("Dubai", 16, FontStyle.Bold);

            label2.Font = new Font("Dubai", 12, FontStyle.Bold);
            label4.Font = new Font("Dubai", 12, FontStyle.Bold);
            label5.Font = new Font("Dubai", 12, FontStyle.Bold);
            label6.Font = new Font("Dubai", 12, FontStyle.Bold);
            label7.Font = new Font("Dubai", 12, FontStyle.Bold);

            tbHost.Font = new Font("Dubai", 12, FontStyle.Regular);
            tbPass.Font = new Font("Dubai", 12, FontStyle.Regular);
            tbPort.Font = new Font("Dubai", 12, FontStyle.Regular);
            tbUser.Font = new Font("Dubai", 12, FontStyle.Regular);
            tbType.Font = new Font("Dubai", 12, FontStyle.Regular);


            tbType.SelectedIndex = 0;

            //DARK/LIGHT THEME SETTING UI
            if (frm1.materialSkinManager.Theme.ToString() == "DARK")
            {
                //label
                label1.ForeColor = Color.FromArgb(229, 229, 229);

            }
            else if (frm1.materialSkinManager.Theme.ToString() == "LIGHT")
            {

                //Label
                label1.ForeColor = Color.FromArgb(66, 66, 66);

            }

        }

        private void btnAddProxy_Click(object sender, EventArgs e)
        {
            System.IO.Directory.CreateDirectory(parentDirectory + "\\Proxies");

            string proxyHost = tbHost.Text.ToString();
            string proxyPort = tbPort.Text.ToString();
            string proxyUser = tbUser.Text.ToString();
            string proxyPass = tbPass.Text.ToString();
            string proxyType = tbType.SelectedItem.ToString();

            string fileNameHost = proxyHost.Replace('.', '_');

            string finalBodySave = "Host=" + proxyHost + Environment.NewLine +
                "Port=" + proxyPort + Environment.NewLine +
                "User=" + proxyUser + Environment.NewLine +
                "Pass=" + proxyPass + Environment.NewLine +
                "Type=" + proxyType + Environment.NewLine;

            //string finalBodySave = letterBody + Environment.NewLine + letterAttachement;

            if (File.Exists(parentDirectory + "\\Proxies\\" + fileNameHost.ToString() + ".txt"))
            {
                File.Delete(parentDirectory + "\\Proxies\\" + fileNameHost.ToString() + ".txt");

            }

            File.Create(parentDirectory + "\\Proxies\\" + fileNameHost.ToString() + ".txt").Close();
            File.WriteAllText(parentDirectory + "\\Proxies\\" + fileNameHost.ToString() + ".txt", finalBodySave);

            Form1.proxyHost = proxyHost;
            Form1.proxyPort = proxyPort;
            Form1.proxyUser = proxyUser;
            Form1.proxyPass = proxyPass;
            Form1.proxyType = proxyType;

            frm1.updateDGProxy();

            this.Close();
        }
    }
}
