using System;
using System.Configuration;
using System.Windows.Forms;
using DataClean;

namespace JRADataCleanUI
{
    public partial class Form1 : Form
    {
        private DataCleaner dataCleaner = new DataCleaner(ConfigurationManager.AppSettings);
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdSendStdrequest_Click(object sender, EventArgs e)
        {
            var i = new InputStreetAddress
            {
                FullName = txtName.Text,
                CompanyName = txtCompany.Text,
                AddressLine1 = txtAddressline1.Text,
                AddressLine2 = txtAddressline2.Text,
                City = txtCity.Text,
                State = txtProvince.Text,
                PostalCode = txtPostal.Text,
                Country = txtCountry.Text,
                FirstName = txtFirst.Text,
                LastName = txtLast.Text,
                EmailAddress = txtEmail.Text,
                PhoneNumber = txtPhone.Text
            };

            OutputStreetAddress o;
            try
            {
                if(!dataCleaner.VerifyAndCleanAddress(i, out o))
                    MessageBox.Show(o.Errors.ToString());
            }
            catch (Exception ex)
            {
                //batchSOAPExceptions++;
                MessageBox.Show("Exception: " + ex.Message + "\r\n");
                return;
            }


            // Print Output to Textboxes
            txtOutAddressLine1.Text = o.AddressLine1;
            txtOutAddressLine2.Text = o.AddressLine2;
            txtOutCity.Text = o.City;
            txtOutCompany.Text = o.CompanyName;
            txtOutEmail.Text = o.EmailAddress;
            txtOutFullName.Text = o.NameFull;
            txtOutPhone.Text = o.PhoneNumber;
            txtOutState.Text = o.State;

            foreach (var a in o.Results)
            {
                txtOutResults.Text += a.ToString() + Environment.NewLine;
            }
            tabControl1.SelectedTab = tabControl1.TabPages[1];
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
