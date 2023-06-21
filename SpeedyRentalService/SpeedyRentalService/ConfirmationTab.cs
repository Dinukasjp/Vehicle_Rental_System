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
    public partial class ConfirmationTab : Form
    {
        string Fname, Lname, NIC, Contact, LicenceNo, expireYear, RequiredDate, ReturnDate, DriverNeed;

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void lblRequiredDate_Click(object sender, EventArgs e)
        {

        }

        public ConfirmationTab()
        {
            InitializeComponent();
        }

        public ConfirmationTab(string Fname, string Lname, string NIC, string Contact, string LicenceNo, string expireYear, string RequiredDate, string ReturnDate, string DriverNeed)
        {
            InitializeComponent();
            this.Fname = Fname;
            this.Lname = Lname;
            this.NIC = NIC;
            this.Contact = Contact;
            this.LicenceNo = LicenceNo;
            this.expireYear = expireYear;
            this.RequiredDate = RequiredDate;
            this.ReturnDate = ReturnDate;
            this.DriverNeed = DriverNeed;
        }

        private void ConfirmationTab_Load(object sender, EventArgs e)
        {
            lblHeading.Text = "Speedy Rental Service Application";

            label1.Text = Fname;
            label2.Text = Lname;
            label3.Text = NIC;
            label5.Text = LicenceNo;
            label6.Text = expireYear;
            label7.Text = RequiredDate;
            label8.Text = ReturnDate;
            label9.Text = DriverNeed;

            label4.Text = "We will send you a confirmation mail within 1 hour via: " + Contact;
            label10.Text = "Thank You for Receiving Our Service..!";
        }
    }
}
