using System;
using System.Windows.Forms;

namespace LmiSurveyRbcBulkTransfer
{
    public partial class userViewForm : Form
    {
        public userViewForm()
        {
            InitializeComponent();
        }

        private void viewUserListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void userViewForm_Load(object sender, EventArgs e)
        {

            for (int i = 0; i < Global.firstNamesNew.Count; i++)

            {

                viewUserListBox.Items.Add(Global.firstNamesNew[i] + " " + Global.lastNameNew[i] + " " + Global.emailNew[i]);

            }

        }


    }
}
