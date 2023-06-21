using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpeedyRentalService
{
    public partial class CustomerDetailsFormcs : Form
    {
        

        public CustomerDetailsFormcs()
        {
            InitializeComponent();
        }

       


        private void CustomerDetailsFormcs_Load(object sender, EventArgs e)
        {
            //when this form load, those elements inside the Array will add to the CheckListBox
            string[] contactMethodsAdd = new[] { "E-mail", "Mobile", "WhatsApp" };
            checkedListBox1.Items.AddRange(contactMethodsAdd);

            //this for loop used to add elements to the combo box
            cmbExpireYear.Items.Add("");
            for (int i = 2022; i < 2029; i++)
            {
                cmbExpireYear.Items.Add(i);
            }

            txtFname.Text = "";
            txtLname.Text = "";
            txtNIC.Text = "";
            txtLicence.Text = "";

            cmbExpireYear.SelectedItem = "";

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

            
            
            //this if else statement used to check radio button input of the user
            string needDriver = " ";
            
            if(radioButton1.Checked == true)
            {
                needDriver = "Yes";
            }
            else
            {
                needDriver = "No";
            }

            //this if statment and for loop used to take the values form checkListBox
            string stringforCheckList = "";
            if (checkedListBox1.CheckedItems.Count != 0)
            {
                
                for (int i = 0; i < checkedListBox1.CheckedItems.Count; i++)
                {
                    stringforCheckList = checkedListBox1.CheckedItems[i].ToString();
                }

               
                 
                ConfirmationTab ConTab = new ConfirmationTab(txtFname.Text, txtLname.Text, txtNIC.Text, stringforCheckList, txtLicence.Text,cmbExpireYear.SelectedItem.ToString(), dateTimePicker1.Value.ToString(), dateTimePicker2.Value.ToString(), needDriver);
                ConTab.Show();
                this.Hide(); //when click the submit button,this will hide
            }

            else //if user doesn't select anything in checkboxlist, then user can't subimit the form. 
            {
                lblContact.Show();
                lblContact.Text = "Please select a contact method!";
            }

            
        }
        

        //when click the Cancel button this "CustomerDetailsFormcs" will hide and Go back to Form2
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        

        //these below methods used to handle the submit button color
        private void btnSubmit_MouseHover(object sender, EventArgs e)
        {
            btnSubmit.BackColor = Color.LimeGreen;
        }

        private void btnSubmit_MouseLeave(object sender, EventArgs e)
        {
            btnSubmit.BackColor = Color.RoyalBlue;
        }
    }


}
