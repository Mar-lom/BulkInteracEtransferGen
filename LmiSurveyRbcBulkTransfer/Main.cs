using LmiBankTransfers;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LmiSurveyRbcBulkTransfer
{
    public partial class LmiSurveyRbcETransfer : Form
    {

        // Dear Programmer:
        //
        //2022-07-06
        //I developed this program in order to make it easier to format contact information into
        //XML to be able to upload RBC interac for group e-transfers. This was developed during my co-op at AETs 
        // My name is Marco Lombardo are I am a first year Computer Programming student at at Confederaion College.
        //This is my firs real program... Hope you enjoy and doesnt break :).
        public LmiSurveyRbcETransfer()
        {
            InitializeComponent();

        }
        private void fName_TextChanged(object sender, EventArgs e)
        {

        }

        public void addUserBtn_Click(object sender, EventArgs e)
        {

            Global.firstNamesNew.Add(fName.Text);
            Global.lastNameNew.Add(lNameTextBox.Text);
            Global.emailNew.Add(emailLabelTextBox.Text);

            if (fName.Text != string.Empty && lNameTextBox.Text != string.Empty && emailLabelTextBox.Text != string.Empty)
            {
                // add users to listbox
                userListBox.Items.Add(fName.Text);

                //  clear text box after information is entered
                emailLabelTextBox.Clear();
                fName.Clear();
                lNameTextBox.Clear();

                // add to user count
                Global.userCount++;
            }
            else
            {
                MessageBox.Show("Please Fills in all Information");
            }
        }

        private void transferInfoButton_Click(object sender, EventArgs e)
        {

            if (userListBox.Items.Count != 0)
            {

                transactionInfo f2 = new transactionInfo();
                f2.ShowDialog();
                Close();
            }
            else
            {
                MessageBox.Show("Error: You must enter at least 1 Payee");
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (userListBox.SelectedIndex < 0)
            {
                MessageBox.Show("Error: No User Selected!");
            }
            else
            {
                Global.firstNamesNew.Remove(userListBox.SelectedItem.ToString());
                Global.lastNameNew.Remove(userListBox.SelectedItem.ToString());
                Global.emailNew.Remove(userListBox.SelectedItem.ToString());
                userListBox.Items.Remove(userListBox.SelectedItem);
                Global.userCount--;
            }

        }

        private void fName_TextChanged_1(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (!Char.IsSeparator(c))
            {
                e.Handled = true;
            }
        }

        private void quickViewBtn_Click(object sender, EventArgs e)
        {
            userViewForm f3 = new userViewForm();
            f3.ShowDialog();
        }

        private void about_Click(object sender, EventArgs e)
        {
            About a1 = new About();
            a1.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void LmiSurveyRbcETransfer_Load(object sender, EventArgs e)
        {

        }
    }

    public static class Global
    {

        public static List<string> firstNamesNew = new List<string>();
        public static List<string> lastNameNew = new List<string>();
        public static List<string> emailNew = new List<string>();
        public static int userCount = 0;
        public static int acctualUserCount = 0;
    }
}
