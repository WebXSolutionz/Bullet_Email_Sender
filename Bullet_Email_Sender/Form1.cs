using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Threading;
using System.Configuration;

namespace Bullet_Email_Sender
{
    public partial class Form1 : MaterialForm
    {
        public readonly MaterialSkinManager materialSkinManager;
        private int colorSchemeIndex;
        string parentDirectory = System.IO.Directory.GetParent(Environment.CurrentDirectory.ToString()).FullName;

        public DataTable dtSenderMails = new DataTable();

        private BackgroundWorker bw;


        //license
        public static string licenseDetails = "NA";
        public static string licenseFull = "No";

        //letter details
        public static string[] senderEmails;
        public static string letterName = null;
        public static string letterBody = null;
        public static string letterAttach = null;

        public static string fromEmailSender = null;
        public static string fromNameSender = null;
        public static string fromSubject = null;


        //SMTP details
        public static string smtpHost = null;
        public static string smtpPort = null;
        public static string smtpSSL = null;
        public static string smtpUser = null;
        public static string smtpPass = null;
        public static string smtpLimit = null;
        public static string smtpStatus = "NA";

        //List details
        string glistName = null;
        string glistCount = null;


        //Proxy Details
        public static string proxyHost = null;
        public static string proxyPort = null;
        public static string proxyUser = null;
        public static string proxyPass = null;
        public static string proxyType = null;



        private void bw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //MaterialMessageBox.Show("All Emails Sent");
        }

