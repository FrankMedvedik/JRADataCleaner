using System;
using System.Windows.Forms;
using JRAMelissaWrapper;

namespace JRADataCleanUI
{
    public partial class Form1 : Form
    {
        private DataCleaner dataCleaner = new DataCleaner();
        public Form1()
        {
            InitializeComponent();
            FillColumns();
            FillOptions();
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
            SetActions();

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
            tabControl1.SelectedTab = tabControl1.TabPages[2];
        }



        //******************************************************************************
        // Helper Method for Setting the Options
        //****************************************************************************** 
        //public string SetOptions()
        //{
        //    string options = "";


        //    if (chkUsePreferredCity.Checked) 
        //        options += "UsePreferredCity:on;";

        //    if (chkAdvancedAddressCorrection.Checked)
        //        options += "AdvancedAddressCorrection:on;";


        //    switch (comboBoxCentricHint.SelectedIndex)
        //    {
        //        case 0: options += "CentricHint:Auto;"; break;
        //        case 1: options += "CentricHint:Address;"; break;
        //        case 2: options += "CentricHint:Phone;"; break;
        //        case 3: options += "CentricHint:Email;"; break;
        //        default:
        //            break;
        //    }

        //    switch (comboBoxAppend.SelectedIndex)
        //    {
        //        case 0: options += "Append:CheckError;"; break;
        //        case 1: options += "Append:Always;"; break;
        //        case 2: options += "Append:Blank;"; break;
        //    }

        //    options = options.TrimEnd(';');
        //    return options;
        //}


        //******************************************************************************
        // Helper Method for Setting the Actions
        //******************************************************************************
        protected void SetActions()
        {
            if (chkActionCheck.Checked) dataCleaner.ActionCheck = true;
            if (chkActionVerify.Checked) dataCleaner.ActionVerify = true;
            if (chkActionAppend.Checked) dataCleaner.ActionAppend = true;
            if (chkActionMove.Checked) dataCleaner.ActionMove = true;
        }



        //******************************************************************************
        // Helper Method for Setting the Column Requests
        //******************************************************************************
        public string SetColumns()
        {
            string columns = "";

            foreach (object itemChecked in chkListBoxColumns.CheckedItems)
            {
                columns += "Grp" + itemChecked.ToString() + ",";
            }

            foreach (object itemChecked in chkListBoxGroups.CheckedItems)
            {
                columns += "Grp" + itemChecked.ToString() + ",";
            }

            columns = columns.TrimEnd(',');
            return columns;

        }



        //******************************************************************************
        // Pre-Load column definitions
        //******************************************************************************
        public void FillColumns()
        {
            foreach (string s in Enum.GetNames(typeof(Columns.ChooseColumns)))
            {
                chkListBoxColumns.Items.Add(s);
            }

            foreach (string s in Enum.GetNames(typeof(Columns.Groups)))
            {
                chkListBoxGroups.Items.Add(s);
            }
        }



        //******************************************************************************
        // Pre-Load options definitions
        //******************************************************************************
        public void FillOptions()
        {
            foreach (string s in Enum.GetNames(typeof(Options.CentricHint)))
            {
                comboBoxCentricHint.Items.Add(s);
            }
        }


        //******************************************************************************
        // Action for Checking "Check all Columns"
        //******************************************************************************
        private void chkBoxAllColumns_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBoxAllColumns.Text == "Check All Columns")
            {
                for (int i = 0; i < chkListBoxColumns.Items.Count; i++)
                {
                    chkListBoxColumns.SetItemChecked(i, true);
                }
                chkBoxAllColumns.Text = "un-Check ALL";
            }
            else
            {
                for (int i = 0; i < chkListBoxColumns.Items.Count; i++)
                {
                    chkListBoxColumns.SetItemChecked(i, false);
                }
                chkBoxAllColumns.Text = "Check All Columns";
            }
        }



        //******************************************************************************
        // Action for Checking "Check all Groups"
        //******************************************************************************
        private void chkBoxAllGroups_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBoxAllGroups.Text == "Check All Groups")
            {
                for (int i = 0; i < chkListBoxGroups.Items.Count; i++)
                {
                    chkListBoxGroups.SetItemChecked(i, true);
                }
                chkBoxAllGroups.Text = "un-Check ALL";
            }
            else
            {
                for (int i = 0; i < chkListBoxGroups.Items.Count; i++)
                {
                    chkListBoxGroups.SetItemChecked(i, false);
                }
                chkBoxAllGroups.Text = "Check All Groups";
            }
        }



        
    }
}
