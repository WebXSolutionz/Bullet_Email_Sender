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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bullet_Email_Sender
{
    public partial class addMailRecepient : MaterialForm
    {

        public readonly MaterialSkinManager materialSkinManagerMail;
        private readonly Form1 frm1;
        string parentDirectory = System.IO.Directory.GetParent(Environment.CurrentDirectory.ToString()).FullName;
        string glistName = null;
        string glistCount = null;

        public addMailRecepient(Form1 frm)
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
            label9.Font = new Font("Dubai", 10, FontStyle.Bold);
            rtTotalEmails.Font = new Font("Dubai", 12, FontStyle.Bold);
            rtEmails.Font = new Font("Dubai", 14, FontStyle.Regular);

            //DARK/LIGHT THEME SETTING UI
            if (frm1.materialSkinManager.Theme.ToString() == "DARK")
            {
                //label
                label1.ForeColor = Color.FromArgb(229, 229, 229);
                label9.ForeColor = Color.FromArgb(229, 229, 229);
                rtTotalEmails.BackColor = Color.FromArgb(50, 50, 50); //DARK GRAY
                rtTotalEmails.ForeColor = Color.FromArgb(242, 242, 242); //WHITE GRAY
            }
            else if (frm1.materialSkinManager.Theme.ToString() == "LIGHT")
            {

                //Label
                label1.ForeColor = Color.FromArgb(66, 66, 66);
                label9.ForeColor = Color.FromArgb(66, 66, 66);
                rtTotalEmails.BackColor = Color.FromArgb(242, 242, 242);
                rtTotalEmails.ForeColor = Color.FromArgb(66, 66, 66);
            }
        }

        private void rtEmails_TextChanged(object sender, EventArgs e)
        {
            rtTotalEmails.Text = rtEmails.Lines.Count().ToString();

        }

        private void rtTotalEmails_TextChanged(object sender, EventArgs e)
        {
            rtTotalEmails.Text = rtEmails.Lines.Count().ToString();

        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "All Files (*.*)|*.*";
            dialog.FilterIndex = 1;
            dialog.Multiselect = false;
            dialog.InitialDirectory = parentDirectory;


            string[] currentData = null;


            glistName = null;
            glistCount = null;

            string currentBody = "";

            if (dialog.ShowDialog() == DialogResult.OK)
            {

                glistName = dialog.FileName;
                currentData = File.ReadAllLines(glistName);

                if (currentData != null)
                {
                    StringBuilder sb = new StringBuilder();

                    for (int i = 0; i < currentData.Length; i++)
                    {
                        sb.AppendFormat("{0}", currentData[i].TrimEnd(','));
                        sb.AppendLine();

                    }


                    rtEmails.Text = sb.ToString();
                    rtEmails.Lines = rtEmails.Lines.Take(rtEmails.Lines.Length - 1).ToArray();
                    rtTotalEmails.Text = currentData.Count().ToString();

                }
            }
            frm1.updateControls();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (rtEmails.Lines.Count() <= 0)
            {
                MaterialMessageBox.Show("Please Enter Valid Emails.", "No Emails Found");
                return;
            }

            if (Form1.letterName != null)
            {
                Form1.senderEmails = rtEmails.Lines;
                frm1.updateDGSender();
                this.Close();

            }
            else
            {
                MaterialMessageBox.Show("Please Choose a Valid Letter for Emails.", "No Letter Found");
                return;
            }
            frm1.updateControls();
        }

        private void addMailRecepient_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm1.updateControls();
        }
    }
}

//NOT USING THIS RIGHT NOW
class round : RichTextBox
{
    [System.Runtime.InteropServices.DllImport("gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
    private static extern IntPtr CreateRoundRectRgn
    (
        int nLeftRect, // X-coordinate of upper-left corner or padding at start
        int nTopRect,// Y-coordinate of upper-left corner or padding at the top of the textbox
        int nRightRect, // X-coordinate of lower-right corner or Width of the object
        int nBottomRect,// Y-coordinate of lower-right corner or Height of the object
                        //RADIUS, how round do you want it to be?
        int nheightRect, //height of ellipse 
        int nweightRect //width of ellipse
    );
    protected override void OnCreateControl()
    {
        base.OnCreateControl();
        this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(2, 3, this.Width, this.Height, 15, 15)); //play with these values till you are happy
    }
}