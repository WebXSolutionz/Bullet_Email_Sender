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
    public partial class addLetter : MaterialForm
    {
        public readonly MaterialSkinManager materialSkinManagerLetter;
        private readonly Form1 frm1;
        string parentDirectory = System.IO.Directory.GetParent(Environment.CurrentDirectory.ToString()).FullName;
        string letterAttachement = "NA";

        public addLetter(Form1 frm)
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

            lbLetter.Font = new Font("Dubai", 14, FontStyle.Bold);
            label6.Font = new Font("Dubai", 10, FontStyle.Bold);
            label1.Font = new Font("Dubai", 10, FontStyle.Bold);
            tbLetterName.Font = new Font("Dubai", 12, FontStyle.Bold);
            tbAttachLocation.Font = new Font("Dubai", 12,FontStyle.Regular);
            rtLetterBody.Font = new Font("Dubai", 12, FontStyle.Bold);

        }

        private void addLetter_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm1.updateControls();
        }

        private void btnRest_Click(object sender, EventArgs e)
        {
            tbAttachLocation.Text = "";
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "All Files (*.*)|*.*";
            dialog.FilterIndex = 1;
            dialog.Multiselect = false;
            dialog.InitialDirectory = parentDirectory;
            


            if (dialog.ShowDialog() == DialogResult.OK)
            {

                letterAttachement = dialog.FileName;

            }

            tbAttachLocation.Text = letterAttachement;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            rtLetterBody.Clear();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            System.IO.Directory.CreateDirectory(parentDirectory + "\\Letters");


            string letterName = tbLetterName.Text.ToString();
            string letterBody = rtLetterBody.Text.ToString();
            letterAttachement = "LetterAttachment: " + letterAttachement;

            string finalBodySave = letterBody + Environment.NewLine + letterAttachement;

            if (File.Exists(parentDirectory + "\\Letters\\" + letterName.ToString() + ".txt"))
            {
                File.Delete(parentDirectory + "\\Letters\\" + letterName.ToString() + ".txt");

            }

            File.Create(parentDirectory + "\\Letters\\" + letterName.ToString() + ".txt").Close();
            File.WriteAllText(parentDirectory + "\\Letters\\" + letterName.ToString() + ".txt", finalBodySave);

            Form1.letterName = letterName;
            Form1.letterBody = letterBody;
            Form1.letterAttach = letterAttachement.Substring(18);

            frm1.updateDGLetter();


            this.Close();
        }
    }
}
