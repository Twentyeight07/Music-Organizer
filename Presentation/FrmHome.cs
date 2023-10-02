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

namespace Presentation
{
    public partial class FrmHome : Form
    {
        public FrmHome()
        {
            InitializeComponent();
            
        }

        private void FrmHome_Load(object sender, EventArgs e)
        {
            Message("Attention: This program organizes music using an 'x -' pattern, where 'x' represents a number. If your music is already organized by numbers and you want to add new music, the program will use the highest existing number and continue from there.", "Information");
        }

        #region "Variables"
        int numeration = 0;
        FileInfo[] folderFiles;
        #endregion
        #region "Methods"
        private void CheckFilesNum()
        {
            if (lblInformation.Text == string.Empty) return;

            DirectoryInfo di = new DirectoryInfo(@lblInformation.Text);


            foreach (FileInfo fi in di.GetFiles())
            {
                string fileName = fi.Name;
                int blank = fileName.IndexOf(" ");
                int dot = fileName.IndexOf(".");
                string haveNumbers;

                if(blank != -1)
                {
                    haveNumbers = fileName.Substring(0,blank);
                }
                else
                {
                    haveNumbers = fileName.Substring(0, dot);
                }

                if (int.TryParse(haveNumbers, out int number))
                {
                    if (number > numeration)
                    {
                        numeration = number;
                    }
                }
            }
            
        }

        private void GetFolderPath()
        {
            string folderPath = string.Empty;

            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                folderPath = folderBrowserDialog.SelectedPath;
            }
            else return;

            lblInformation.Text = folderPath;

            CheckFilesNum();

        }

        private void GetFiles(string path)
        {
            DirectoryInfo di = new DirectoryInfo(@path);
            List<string> allowedExtensions = new List<string> { ".mp3", ".flac", ".wav", ".wma"};

            try
            {
                
                lbFiles.Items.Clear();
                folderFiles = di.GetFiles()
                    .Where(fi => allowedExtensions.Contains(fi.Extension))
                    .ToArray();

                foreach (FileInfo fi in folderFiles)
                {
                    lbFiles.Items.Add(fi.Name);
                }

                btnOrganize.Enabled = folderFiles.Length > 0;
            }
            catch (Exception)
            {
                return;
            }
        }

        public void OrganizeFiles()
        {
            try
            {
                /* No files, return */
                if (folderFiles.Length <= 0) return;

                string newDirectoryPath = @lblInformation.Text + "\\Organized Music";
                /* With this ternary operation we can evaluate if there's a file with a numeration present on the music directory. If there's a file with numeration, we continue numeration from there  */
                int loop = numeration > 0 ? (numeration + 1) : 1;

                /* if folder doesn't exists, we create it */
                if (!Directory.Exists(newDirectoryPath))
                {
                    DirectoryInfo nd = Directory.CreateDirectory(newDirectoryPath);
                }

                foreach (FileInfo fi in folderFiles)
                {
                    string fileName = fi.Name;
                    int blank = fileName.IndexOf(" ");
                    int dot = fileName.IndexOf(".");
                    string haveNumbers;

                    if (blank != -1)
                    {
                        haveNumbers = fileName.Substring(0, blank);
                    }
                    else
                    {
                        haveNumbers = fileName.Substring(0, dot);
                    }

                    if (int.TryParse(haveNumbers, out int number))
                    {
                    /* if the file have already a numeration we just move it into the folder with organized music */
                        fi.MoveTo(newDirectoryPath + "\\" + fileName);
                    }
                    else
                    {
                    /* if not, we add the numeration and move it into folder with organized music */
                    string newFileName = "\\"+ loop +" - " + fi.Name;

                    fi.MoveTo(newDirectoryPath + newFileName);

                    loop++;

                    }

                    /* clear items on the list box */
                    lbFiles.Items.Clear();
                    /* clear files on the folderFiles variable */
                    folderFiles = new FileInfo[0];
                    /* we disable button to organize music because we already organized it */
                    btnOrganize.Enabled = false;
                }

                Message("Music organized successfully! Your music is on the same directory, into the 'Organized Music' folder", "Success!");
            }
            catch (Exception ex)
            {
                ErrorMessage("An error has occurred: " + ex.Message, "Error");

                return;
            }

        }

        public void Message(string message, string caption)
        {
            MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void ErrorMessage(string message, string caption)
        {
            MessageBox.Show(message, caption, MessageBoxButtons.OK,MessageBoxIcon.Error);
        }

        #endregion

        private void BtnSelectFolder_Click(object sender, EventArgs e)
        {
            GetFolderPath();
            GetFiles(lblInformation.Text);
        }

        private void btnOrganize_Click(object sender, EventArgs e)
        {
            OrganizeFiles();
        }

    }
}