        private void bw_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            //Nothing 
        }

        private void bw_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = (BackgroundWorker)sender;



            if (smtpHost is null || letterName is null)
            {
                MaterialMessageBox.Show("Kindly provide a valid \"Letter\" and \"SMTP Host.\"", "Missing Parameters");
                return;
            }


            if (senderEmails is null)
            {
                MaterialMessageBox.Show("Kindly provide a valid \"Email List.\"", "Missing Parameters");
                return;
            }

            senderEmails = senderEmails.Where(x => !string.IsNullOrEmpty(x)).ToArray();

            for (int i = 0; i <= senderEmails.Count() - 1; i++)
            {
                senderEmails[i] = senderEmails[i].Trim().TrimEnd().TrimStart().ToString();
            }


            string finalResult = string.Empty;

            fromEmailSender = txFromMail.Text.ToString();
            fromNameSender = txFromName.Text.ToString();
            fromSubject = txSubject.Text.ToString();

            if (fromEmailSender != string.Empty || fromNameSender != string.Empty || fromSubject != string.Empty)
            {

            }
            else
            {
                if (tbPageSender.InvokeRequired)
                {
                    tbPageSender.Invoke(new MethodInvoker(delegate
                    {
                        MaterialMessageBox.Show("Kindly provide a valid \"From Name, \" \"Sender Email,\" and \"Subject.\"", "Missing Parameters");
                        return;
                    }));
                }
                else
                {
                    MaterialMessageBox.Show("Kindly provide a valid \"From Name, \" \"Sender Email,\" and \"Subject.\"", "Missing Parameters");
                    return;
                }
                if (btnStart.InvokeRequired)
                {
                    btnStart.Invoke(new MethodInvoker(delegate { btnStart.Enabled = true; }));
                }
                else
                {
                    btnStart.Enabled = true;
                }
                return;
            }

            if (lbLetterCount.InvokeRequired)
            {
                lbLetterCount.Invoke(new MethodInvoker(delegate { lbLetterCount.Text = "1"; }));
            }
            else
            {
                lbLetterCount.Text = "1";
            }

            if (lbSMTPCount.InvokeRequired)
            {
                lbSMTPCount.Invoke(new MethodInvoker(delegate { lbSMTPCount.Text = "1"; }));
            }
            else
            {
                lbSMTPCount.Text = "1";
            }

            if (lbHeaderCount.InvokeRequired)
            {
                lbHeaderCount.Invoke(new MethodInvoker(delegate { lbHeaderCount.Text = "1"; }));
            }
            else
            {
                lbHeaderCount.Text = "1";
            }

            if (lbAllProgress.InvokeRequired)
            {
                lbAllProgress.Invoke(new MethodInvoker(delegate { lbAllProgress.Text = "1"; }));
            }
            else
            {
                lbAllProgress.Text = "1";
            }

            //lbLetterCount.Text = "1";
            //lbSMTPCount.Text = "1";
            //lbHeaderCount.Text = "1";
            //lbAllProgress.Text = "0";

            int allProgressEmails = 0;
            int sentEmails = 0;
            int failedEmails = 0;
            int countDG = 0;

            if (dgMainSender.InvokeRequired)
            {
                dgMainSender.Invoke(new MethodInvoker(delegate { countDG = dgMainSender.Rows.Count - 1; }));
            }
            else
            {
                countDG = dgMainSender.Rows.Count - 1;
            }


            //if (btnStart.InvokeRequired)
            //{
            //    btnStart.Invoke(new MethodInvoker(delegate { }));
            //}
            //else
            //{
            //    btnStart.Enabled = false;
            //}

            if (btnStart.InvokeRequired)
            {
                btnStart.Invoke(new MethodInvoker(delegate { btnStart.Enabled = false; }));
            }
            else
            {
                btnStart.Enabled = false;
            }

            if (btnMailList.InvokeRequired)
            {
                btnMailList.Invoke(new MethodInvoker(delegate { btnMailList.Enabled = false; }));
            }
            else
            {
                btnMailList.Enabled = false;
            }



            for (int counter = 0; counter <= countDG; counter++) //fix it
            {

                if (worker.CancellationPending == true)
                {
                    e.Cancel = true;
                    break;
                }
                else
                {
                    finalResult = sendEmail(fromEmailSender.ToString().Trim(),
                                        smtpPass.ToString().Trim(),
                                        dgMainSender[4, counter].Value.ToString().Trim(),
                                        fromSubject.ToString().Trim(),
                                        letterBody.ToString().Trim(),
                                        fromNameSender.ToString().Trim(),
                                        smtpHost.ToString().Trim(),
                                        smtpPort.ToString().Trim());

                    if (finalResult == "Sent")
                    {
                        sentEmails += 1;
                        if (lbSent.InvokeRequired)
                        {
                            lbSent.Invoke(new MethodInvoker(delegate { lbSent.Text = sentEmails.ToString(); }));
                        }
                        else
                        {
                            lbSent.Text = sentEmails.ToString();
                        }

                        if (dgMainSender.InvokeRequired)
                        {
                            dgMainSender.Invoke(new MethodInvoker(delegate { dgMainSender[6, counter].Value = "Sent"; }));
                        }
                        else
                        {
                            dgMainSender[6, counter].Value = "Sent";
                        }

                    }
                    else
                    {
                        failedEmails += 1;
                        if (lbFailed.InvokeRequired)
                        {
                            lbFailed.Invoke(new MethodInvoker(delegate { lbFailed.Text = failedEmails.ToString(); }));
                        }
                        else
                        {
                            lbFailed.Text = failedEmails.ToString();
                        }

                        if (dgMainSender.InvokeRequired)
                        {
                            dgMainSender.Invoke(new MethodInvoker(delegate { dgMainSender[6, counter].Value = "Failed"; }));
                        }
                        else
                        {
                            dgMainSender[6, counter].Value = "Failed";
                        }


                    }

                    //at end


                    allProgressEmails += 1;
                    if (lbAllProgress.InvokeRequired)
                    {
                        lbAllProgress.Invoke(new MethodInvoker(delegate { lbAllProgress.Text = allProgressEmails.ToString(); }));
                    }
                    else
                    {
                        lbAllProgress.Text = allProgressEmails.ToString();
                    }

                    if (allProgressEmails == countDG)
                    {
                        if (tbPageSender.InvokeRequired)
                        {
                            tbPageSender.Invoke(new MethodInvoker(delegate { MaterialMessageBox.Show("All Emails Sent"); }));
                        }
                        else
                        {
                            MaterialMessageBox.Show("All Emails Sent");
                        }
                    }

                }

            }

            if (btnStart.InvokeRequired)
            {
                btnStart.Invoke(new MethodInvoker(delegate { btnStart.Enabled = true; }));
            }
            else
            {
                btnStart.Enabled = true;
            }



        }

        public Form1()
        {
            InitializeComponent();



            //Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));

            //Getting Material Skin Library
            materialSkinManager = MaterialSkinManager.Instance;

            this.MaximizeBox = false;

            // Set this to false to disable backcolor enforcing on non-materialSkin components
            // This HAS to be set before the AddFormToManage()
            materialSkinManager.EnforceBackcolorOnAllComponents = true;

            // MaterialSkinManager properties
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            //materialSkinManager.ColorScheme =
            //    new ColorScheme(Primary.Red700, Primary.Red400,
            //    Primary.Red300, Accent.Red700, TextShade.WHITE);

            materialSkinManager.ColorScheme =
               new ColorScheme(Primary.Red700, Primary.Red900,
               Primary.Red300, Accent.Red200, TextShade.WHITE);

            //////testing
            //for (int i = 0; i <= 500; i++)
            //{
            //    //test values
            //    DataGridViewRow row = (DataGridViewRow)dgMainSender.Rows[0].Clone();
            //    row.Cells[0].Value = "";
            //    row.Cells[1].Value = "";
            //    row.Cells[2].Value = "";
            //    row.Cells[3].Value = "test";
            //    row.Cells[4].Value = "wow";
            //    row.Cells[5].Value = "Ready to be Sent";
            //    row.Cells[6].Value = "NA";
            //    dgMainSender.Rows.Add(row);
            //}

            //Custom settings on app load
            updateControls();


            this.bw = new BackgroundWorker();

            this.bw.DoWork += new DoWorkEventHandler(bw_DoWork);
            this.bw.ProgressChanged += new ProgressChangedEventHandler(bw_ProgressChanged);
            this.bw.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bw_RunWorkerCompleted);

            this.bw.WorkerReportsProgress = true;
            this.bw.WorkerSupportsCancellation = true;


            //check keys
            string licenseKey = "";

            if (File.Exists(parentDirectory + "license.txt"))
            {
                licenseKey = File.ReadAllText(parentDirectory + "license.txt");
                licenseKey = licenseKey.Trim();

                if (licenseKey == "")
                {
                    MaterialMessageBox.Show("Kindly Add A Valid Product Key");
                    var myForm = new addProductKey(this);
                    myForm.ShowDialog();
                    updateControls();
                }
                else
                {
                    string[] license30 = { "1E48559A5D2818BD4725644BCB22B",
                "1E68559A5D2818BD4725644BCB24B",
                "1E88559A5D2818BD4725644BCB26B",
                "1E28559A5D2818BD4725644BCB28B" };

                    string[] licenseFull = { "1E58559A5D2818BD4725644BCB23B",
                "1E78559A5D2818BD4725644BCB25B",
                "1E38559A5D2818BD4725644BCB27B",
                "1E78559A5D2818BD4725644BCB25B" };

                    int pos = Array.IndexOf(license30, licenseKey);
                    if (pos > -1)
                    {
                        licenseDetails = "30";
                        
                    }

                    pos = Array.IndexOf(licenseFull, licenseKey);
                    if (pos > -1)
                    {
                        licenseDetails = "Full";
                        
                    }

                }
            }
            else
            {
                File.Create(parentDirectory + "license.txt").Close();
                MaterialMessageBox.Show("Kindly Add A Valid Product Key");
                var myForm = new addProductKey(this);
                myForm.ShowDialog();
                updateControls();
            }

            if(licenseDetails == "NA")
            {
                MaterialMessageBox.Show("Kindly Add a Valid Product Key");
                var myForm = new addProductKey(this);
                myForm.ShowDialog();
                updateControls();
            }
            else if(licenseDetails == "30")
            {
                DateTime creation = File.GetCreationTime(parentDirectory + "license.txt");
                DateTime modified = File.GetLastWriteTime(parentDirectory + "license.txt");
                if((DateTime.Now - creation).TotalDays > 30)
                {
                    MaterialMessageBox.Show("Your Trial Period Has Expired.Kindly Add a Full-Time License Key");
                    licenseFull = "Yes";
                    var myForm = new addProductKey(this);
                    myForm.ShowDialog();
                    updateControls();
                }
            }

            //File.WriteAllText(parentDirectory + "\\Letters\\" + letterName.ToString() + ".txt", finalBodySave);





        }


        public void updateControls()
        {

            //generic settings
            label1.Font = new Font("Dubai", 20, FontStyle.Bold);
            label15.Font = new Font("Dubai", 20, FontStyle.Bold);
            label16.Font = new Font("Dubai", 20, FontStyle.Bold);
            label17.Font = new Font("Dubai", 20, FontStyle.Bold);
            label18.Font = new Font("Dubai", 20, FontStyle.Bold);
            label21.Font = new Font("Dubai", 20, FontStyle.Bold);
            label23.Font = new Font("Dubai", 20, FontStyle.Bold);
            label24.Font = new Font("Dubai", 20, FontStyle.Bold);
            label27.Font = new Font("Dubai", 20, FontStyle.Bold);




            //set context menu strip for sender page
            textBoxContextMenuStrip1.Items.Clear();
            textBoxContextMenuStrip1.Items.Add("Add Mail List");
            textBoxContextMenuStrip1.Items.Add("Delete Selected");
            textBoxContextMenuStrip1.Items.Add("Clear All");
            textBoxContextMenuStrip1.Items.Add("Cancel");
            textBoxContextMenuStrip1.Font = new Font("Dubai", 10, FontStyle.Bold);
            textBoxContextMenuStrip1.Items[0].Click += new System.EventHandler(this.AddMail_Sender);
            textBoxContextMenuStrip1.Items[1].Click += new System.EventHandler(this.DeleteSelected_Sender);
            textBoxContextMenuStrip1.Items[2].Click += new System.EventHandler(this.ClrAll_Sender);
            textBoxContextMenuStrip1.Items[3].Click += new System.EventHandler(this.Cancel_Sender);


            //datagridview settings
            //sender
            dgMainSender.AdvancedCellBorderStyle.Left = DataGridViewAdvancedCellBorderStyle.None;
            dgMainSender.AdvancedCellBorderStyle.Right = DataGridViewAdvancedCellBorderStyle.None;
            //dgMainSender.AdvancedCellBorderStyle.Bottom = DataGridViewAdvancedCellBorderStyle.None;
            dgMainSender.AdvancedCellBorderStyle.Bottom = DataGridViewAdvancedCellBorderStyle.Single;
            dgMainSender.AdvancedCellBorderStyle.Top = DataGridViewAdvancedCellBorderStyle.None;
            dgMainSender.RowHeadersVisible = false;
            dgMainSender.ScrollBars = ScrollBars.Both;

            //letters
            dgLetters.AdvancedCellBorderStyle.Left = DataGridViewAdvancedCellBorderStyle.None;
            dgLetters.AdvancedCellBorderStyle.Right = DataGridViewAdvancedCellBorderStyle.None;
            //dgLetters.AdvancedCellBorderStyle.Bottom = DataGridViewAdvancedCellBorderStyle.None;
            dgLetters.AdvancedCellBorderStyle.Bottom = DataGridViewAdvancedCellBorderStyle.Single;
            dgLetters.AdvancedCellBorderStyle.Top = DataGridViewAdvancedCellBorderStyle.None;
            dgLetters.RowHeadersVisible = false;
            dgLetters.ScrollBars = ScrollBars.Both;

            //SMTP
            dgSMTP.AdvancedCellBorderStyle.Left = DataGridViewAdvancedCellBorderStyle.None;
            dgSMTP.AdvancedCellBorderStyle.Right = DataGridViewAdvancedCellBorderStyle.None;
            //dgSMTP.AdvancedCellBorderStyle.Bottom = DataGridViewAdvancedCellBorderStyle.None;
            dgSMTP.AdvancedCellBorderStyle.Bottom = DataGridViewAdvancedCellBorderStyle.Single;
            dgSMTP.AdvancedCellBorderStyle.Top = DataGridViewAdvancedCellBorderStyle.None;
            dgSMTP.RowHeadersVisible = false;
            dgSMTP.ScrollBars = ScrollBars.Both;

            //SMTP Checker
            dgSMTPCheck.AdvancedCellBorderStyle.Left = DataGridViewAdvancedCellBorderStyle.None;
            dgSMTPCheck.AdvancedCellBorderStyle.Right = DataGridViewAdvancedCellBorderStyle.None;
            //dgSMTP.AdvancedCellBorderStyle.Bottom = DataGridViewAdvancedCellBorderStyle.None;
            dgSMTPCheck.AdvancedCellBorderStyle.Bottom = DataGridViewAdvancedCellBorderStyle.Single;
            dgSMTPCheck.AdvancedCellBorderStyle.Top = DataGridViewAdvancedCellBorderStyle.None;
            dgSMTPCheck.RowHeadersVisible = false;
            dgSMTPCheck.ScrollBars = ScrollBars.Both;

            //List Email
            dgListEmail.AdvancedCellBorderStyle.Left = DataGridViewAdvancedCellBorderStyle.None;
            dgListEmail.AdvancedCellBorderStyle.Right = DataGridViewAdvancedCellBorderStyle.None;
            //dgSMTP.AdvancedCellBorderStyle.Bottom = DataGridViewAdvancedCellBorderStyle.None;
            dgListEmail.AdvancedCellBorderStyle.Bottom = DataGridViewAdvancedCellBorderStyle.Single;
            dgListEmail.AdvancedCellBorderStyle.Top = DataGridViewAdvancedCellBorderStyle.None;
            dgListEmail.RowHeadersVisible = false;
            dgListEmail.ScrollBars = ScrollBars.Both;

            //Proxy
            dgProxy.AdvancedCellBorderStyle.Left = DataGridViewAdvancedCellBorderStyle.None;
            dgProxy.AdvancedCellBorderStyle.Right = DataGridViewAdvancedCellBorderStyle.None;
            //dgSMTP.AdvancedCellBorderStyle.Bottom = DataGridViewAdvancedCellBorderStyle.None;
            dgProxy.AdvancedCellBorderStyle.Bottom = DataGridViewAdvancedCellBorderStyle.Single;
            dgProxy.AdvancedCellBorderStyle.Top = DataGridViewAdvancedCellBorderStyle.None;
            dgProxy.RowHeadersVisible = false;
            dgProxy.ScrollBars = ScrollBars.Both;

            //setting UI for groupbox Sender
            label2.Font = new Font("Dubai", 10, FontStyle.Bold);
            label3.Font = new Font("Dubai", 10, FontStyle.Bold);
            label4.Font = new Font("Dubai", 10, FontStyle.Bold);
            label5.Font = new Font("Dubai", 10, FontStyle.Bold);
            label6.Font = new Font("Dubai", 10, FontStyle.Bold);
            label7.Font = new Font("Dubai", 10, FontStyle.Bold);
            label8.Font = new Font("Dubai", 10, FontStyle.Bold);
            label9.Font = new Font("Dubai", 10, FontStyle.Bold);
            label10.Font = new Font("Dubai", 10, FontStyle.Bold);
            label11.Font = new Font("Dubai", 10, FontStyle.Bold);
            label12.Font = new Font("Dubai", 10, FontStyle.Bold);
            label13.Font = new Font("Dubai", 10, FontStyle.Bold);
            label14.Font = new Font("Dubai", 10, FontStyle.Bold);
            label20.Font = new Font("Dubai", 10, FontStyle.Bold);
            tbDelay.Font = new Font("Dubai", 10, FontStyle.Bold);
            cbPriority.Font = new Font("Dubai", 10, FontStyle.Bold);
            cbSendingMethod.Font = new Font("Dubai", 10, FontStyle.Bold);
            cbRetry.Font = new Font("Dubai", 10, FontStyle.Bold);
            txFromMail.Font = new Font("Dubai", 10, FontStyle.Bold);
            txFromName.Font = new Font("Dubai", 10, FontStyle.Bold);
            txSubject.Font = new Font("Dubai", 10, FontStyle.Bold);
            lbAllProgress.Font = new Font("Dubai", 10, FontStyle.Bold);
            lbFailed.Font = new Font("Dubai", 10, FontStyle.Bold);
            lbHeaderCount.Font = new Font("Dubai", 10, FontStyle.Bold);
            lbLetterCount.Font = new Font("Dubai", 10, FontStyle.Bold);
            lbSent.Font = new Font("Dubai", 10, FontStyle.Bold);
            lbSMTPCount.Font = new Font("Dubai", 10, FontStyle.Bold);
            tbListName.Font = new Font("Dubai", 12, FontStyle.Bold);
            rtEmailList.Font = new Font("Dubai", 14, FontStyle.Regular);
            label19.Font = new Font("Dubai", 12, FontStyle.Bold);
            rtTotalList.Font = new Font("Dubai", 12, FontStyle.Bold);
            label22.Font = new Font("Dubai", 12, FontStyle.Bold);
            cbOn.Font = new Font("Dubai", 12, FontStyle.Bold);
            cbOff.Font = new Font("Dubai", 12, FontStyle.Bold);
            label25.Font = new Font("Dubai", 12, FontStyle.Bold);
            label26.Font = new Font("Dubai", 12, FontStyle.Bold);
            nmIMAP.Font = new Font("Dubai", 10, FontStyle.Bold);
            rtIMAP.Font = new Font("Dubai", 12, FontStyle.Regular);

            nmTimeOut.Font = new Font("Dubai", 10, FontStyle.Bold);
            label28.Font = new Font("Dubai", 10, FontStyle.Bold);
            label29.Font = new Font("Dubai", 10, FontStyle.Bold);
            label30.Font = new Font("Dubai", 10, FontStyle.Bold);
            label31.Font = new Font("Dubai", 10, FontStyle.Bold);
            label32.Font = new Font("Dubai", 10, FontStyle.Bold);
            label33.Font = new Font("Dubai", 10, FontStyle.Bold);
            label34.Font = new Font("Dubai", 10, FontStyle.Bold);
            label35.Font = new Font("Dubai", 10, FontStyle.Bold);
            label36.Font = new Font("Dubai", 10, FontStyle.Bold);
            label37.Font = new Font("Dubai", 10, FontStyle.Bold);
            label38.Font = new Font("Dubai", 10, FontStyle.Bold);
            label39.Font = new Font("Dubai", 10, FontStyle.Bold);
            label40.Font = new Font("Dubai", 10, FontStyle.Bold);
            label41.Font = new Font("Dubai", 10, FontStyle.Bold);
            cbDuplicate.Font = new Font("Dubai", 8, FontStyle.Bold);


            cbAlternate.Font = new Font("Dubai", 10, FontStyle.Bold);
            cbBodyTransfer.Font = new Font("Dubai", 10, FontStyle.Bold);
            cbFromEncoding.Font = new Font("Dubai", 10, FontStyle.Bold);
            cbLetterEncoding.Font = new Font("Dubai", 10, FontStyle.Bold);
            cbLetterEncryption.Font = new Font("Dubai", 10, FontStyle.Bold);
            cbSubjectEncryption.Font = new Font("Dubai", 10, FontStyle.Bold);
            tbAttachmentName.Font = new Font("Dubai", 10, FontStyle.Bold);
            tbReplyEmail.Font = new Font("Dubai", 10, FontStyle.Bold);
            rtPreHeader.Font = new Font("Dubai", 10, FontStyle.Bold);
            cbLinkEncode.Font = new Font("Dubai", 10, FontStyle.Bold);
            cbDelivery.Font = new Font("Dubai", 10, FontStyle.Bold);
            cbTextEncode.Font = new Font("Dubai", 10, FontStyle.Bold);
            cbSMTPLimit.Font = new Font("Dubai", 10, FontStyle.Bold);

            nmIMAP.Maximum = 10000000;
            nmIMAP.TextAlign = HorizontalAlignment.Center;

            nmTimeOut.Maximum = 10000000;
            nmTimeOut.TextAlign = HorizontalAlignment.Center;
            nmTimeOut.Value = 5000;

            cbPriority.SelectedIndex = 0;
            cbSendingMethod.SelectedIndex = 0;
            cbAlternate.SelectedIndex = 0;
            cbBodyTransfer.SelectedIndex = 0;
            cbFromEncoding.SelectedIndex = 0;
            cbLetterEncryption.SelectedIndex = 0;
            cbLetterEncoding.SelectedIndex = 0;
            cbSubjectEncryption.SelectedIndex = 0;
            cbLinkEncode.SelectedIndex = 0;
            cbDelivery.SelectedIndex = 0;
            cbTextEncode.SelectedIndex = 0;
            cbSMTPLimit.SelectedIndex = 0;


            //DARK/LIGHT THEME SETTING UI
            if (materialSkinManager.Theme.ToString() == "DARK")
            {
                //dg styles
                //sender
                dgMainSender.EnableHeadersVisualStyles = false;
                dgMainSender.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(50, 50, 50);
                dgMainSender.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                dgMainSender.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgMainSender.ColumnHeadersDefaultCellStyle.Font = new Font("Dubai", 10, FontStyle.Bold);

                dgMainSender.BackgroundColor = Color.FromArgb(66, 66, 66);
                dgMainSender.DefaultCellStyle.BackColor = Color.FromArgb(66, 66, 66);
                dgMainSender.ForeColor = Color.FromArgb(229, 229, 229);
                dgMainSender.DefaultCellStyle.Font = new Font("Dubai", 10);

                foreach (DataGridViewRow row in dgMainSender.Rows)
                {
                    row.DefaultCellStyle.BackColor = Color.FromArgb(66, 66, 66);
                    row.DefaultCellStyle.ForeColor = Color.FromArgb(229, 229, 229);
                }

                //letter
                dgLetters.EnableHeadersVisualStyles = false;
                dgLetters.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(50, 50, 50);
                dgLetters.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                dgLetters.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgLetters.ColumnHeadersDefaultCellStyle.Font = new Font("Dubai", 10, FontStyle.Bold);

                dgLetters.BackgroundColor = Color.FromArgb(66, 66, 66);
                dgLetters.DefaultCellStyle.BackColor = Color.FromArgb(66, 66, 66);
                dgLetters.ForeColor = Color.FromArgb(229, 229, 229);
                dgLetters.DefaultCellStyle.Font = new Font("Dubai", 10);


                foreach (DataGridViewRow row in dgLetters.Rows)
                {
                    row.DefaultCellStyle.BackColor = Color.FromArgb(66, 66, 66);
                    row.DefaultCellStyle.ForeColor = Color.FromArgb(229, 229, 229);
                }

                //SMTP
                dgSMTP.EnableHeadersVisualStyles = false;
                dgSMTP.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(50, 50, 50);
                dgSMTP.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                dgSMTP.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgSMTP.ColumnHeadersDefaultCellStyle.Font = new Font("Dubai", 10, FontStyle.Bold);

                dgSMTP.BackgroundColor = Color.FromArgb(66, 66, 66);
                dgSMTP.DefaultCellStyle.BackColor = Color.FromArgb(66, 66, 66);
                dgSMTP.ForeColor = Color.FromArgb(229, 229, 229);
                dgSMTP.DefaultCellStyle.Font = new Font("Dubai", 10);

                foreach (DataGridViewRow row in dgSMTP.Rows)
                {
                    row.DefaultCellStyle.BackColor = Color.FromArgb(66, 66, 66);
                    row.DefaultCellStyle.ForeColor = Color.FromArgb(229, 229, 229);
                }

                //SMTP Checker
                dgSMTPCheck.EnableHeadersVisualStyles = false;
                dgSMTPCheck.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(50, 50, 50);
                dgSMTPCheck.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                dgSMTPCheck.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgSMTPCheck.ColumnHeadersDefaultCellStyle.Font = new Font("Dubai", 10, FontStyle.Bold);

                dgSMTPCheck.BackgroundColor = Color.FromArgb(66, 66, 66);
                dgSMTPCheck.DefaultCellStyle.BackColor = Color.FromArgb(66, 66, 66);
                dgSMTPCheck.ForeColor = Color.FromArgb(229, 229, 229);
                dgSMTPCheck.DefaultCellStyle.Font = new Font("Dubai", 10);

                foreach (DataGridViewRow row in dgSMTPCheck.Rows)
                {
                    row.DefaultCellStyle.BackColor = Color.FromArgb(66, 66, 66);
                    row.DefaultCellStyle.ForeColor = Color.FromArgb(229, 229, 229);
                }

                //List Email
                dgListEmail.EnableHeadersVisualStyles = false;
                dgListEmail.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(50, 50, 50);
                dgListEmail.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                dgListEmail.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgListEmail.ColumnHeadersDefaultCellStyle.Font = new Font("Dubai", 10, FontStyle.Bold);

                dgListEmail.BackgroundColor = Color.FromArgb(66, 66, 66);
                dgListEmail.DefaultCellStyle.BackColor = Color.FromArgb(66, 66, 66);
                dgListEmail.ForeColor = Color.FromArgb(229, 229, 229);
                dgListEmail.DefaultCellStyle.Font = new Font("Dubai", 10);

                foreach (DataGridViewRow row in dgListEmail.Rows)
                {
                    row.DefaultCellStyle.BackColor = Color.FromArgb(66, 66, 66);
                    row.DefaultCellStyle.ForeColor = Color.FromArgb(229, 229, 229);
                }

                //Proxy
                dgProxy.EnableHeadersVisualStyles = false;
                dgProxy.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(50, 50, 50);
                dgProxy.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                dgProxy.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgProxy.ColumnHeadersDefaultCellStyle.Font = new Font("Dubai", 10, FontStyle.Bold);

                dgProxy.BackgroundColor = Color.FromArgb(66, 66, 66);
                dgProxy.DefaultCellStyle.BackColor = Color.FromArgb(66, 66, 66);
                dgProxy.ForeColor = Color.FromArgb(229, 229, 229);
                dgProxy.DefaultCellStyle.Font = new Font("Dubai", 10);

                foreach (DataGridViewRow row in dgProxy.Rows)
                {
                    row.DefaultCellStyle.BackColor = Color.FromArgb(66, 66, 66);
                    row.DefaultCellStyle.ForeColor = Color.FromArgb(229, 229, 229);
                }


                //main labels
                label1.ForeColor = Color.FromArgb(229, 229, 229);
                label15.ForeColor = Color.FromArgb(229, 229, 229);
                label16.ForeColor = Color.FromArgb(229, 229, 229);
                label17.ForeColor = Color.FromArgb(229, 229, 229);
                label18.ForeColor = Color.FromArgb(229, 229, 229);
                label21.ForeColor = Color.FromArgb(229, 229, 229);
                label23.ForeColor = Color.FromArgb(229, 229, 229);
                label24.ForeColor = Color.FromArgb(229, 229, 229);
                label27.ForeColor = Color.FromArgb(229, 229, 229);

                //chart
                chart1.BackColor = Color.FromArgb(80, 80, 80); //the card color on dark
                chart1.BackSecondaryColor = Color.FromArgb(80, 80, 80); //the card color on dark
                chart1.ForeColor = Color.FromArgb(80, 80, 80); //the card color on dark

                chart1.ChartAreas["ChartArea1"].AxisX.LabelStyle.ForeColor = Color.FromArgb(255, 255, 255);
                chart1.ChartAreas["ChartArea1"].AxisY.LabelStyle.ForeColor = Color.FromArgb(255, 255, 255);
                chart1.ChartAreas["ChartArea1"].AxisX.LineColor = Color.FromArgb(255, 255, 255);
                chart1.ChartAreas["ChartArea1"].AxisY.LineColor = Color.FromArgb(255, 255, 255);
                chart1.ChartAreas["ChartArea1"].BackColor = Color.FromArgb(80, 80, 80); //the card color on dark
                chart1.ChartAreas["ChartArea1"].AxisX.MajorGrid.LineColor = Color.FromArgb(255, 255, 255);
                chart1.ChartAreas["ChartArea1"].AxisY.MajorGrid.LineColor = Color.FromArgb(255, 255, 255);



                chart1.BorderlineDashStyle = ChartDashStyle.Solid;
                chart1.BorderlineColor = Color.FromArgb(229, 229, 229);


            }
            else if (materialSkinManager.Theme.ToString() == "LIGHT")
            {
                //dg styles
                //sender
                dgMainSender.EnableHeadersVisualStyles = false;
                dgMainSender.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(242, 242, 242);
                dgMainSender.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(66, 66, 66);
                dgMainSender.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgMainSender.ColumnHeadersDefaultCellStyle.Font = new Font("Dubai", 10, FontStyle.Bold);

                dgMainSender.BackgroundColor = Color.FromArgb(229, 229, 229);
                dgMainSender.DefaultCellStyle.BackColor = Color.FromArgb(229, 229, 229);
                dgMainSender.ForeColor = Color.FromArgb(66, 66, 66);
                dgMainSender.DefaultCellStyle.Font = new Font("Dubai", 10);
                //dgMainSender.BorderStyle = BorderStyle.None;

                foreach (DataGridViewRow row in dgMainSender.Rows)
                {
                    row.DefaultCellStyle.BackColor = Color.FromArgb(229, 229, 229);
                    row.DefaultCellStyle.ForeColor = Color.FromArgb(66, 66, 66);
                }

                //letter
                dgLetters.EnableHeadersVisualStyles = false;
                dgLetters.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(242, 242, 242);
                dgLetters.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(66, 66, 66);
                dgLetters.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgLetters.ColumnHeadersDefaultCellStyle.Font = new Font("Dubai", 10, FontStyle.Bold);

                dgLetters.BackgroundColor = Color.FromArgb(229, 229, 229);
                dgLetters.DefaultCellStyle.BackColor = Color.FromArgb(229, 229, 229);
                dgLetters.ForeColor = Color.FromArgb(66, 66, 66);
                dgLetters.DefaultCellStyle.Font = new Font("Dubai", 10);

                foreach (DataGridViewRow row in dgLetters.Rows)
                {
                    row.DefaultCellStyle.BackColor = Color.FromArgb(229, 229, 229);
                    row.DefaultCellStyle.ForeColor = Color.FromArgb(66, 66, 66);
                }

                //SMTP
                dgSMTP.EnableHeadersVisualStyles = false;
                dgSMTP.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(242, 242, 242);
                dgSMTP.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(66, 66, 66);
                dgSMTP.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgSMTP.ColumnHeadersDefaultCellStyle.Font = new Font("Dubai", 10, FontStyle.Bold);

                dgSMTP.BackgroundColor = Color.FromArgb(229, 229, 229);
                dgSMTP.DefaultCellStyle.BackColor = Color.FromArgb(229, 229, 229);
                dgSMTP.ForeColor = Color.FromArgb(66, 66, 66);
                dgSMTP.DefaultCellStyle.Font = new Font("Dubai", 10);

                foreach (DataGridViewRow row in dgSMTP.Rows)
                {
                    row.DefaultCellStyle.BackColor = Color.FromArgb(229, 229, 229);
                    row.DefaultCellStyle.ForeColor = Color.FromArgb(66, 66, 66);
                }

                //SMTP Check
                dgSMTPCheck.EnableHeadersVisualStyles = false;
                dgSMTPCheck.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(242, 242, 242);
                dgSMTPCheck.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(66, 66, 66);
                dgSMTPCheck.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgSMTPCheck.ColumnHeadersDefaultCellStyle.Font = new Font("Dubai", 10, FontStyle.Bold);

                dgSMTPCheck.BackgroundColor = Color.FromArgb(229, 229, 229);
                dgSMTPCheck.DefaultCellStyle.BackColor = Color.FromArgb(229, 229, 229);
                dgSMTPCheck.ForeColor = Color.FromArgb(66, 66, 66);
                dgSMTPCheck.DefaultCellStyle.Font = new Font("Dubai", 10);

                foreach (DataGridViewRow row in dgSMTPCheck.Rows)
                {
                    row.DefaultCellStyle.BackColor = Color.FromArgb(229, 229, 229);
                    row.DefaultCellStyle.ForeColor = Color.FromArgb(66, 66, 66);
                }

                //List Email
                dgListEmail.EnableHeadersVisualStyles = false;
                dgListEmail.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(242, 242, 242);
                dgListEmail.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(66, 66, 66);
                dgListEmail.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgListEmail.ColumnHeadersDefaultCellStyle.Font = new Font("Dubai", 10, FontStyle.Bold);

                dgListEmail.BackgroundColor = Color.FromArgb(229, 229, 229);
                dgListEmail.DefaultCellStyle.BackColor = Color.FromArgb(229, 229, 229);
                dgListEmail.ForeColor = Color.FromArgb(66, 66, 66);
                dgListEmail.DefaultCellStyle.Font = new Font("Dubai", 10);

                foreach (DataGridViewRow row in dgListEmail.Rows)
                {
                    row.DefaultCellStyle.BackColor = Color.FromArgb(229, 229, 229);
                    row.DefaultCellStyle.ForeColor = Color.FromArgb(66, 66, 66);
                }

                //Proxy
                dgProxy.EnableHeadersVisualStyles = false;
                dgProxy.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(242, 242, 242);
                dgProxy.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(66, 66, 66);
                dgProxy.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgProxy.ColumnHeadersDefaultCellStyle.Font = new Font("Dubai", 10, FontStyle.Bold);

                dgProxy.BackgroundColor = Color.FromArgb(229, 229, 229);
                dgProxy.DefaultCellStyle.BackColor = Color.FromArgb(229, 229, 229);
                dgProxy.ForeColor = Color.FromArgb(66, 66, 66);
                dgProxy.DefaultCellStyle.Font = new Font("Dubai", 10);

                foreach (DataGridViewRow row in dgProxy.Rows)
                {
                    row.DefaultCellStyle.BackColor = Color.FromArgb(229, 229, 229);
                    row.DefaultCellStyle.ForeColor = Color.FromArgb(66, 66, 66);
                }

                //chart
                chart1.BackColor = Color.FromArgb(255, 255, 255); //the card color on white
                chart1.BackSecondaryColor = Color.FromArgb(255, 255, 255); //the card color on white
                chart1.ForeColor = Color.FromArgb(255, 255, 255); //the card color on white

                chart1.ChartAreas["ChartArea1"].AxisX.LabelStyle.ForeColor = Color.FromArgb(80, 80, 80);
                chart1.ChartAreas["ChartArea1"].AxisY.LabelStyle.ForeColor = Color.FromArgb(80, 80, 80);
                chart1.ChartAreas["ChartArea1"].AxisX.LineColor = Color.FromArgb(80, 80, 80);
                chart1.ChartAreas["ChartArea1"].AxisY.LineColor = Color.FromArgb(80, 80, 80);
                chart1.ChartAreas["ChartArea1"].BackColor = Color.FromArgb(255, 255, 255); //the card color on dark
                chart1.ChartAreas["ChartArea1"].AxisX.MajorGrid.LineColor = Color.FromArgb(80, 80, 80);
                chart1.ChartAreas["ChartArea1"].AxisY.MajorGrid.LineColor = Color.FromArgb(80, 80, 80);

                chart1.BorderlineDashStyle = ChartDashStyle.Solid;
                chart1.BorderlineColor = Color.FromArgb(66, 66, 66);

                //Main labels
                label1.ForeColor = Color.FromArgb(66, 66, 66);
                label15.ForeColor = Color.FromArgb(66, 66, 66);
                label16.ForeColor = Color.FromArgb(66, 66, 66);
                label17.ForeColor = Color.FromArgb(66, 66, 66);
                label18.ForeColor = Color.FromArgb(66, 66, 66);
                label21.ForeColor = Color.FromArgb(66, 66, 66);
                label23.ForeColor = Color.FromArgb(66, 66, 66);
                label24.ForeColor = Color.FromArgb(66, 66, 66);
                label27.ForeColor = Color.FromArgb(66, 66, 66);


            }

        }


        private void AddMail_Sender(object sender, EventArgs e)

        {
            var myForm = new addMailRecepient(this);
            myForm.ShowDialog();
            updateControls();

        }


        private void btnMailList_Click(object sender, EventArgs e)
        {
            var myForm = new addMailRecepient(this);
            myForm.ShowDialog();
            updateControls();
        }

        private void btnAddSMTP_Click(object sender, EventArgs e)
        {
            var myForm = new addSMTP(this);
            myForm.ShowDialog();
            updateControls();
        }

        private void btnProxyAdd_Click(object sender, EventArgs e)
        {
            var myForm = new addProxy(this);
            myForm.ShowDialog();
            updateControls();
        }

        private void DeleteSelected_Sender(object sender, EventArgs e)

        {

            dgMainSender.ClearSelection();
        }

        private void ClrAll_Sender(object sender, EventArgs e)
        {

            dgMainSender.Rows.Clear();
            //dgMainSender.Rows.RemoveAt(0);
            dgMainSender.Refresh();


        }

        private void Cancel_Sender(object sender, EventArgs e)

        {

            textBoxContextMenuStrip1.Close();

        }

        private void updateColor()
        {
            ////These are just example color schemes
            //switch (colorSchemeIndex)
            //{
            //    case 0:
            //        materialSkinManager.ColorScheme = new ColorScheme(
            //            materialSkinManager.Theme == MaterialSkinManager.Themes.DARK ? Primary.Teal500 : Primary.Indigo500,
            //            materialSkinManager.Theme == MaterialSkinManager.Themes.DARK ? Primary.Teal700 : Primary.Indigo700,
            //            materialSkinManager.Theme == MaterialSkinManager.Themes.DARK ? Primary.Teal200 : Primary.Indigo100,
            //            Accent.Pink200,
            //            TextShade.WHITE);
            //        break;

            //    case 1:
            //        materialSkinManager.ColorScheme = new ColorScheme(
            //            Primary.Green600,
            //            Primary.Green700,
            //            Primary.Green200,
            //            Accent.Red100,
            //            TextShade.WHITE);
            //        break;

            //    case 2:
            //        materialSkinManager.ColorScheme = new ColorScheme(
            //            Primary.BlueGrey800,
            //            Primary.BlueGrey900,
            //            Primary.BlueGrey500,
            //            Accent.LightBlue200,
            //            TextShade.WHITE);
            //        break;
            //}
            //Invalidate();

        }

        private void switchBtnTheme_CheckedChanged_1(object sender, EventArgs e)
        {
            materialSkinManager.Theme = materialSkinManager.Theme ==
                MaterialSkinManager.Themes.DARK ? MaterialSkinManager.Themes.LIGHT : MaterialSkinManager.Themes.DARK;
            if (materialSkinManager.Theme.ToString() == "LIGHT")
            {
                switchBtnTheme.Text = "Dark";
            }
            else if (materialSkinManager.Theme.ToString() == "DARK")
            {
                switchBtnTheme.Text = "Light";
            }

            //updateColor();
            updateControls();

        }

        private void materialSwitch1_CheckedChanged(object sender, EventArgs e)
        {
            materialSkinManager.Theme = materialSkinManager.Theme ==
                MaterialSkinManager.Themes.DARK ? MaterialSkinManager.Themes.LIGHT : MaterialSkinManager.Themes.DARK;
            if (materialSkinManager.Theme.ToString() == "LIGHT")
            {
                btn_them_lettermaterialSwitch1.Text = "Dark";
            }
            else if (materialSkinManager.Theme.ToString() == "DARK")
            {
                btn_them_lettermaterialSwitch1.Text = "Light";
            }

            //updateColor();
            updateControls();

        }

        private void materialSwitch1_CheckedChanged_1(object sender, EventArgs e)
        {
            materialSkinManager.Theme = materialSkinManager.Theme ==
                MaterialSkinManager.Themes.DARK ? MaterialSkinManager.Themes.LIGHT : MaterialSkinManager.Themes.DARK;
            if (materialSkinManager.Theme.ToString() == "LIGHT")
            {
                materialSwitch1.Text = "Dark";
            }
            else if (materialSkinManager.Theme.ToString() == "DARK")
            {
                materialSwitch1.Text = "Light";
            }

            //updateColor();
            updateControls();
        }

        private void materialSwitch2_CheckedChanged(object sender, EventArgs e)
        {
            materialSkinManager.Theme = materialSkinManager.Theme ==
               MaterialSkinManager.Themes.DARK ? MaterialSkinManager.Themes.LIGHT : MaterialSkinManager.Themes.DARK;
            if (materialSkinManager.Theme.ToString() == "LIGHT")
            {
                materialSwitch2.Text = "Dark";
            }
            else if (materialSkinManager.Theme.ToString() == "DARK")
            {
                materialSwitch2.Text = "Light";
            }

            //updateColor();
            updateControls();
        }

        private void materialSwitch3_CheckedChanged(object sender, EventArgs e)
        {
            materialSkinManager.Theme = materialSkinManager.Theme ==
               MaterialSkinManager.Themes.DARK ? MaterialSkinManager.Themes.LIGHT : MaterialSkinManager.Themes.DARK;
            if (materialSkinManager.Theme.ToString() == "LIGHT")
            {
                materialSwitch3.Text = "Dark";
            }
            else if (materialSkinManager.Theme.ToString() == "DARK")
            {
                materialSwitch3.Text = "Light";
            }

            //updateColor();
            updateControls();
        }

        private void materialSwitch4_CheckedChanged(object sender, EventArgs e)
        {
            materialSkinManager.Theme = materialSkinManager.Theme ==
              MaterialSkinManager.Themes.DARK ? MaterialSkinManager.Themes.LIGHT : MaterialSkinManager.Themes.DARK;
            if (materialSkinManager.Theme.ToString() == "LIGHT")
            {
                materialSwitch4.Text = "Dark";
            }
            else if (materialSkinManager.Theme.ToString() == "DARK")
            {
                materialSwitch4.Text = "Light";
            }

            //updateColor();
            updateControls();
        }

        private void materialSwitch5_CheckedChanged(object sender, EventArgs e)
        {
            materialSkinManager.Theme = materialSkinManager.Theme ==
              MaterialSkinManager.Themes.DARK ? MaterialSkinManager.Themes.LIGHT : MaterialSkinManager.Themes.DARK;
            if (materialSkinManager.Theme.ToString() == "LIGHT")
            {
                materialSwitch5.Text = "Dark";
            }
            else if (materialSkinManager.Theme.ToString() == "DARK")
            {
                materialSwitch5.Text = "Light";
            }

            //updateColor();
            updateControls();
        }

        private void materialSwitch6_CheckedChanged(object sender, EventArgs e)
        {
            materialSkinManager.Theme = materialSkinManager.Theme ==
              MaterialSkinManager.Themes.DARK ? MaterialSkinManager.Themes.LIGHT : MaterialSkinManager.Themes.DARK;
            if (materialSkinManager.Theme.ToString() == "LIGHT")
            {
                materialSwitch6.Text = "Dark";
            }
            else if (materialSkinManager.Theme.ToString() == "DARK")
            {
                materialSwitch6.Text = "Light";
            }

            //updateColor();
            updateControls();
        }

        private void materialSwitch7_CheckedChanged(object sender, EventArgs e)
        {
            materialSkinManager.Theme = materialSkinManager.Theme ==
             MaterialSkinManager.Themes.DARK ? MaterialSkinManager.Themes.LIGHT : MaterialSkinManager.Themes.DARK;
            if (materialSkinManager.Theme.ToString() == "LIGHT")
            {
                materialSwitch7.Text = "Dark";
            }
            else if (materialSkinManager.Theme.ToString() == "DARK")
            {
                materialSwitch7.Text = "Light";
            }

            //updateColor();
            updateControls();


        }

        private void materialSwitch8_CheckedChanged(object sender, EventArgs e)
        {
            materialSkinManager.Theme = materialSkinManager.Theme ==
             MaterialSkinManager.Themes.DARK ? MaterialSkinManager.Themes.LIGHT : MaterialSkinManager.Themes.DARK;
            if (materialSkinManager.Theme.ToString() == "LIGHT")
            {
                materialSwitch8.Text = "Dark";
            }
            else if (materialSkinManager.Theme.ToString() == "DARK")
            {
                materialSwitch8.Text = "Light";
            }

            //updateColor();
            updateControls();

        }

        private void tbPageSender_Enter(object sender, EventArgs e)
        {
            if (materialSkinManager.Theme.ToString() == "LIGHT")
            {
                switchBtnTheme.Text = "Dark";
            }
            else if (materialSkinManager.Theme.ToString() == "DARK")
            {
                switchBtnTheme.Text = "Light";
            }


        }

        private void txSubject_TextChanged(object sender, EventArgs e)
        {
            fromSubject = txSubject.Text.ToString();

            for (int i = 0; i < dgMainSender.Rows.Count - 1; i++)
            {
                dgMainSender[0, i].Value = fromSubject.ToString();
            }
        }

        private void txFromMail_TextChanged(object sender, EventArgs e)
        {
            fromEmailSender = txFromMail.Text.ToString();

            for (int i = 0; i < dgMainSender.Rows.Count - 1; i++)
            {
                dgMainSender[1, i].Value = fromEmailSender.ToString();
            }
        }

        private void txFromName_TextChanged(object sender, EventArgs e)
        {
            fromNameSender = txFromName.Text.ToString();

            for (int i = 0; i < dgMainSender.Rows.Count - 1; i++)
            {
                dgMainSender[2, i].Value = fromNameSender.ToString();
            }
        }

        public static string sendEmail(string emailAdd, string pass, string toAdd,
            string subjectAdd, string body, string dName, string SMTPhost, string SMTPPort)
        {
            string status = "Not Sent";

            // Sending Email
            try
            {
                MailMessage Email = new MailMessage();
                Email.From = new MailAddress(emailAdd.Trim().TrimEnd().TrimStart(),
                    dName.Trim().TrimEnd().TrimStart()); //adding from email and the name
                Email.To.Add(toAdd.Trim().TrimEnd().TrimStart()); //adding to email
                Email.Subject = subjectAdd.Trim().TrimEnd().TrimStart(); //adding subject
                Email.BodyEncoding = System.Text.Encoding.UTF8; //adding encoding
                Email.SubjectEncoding = System.Text.Encoding.Default; //adding subject encoding
                Email.IsBodyHtml = true;
                Email.Body = body.ToString(); //adding body

                //SMTP settings
                //SmtpClient EmailClient = new SmtpClient("smtp.gmail.com", 587);
                SmtpClient EmailClient = new SmtpClient(SMTPhost, Convert.ToInt32(SMTPPort));
                EmailClient.EnableSsl = true; //setting SSL settings
                EmailClient.Credentials = new System.Net.NetworkCredential(emailAdd, pass);
                EmailClient.Timeout = 120000; // 90 Seconds
                EmailClient.Send(Email);
            }
            catch (SmtpException ex)
            {
                return status;
            }
            status = "Sent";

            return status;
        }

        public void updateDGSender()
        {
            if (senderEmails.Count() > 0)
            {

                senderEmails = senderEmails.Where(x => !string.IsNullOrEmpty(x)).ToArray();

                for (int i = 0; i <= senderEmails.Count() - 1; i++)
                {
                    senderEmails[i] = senderEmails[i].Trim().TrimEnd().TrimStart().ToString();
                }


                for (int i = 0; i <= senderEmails.Count() - 1; i++)
                {
                    dgMainSender.Rows.Add("", "", "", letterName, senderEmails[i].Trim().ToString(),
                        "Ready to be Sent", "NA");
                }

                btnStart.Enabled = true;
                dgMainSender.ClearSelection();
                updateControls();

            }

        }

        public void updateDGProxy()
        {

            dgProxy.Rows.Add(proxyHost, proxyPort, proxyUser, "********", proxyType);
            dgProxy.ClearSelection();
            updateControls();

        }

        public void updateDGSMTP()
        {

            dgSMTP.Rows.Add(smtpHost, smtpPort, smtpSSL, smtpUser, "********", smtpStatus, smtpLimit);
            dgSMTP.ClearSelection();
            updateControls();

        }

        public void updateDGSMTPCheck()
        {

            dgSMTPCheck.Rows.Add(smtpHost, smtpPort, smtpSSL, smtpUser, "********", smtpStatus, smtpLimit);
            dgSMTPCheck.ClearSelection();
            updateControls();

        }

        public void updateDGLetter()
        {
            dgLetters.Rows.Add(letterName, true, letterAttach, letterBody, true);
            dgLetters.ClearSelection();
            updateControls();

        }

        public void updateDGList()
        {
            dgListEmail.Rows.Add(glistName, glistCount);
            dgListEmail.ClearSelection();
            updateControls();
        }


        private void btnImportLetter_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "All Files (*.*)|*.*";
            dialog.FilterIndex = 1;
            dialog.Multiselect = false;
            dialog.InitialDirectory = parentDirectory;


            string[] currentData = null;


            letterName = null;
            letterAttach = null;
            letterBody = null;


            if (dialog.ShowDialog() == DialogResult.OK)
            {

                letterName = dialog.FileName;
                currentData = File.ReadAllLines(letterName);

                if (currentData != null)
                {
                    for (int i = 0; i < currentData.Count() - 1; i++)
                    {

                        letterBody += currentData[i] + Environment.NewLine;

                    }

                    int pFrom = letterName.IndexOf("Letters\\") + "Letters\\".Length;
                    int pTo = letterName.LastIndexOf(".");


                    letterName = letterName.Substring(pFrom, pTo - pFrom);
                    letterBody.ToString().TrimEnd(Environment.NewLine.ToCharArray());
                    letterAttach = currentData[currentData.Count() - 1].Substring(18);

                    updateDGLetter();
                    updateControls();

                }
            }
        }

        private void btnAddLetter_Click(object sender, EventArgs e)
        {
            var myForm = new addLetter(this);
            myForm.ShowDialog();
        }

        private void btnImportSMTP_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "All Files (*.*)|*.*";
            dialog.FilterIndex = 1;
            dialog.Multiselect = false;
            dialog.InitialDirectory = parentDirectory;


            string[] currentData = null;


            smtpHost = null;
            smtpPort = null;
            smtpSSL = null;
            smtpUser = null;
            smtpPass = null;
            smtpLimit = null;
            smtpStatus = null;

            string currentBody = "";

            if (dialog.ShowDialog() == DialogResult.OK)
            {

                smtpHost = dialog.FileName;
                currentData = File.ReadAllLines(smtpHost);

                string[] tempDataSMTP = new string[7];

                if (currentData != null)
                {

                    for (int i = 0; i < currentData.Count(); i++)
                    {

                        currentBody += currentData[i] + ";";
                        tempDataSMTP[i] = currentData[i];

                    }

                    smtpHost = tempDataSMTP[0].Substring(tempDataSMTP[0].IndexOf("=") + 1);
                    smtpPort = tempDataSMTP[1].Substring(tempDataSMTP[1].IndexOf("=") + 1);
                    smtpSSL = tempDataSMTP[2].Substring(tempDataSMTP[2].IndexOf("=") + 1);
                    smtpUser = tempDataSMTP[3].Substring(tempDataSMTP[3].IndexOf("=") + 1);
                    smtpPass = tempDataSMTP[4].Substring(tempDataSMTP[4].IndexOf("=") + 1);
                    smtpLimit = tempDataSMTP[5].Substring(tempDataSMTP[5].IndexOf("=") + 1);
                    smtpStatus = tempDataSMTP[6].Substring(tempDataSMTP[6].IndexOf("=") + 1);


                    updateDGSMTP();

                }
            }
        }

        private void btnSMTPImporter_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "All Files (*.*)|*.*";
            dialog.FilterIndex = 1;
            dialog.Multiselect = false;
            dialog.InitialDirectory = parentDirectory;


            string[] currentData = null;


            smtpHost = null;
            smtpPort = null;
            smtpSSL = null;
            smtpUser = null;
            smtpPass = null;
            smtpLimit = null;
            smtpStatus = null;

            string currentBody = "";

            if (dialog.ShowDialog() == DialogResult.OK)
            {

                smtpHost = dialog.FileName;
                currentData = File.ReadAllLines(smtpHost);

                string[] tempDataSMTP = new string[7];

                if (currentData != null)
                {

                    for (int i = 0; i < currentData.Count(); i++)
                    {

                        currentBody += currentData[i] + ";";
                        tempDataSMTP[i] = currentData[i];

                    }

                    smtpHost = tempDataSMTP[0].Substring(tempDataSMTP[0].IndexOf("=") + 1);
                    smtpPort = tempDataSMTP[1].Substring(tempDataSMTP[1].IndexOf("=") + 1);
                    smtpSSL = tempDataSMTP[2].Substring(tempDataSMTP[2].IndexOf("=") + 1);
                    smtpUser = tempDataSMTP[3].Substring(tempDataSMTP[3].IndexOf("=") + 1);
                    smtpPass = tempDataSMTP[4].Substring(tempDataSMTP[4].IndexOf("=") + 1);
                    smtpLimit = tempDataSMTP[5].Substring(tempDataSMTP[5].IndexOf("=") + 1);
                    smtpStatus = tempDataSMTP[6].Substring(tempDataSMTP[6].IndexOf("=") + 1);


                    updateDGSMTPCheck();

                }
            }
        }

        private void btnSMTPChecker_Click(object sender, EventArgs e)
        {
            //Add SMTP Check Code here
        }

        private void btnImportList_Click(object sender, EventArgs e)
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
                    rtEmailList.Text = sb.ToString();



                    int pFrom = glistName.IndexOf("Lists\\") + "Lists\\".Length;
                    int pTo = glistName.LastIndexOf(".");


                    glistName = glistName.Substring(pFrom, pTo - pFrom);
                    tbListName.Text = glistName;

                    rtEmailList.Lines = rtEmailList.Lines.Take(rtEmailList.Lines.Length - 1).ToArray();

                    glistCount = currentData.Count().ToString();
                    updateDGList();

                }
            }
        }

        private void btnSaveEmails_Click(object sender, EventArgs e)
        {
            System.IO.Directory.CreateDirectory(parentDirectory + "\\Lists");

            string listName = tbListName.Text.ToString();
            string listValues = rtEmailList.Text.ToString();

            if (listName == "" || listValues.Count() < 0)
            {
                MessageBox.Show("Kindly Fill Out List Name and/or Emails", "Error");

            }
            else
            {
                if (File.Exists(parentDirectory + "\\Lists\\" + listName.ToString() + ".txt"))
                {
                    File.Delete(parentDirectory + "\\Lists\\" + listName.ToString() + ".txt");

                }

                File.Create(parentDirectory + "\\Lists\\" + listName.ToString() + ".txt").Close();
                File.WriteAllText(parentDirectory + "\\Lists\\" + listName.ToString() + ".txt", listValues);



                DataGridViewRow row = (DataGridViewRow)dgListEmail.Rows[0].Clone();
                row.Cells[0].Value = listName;
                row.Cells[1].Value = rtEmailList.Lines.Count();
                dgListEmail.Rows.Add(row);

                rtTotalList.Text = rtEmailList.Lines.Count().ToString();

                rtEmailList.Clear();
                tbListName.Clear();

            }
        }

        private void cbOn_CheckedChanged(object sender, EventArgs e)
        {
            if (cbOn.Checked == true)
            {
                cbOff.Checked = false;


                //aDDING Chart tracking
                //chart1.Series["Series1"].Points.AddXY("Ajay", "10000");
                //chart1.Series["Series1"].Points.AddXY("Ramesh", "8000");
                //chart1.Series["Series1"].Points.AddXY("Ankit", "7000");
                //chart1.Series["Series1"].Points.AddXY("Gurmeet", "10000");
                //chart1.Series["Series1"].Points.AddXY("Suresh", "8500");
                //chart1.Titles.Add("Tracking Emails");

                var series = new Series("Email Tracking");
                series.ChartType = SeriesChartType.Line;


                // Frist parameter is X-Axis and Second is Collection of Y- Axis
                series.Points.DataBindXY(new[] { 2001, 2002, 2003, 2004 }, new[] { 100, 200, 90, 150 });
                chart1.Series.Clear();
                chart1.Series.Add(series);
                chart1.Series["Email Tracking"].Color = Color.FromArgb(211, 47, 47);
                chart1.Series["Email Tracking"].BorderWidth = 5;

                updateControls();

            }
            else if (cbOn.Checked == false)
            {
                chart1.Series.Clear();
            }
        }

        //temp class

        private void cbOff_CheckedChanged(object sender, EventArgs e)
        {
            if (cbOff.Checked == true)
            {
                cbOn.Checked = false;
                chart1.Series.Clear();
            }
        }

        private void rtEmailList_TextChanged(object sender, EventArgs e)
        {
            rtTotalList.Text = rtEmailList.Lines.Count().ToString();
        }

        private void rtTotalList_TextChanged(object sender, EventArgs e)
        {
            rtTotalList.Text = rtEmailList.Lines.Count().ToString();
        }

        private void btnImportProxy_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "All Files (*.*)|*.*";
            dialog.FilterIndex = 1;
            dialog.Multiselect = false;
            dialog.InitialDirectory = parentDirectory;


            string[] currentData = null;


            proxyHost = null;
            proxyPort = null;
            proxyUser = null;
            proxyPass = null;
            proxyType = null;

            string currentBody = "";

            if (dialog.ShowDialog() == DialogResult.OK)
            {

                proxyHost = dialog.FileName;
                currentData = File.ReadAllLines(proxyHost);

                string[] tempDataProxy = new string[5];

                if (currentData != null)
                {

                    for (int i = 0; i < currentData.Count(); i++)
                    {

                        currentBody += currentData[i] + ";";
                        tempDataProxy[i] = currentData[i];

                    }

                    proxyHost = tempDataProxy[0].Substring(tempDataProxy[0].IndexOf("=") + 1);
                    proxyPort = tempDataProxy[1].Substring(tempDataProxy[1].IndexOf("=") + 1);
                    proxyUser = tempDataProxy[2].Substring(tempDataProxy[2].IndexOf("=") + 1);
                    proxyPass = tempDataProxy[3].Substring(tempDataProxy[3].IndexOf("=") + 1);
                    proxyType = tempDataProxy[4].Substring(tempDataProxy[4].IndexOf("=") + 1);


                    updateDGProxy();

                }
            }
        }

        private void tbPageTrack_Enter(object sender, EventArgs e)
        {
            cbOff.Checked = true;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (!this.bw.IsBusy)
            {
                this.bw.RunWorkerAsync();
                this.btnStart.Enabled = false;
            }


            //if (smtpHost is null || letterName is null)
            //{
            //    MaterialMessageBox.Show("Kindly provide a valid \"Letter\" and \"SMTP Host.\"", "Missing Parameters");
            //    return;
            //}


            //if (senderEmails is null)
            //{
            //    MaterialMessageBox.Show("Kindly provide a valid \"Email List.\"", "Missing Parameters");
            //    return;
            //}

            //senderEmails = senderEmails.Where(x => !string.IsNullOrEmpty(x)).ToArray();

            //for (int i = 0; i <= senderEmails.Count() - 1; i++)
            //{
            //    senderEmails[i] = senderEmails[i].Trim().TrimEnd().TrimStart().ToString();
            //}


            //string finalResult = string.Empty;

            //fromEmailSender = txFromMail.Text.ToString();
            //fromNameSender = txFromName.Text.ToString();
            //fromSubject = txSubject.Text.ToString();

            //if (fromEmailSender != string.Empty || fromNameSender != string.Empty || fromSubject != string.Empty)
            //{

            //}
            //else
            //{
            //    MaterialMessageBox.Show("Kindly provide a valid \"From Name, \" \"Sender Email,\" and \"Subject.\"", "Missing Parameters");
            //    return;
            //}

            //lbLetterCount.Text = "1";
            //lbSMTPCount.Text = "1";
            //lbHeaderCount.Text = "1";
            //lbAllProgress.Text = "0";

            //int allProgressEmails = 0;
            //int sentEmails = 0;
            //int failedEmails = 0;

            //int countDG = dgMainSender.Rows.Count - 1;

            //btnStart.Enabled = false;

            //for (int counter = 0; counter <= countDG; counter++) //fix it
            //{

            //    finalResult = sendEmail(fromEmailSender.ToString().Trim(),
            //        smtpPass.ToString().Trim(),
            //        dgMainSender[4, counter].Value.ToString().Trim(),
            //        fromSubject.ToString().Trim(),
            //        letterBody.ToString().Trim(),
            //        fromNameSender.ToString().Trim(),
            //        smtpHost.ToString().Trim(),
            //        smtpPort.ToString().Trim());

            //    if (finalResult == "Sent")
            //    {
            //        sentEmails += 1;
            //        lbSent.Text = sentEmails.ToString();
            //        dgMainSender[6, counter].Value = "Sent";
            //    }
            //    else
            //    {
            //        failedEmails += 1;
            //        lbFailed.Text = failedEmails.ToString();
            //        dgMainSender[6, counter].Value = "Failed";
            //    }

            //    //at end


            //    allProgressEmails += 1;
            //    lbAllProgress.Text = allProgressEmails.ToString();

            //}

            //btnStart.Enabled = true;
        }

        private void sendEmailFunc()
        {

        }

        private void txSubject_TextChanged_1(object sender, EventArgs e)
        {
            fromSubject = txSubject.Text.ToString();

            for (int i = 0; i <= dgMainSender.Rows.Count - 1; i++)
            {
                dgMainSender[0, i].Value = fromSubject.ToString();
            }
        }

        private void txFromMail_TextChanged_1(object sender, EventArgs e)
        {
            fromEmailSender = txFromMail.Text.ToString();

            for (int i = 0; i <= dgMainSender.Rows.Count - 1; i++)
            {
                dgMainSender[1, i].Value = fromEmailSender.ToString();
            }
        }

        private void txFromName_TextChanged_1(object sender, EventArgs e)
        {
            fromNameSender = txFromName.Text.ToString();

            for (int i = 0; i <= dgMainSender.Rows.Count - 1; i++)
            {
                dgMainSender[2, i].Value = fromNameSender.ToString();
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            if (this.bw.IsBusy)
            {
                if (this.bw.WorkerSupportsCancellation == true)
                {
                    this.bw.CancelAsync();
                    btnStart.Enabled = true;
                }

            }
        }









        //Ending
    }
}
