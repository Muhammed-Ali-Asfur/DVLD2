using DVLD.Global_Classes;
using DVLD_Buisness;
using Google.Apis.Gmail.v1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.People
{
    public partial class frmSendEmail : Form
    {

        private clsPerson _Person;
        public frmSendEmail(int PersonID)
        {
            InitializeComponent();
            _Person = clsPerson.Find(PersonID);
        }

      
        private void LodData()
        {
            lbPerosnName.Text=_Person.FullName;
            lbPersonEmail.Text=_Person.Email;


        }

        private void frmSendEmail_Load(object sender, EventArgs e)
        {
            LodData();
        }

        private void btnSendEmail_Click(object sender, EventArgs e)
        {
            if (clsEmailService.GmailSender.SendEmail(recipientEmail: lbPersonEmail.Text, messageBody: txtEmailMessage.Text))
            {
                MessageBox.Show("Email sent successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("An error occurred while sending the email.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
    }
}
