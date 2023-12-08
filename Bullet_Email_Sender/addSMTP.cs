using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Security;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bullet_Email_Sender
{
    public partial class addSMTP : MaterialForm
    {

        public readonly MaterialSkinManager materialSkinManagerLetter;
        string parentDirectory = System.IO.Directory.GetParent(Environment.CurrentDirectory.ToString()).FullName;
        private readonly Form1 frm1;
        string smtpStatusAdd = "NA";

        public addSMTP(Form1 frm)
        {
            InitializeComponent();

            frm1 = frm;

            this.MaximizeBox = false;

            //Getting Material Skin Library
            materialSkinManagerLetter = MaterialSkinManager.Instance;

            // Set this to false to disable backcolor enforcing on non-materialSkin components
            // This HAS to be set before the AddFormToManage()
            materialSkinManagerLetter.EnforceBackcolorOnAllComponents = true;

            // MaterialSkinManager properties
            materialSkinManagerLetter.AddFormToManage(this);
            //materialSkinManagerLetter.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManagerLetter.Theme = frm1.materialSkinManager.Theme;
            //materialSkinManager.ColorScheme =
            //    new ColorScheme(Primary.Red700, Primary.Red400,
            //    Primary.Red300, Accent.Red700, TextShade.WHITE);

            materialSkinManagerLetter.ColorScheme =
               new ColorScheme(Primary.Red700, Primary.Red900,
               Primary.Red300, Accent.Red200, TextShade.WHITE);

            label16.Font = new Font("Dubai", 14, FontStyle.Bold);

            label1.Font = new Font("Dubai", 10, FontStyle.Bold);
            label2.Font = new Font("Dubai", 10, FontStyle.Bold);
            label4.Font = new Font("Dubai", 10, FontStyle.Bold);
            label5.Font = new Font("Dubai", 10, FontStyle.Bold);
            label6.Font = new Font("Dubai", 10, FontStyle.Bold);
            label7.Font = new Font("Dubai", 10, FontStyle.Bold);

            cbSSL.Font = new Font("Dubai", 12, FontStyle.Bold);

            tbHost.Font = new Font("Dubai", 10, FontStyle.Bold);
            tbPort.Font = new Font("Dubai", 10, FontStyle.Bold);
            tbUser.Font = new Font("Dubai", 10, FontStyle.Bold);
            tbLimit.Font = new Font("Dubai", 10, FontStyle.Bold);
            tbToEmail.Font = new Font("Dubai", 10, FontStyle.Bold);
            tbPass.Font = new Font("Dubai", 10, FontStyle.Bold);


        }

        private void btnAddSMTP_Click(object sender, EventArgs e)
        {
            System.IO.Directory.CreateDirectory(parentDirectory + "\\SMTP");


            string smtpHostAdd = tbHost.Text.ToString();
            string smtpPortAdd = tbPort.Text.ToString();
            string smtpSSLAdd = (cbSSL.CheckState.ToString() == "Checked") ? "True" : "False";
            string smtpUserAdd = tbUser.Text.ToString();
            string smtpPassAdd = tbPass.Text.ToString();
            string smtpLimitAdd = tbLimit.Text.ToString();
            string smtpToEmailAdd = tbToEmail.Text.ToString();

            if (smtpToEmailAdd.ToString() == smtpUserAdd.ToString())
            {
                MaterialMessageBox.Show("Kindly change the UserName Email and Test Email.", "Email Error");
                return;
            }

            string fileNameHost = smtpHostAdd.Replace('.', '_');

            string finalBodySave = "Host=" + smtpHostAdd + Environment.NewLine +
                "Port=" + smtpPortAdd + Environment.NewLine +
                "SSL=" + smtpSSLAdd + Environment.NewLine +
                "User=" + smtpUserAdd + Environment.NewLine +
                "Pass=" + smtpPassAdd + Environment.NewLine +
                "Limit=" + smtpLimitAdd + Environment.NewLine +
                "Status=" + smtpStatusAdd + Environment.NewLine;


            //string finalBodySave = letterBody + Environment.NewLine + letterAttachement;

            if (File.Exists(parentDirectory + "\\SMTP\\" + fileNameHost.ToString() + ".txt"))
            {
                File.Delete(parentDirectory + "\\SMTP\\" + fileNameHost.ToString() + ".txt");

            }

            File.Create(parentDirectory + "\\SMTP\\" + fileNameHost.ToString() + ".txt").Close();
            File.WriteAllText(parentDirectory + "\\SMTP\\" + fileNameHost.ToString() + ".txt", finalBodySave);


            Form1.smtpHost = smtpHostAdd;
            Form1.smtpPort = smtpPortAdd;
            Form1.smtpSSL = smtpSSLAdd;
            Form1.smtpUser = smtpUserAdd;
            Form1.smtpPass = smtpPassAdd;
            Form1.smtpLimit = smtpLimitAdd;
            Form1.smtpStatus = smtpStatusAdd;


            frm1.updateDGSMTP();
            this.Close();

        }

        private void btnTestSMTP_Click(object sender, EventArgs e)
        {
            string smtpHostAdd = tbHost.Text.ToString();
            string smtpPortAdd = tbPort.Text.ToString();
            string smtpSSLAdd = (cbSSL.CheckState.ToString() == "Checked") ? "True" : "False";
            string smtpUserAdd = tbUser.Text.ToString();
            string smtpPassAdd = tbPass.Text.ToString();
            string smtpToEmailAdd = tbToEmail.Text.ToString();

            if (smtpToEmailAdd.ToString() == smtpUserAdd.ToString())
            {
                MaterialMessageBox.Show("Kindly change the UserName Email and Test Email.", "Email Error");
                return;
            }

            using (var client = new TcpClient())
            {
                var server = smtpHostAdd.Trim();
                var port = Convert.ToInt32(smtpPortAdd.Trim());
                client.Connect(server, port);

                // As GMail requires SSL we should use SslStream
                // If your SMTP server doesn't support SSL you can
                // work directly with the underlying stream


                //SSL SMTP Check
                using (var stream = client.GetStream())
                using (var sslStream = new SslStream(stream))
                {
                    sslStream.AuthenticateAsClient(server);
                    using (var writer = new StreamWriter(sslStream))
                    using (var reader = new StreamReader(sslStream))
                    {
                        writer.WriteLine("EHLO " + server);
                        writer.Flush();
                        //Console.WriteLine(reader.ReadLine());
                        if (reader.ReadLine().ToString().Contains("220") ||
                            reader.ReadLine().ToString().Contains("250"))
                        {
                            smtpStatusAdd = "Active";
                        }
                        MaterialMessageBox.Show(reader.ReadLine());
                        // GMail responds with: 220 mx.google.com ESMTP
                    }
                }

                

                //also test email and password here


            }
        }
    }
}
