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
    /*
    Name: Dinuka Ekanayake
    Index No: ICT19822
    Subject: Visual Application Programming
    Sub no: ITC 2303
    Assignment no:2
    */


    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            lblShopName.Text = "Speedy Rental Service";
            lblError.Text = "*Please Enter First Name, Last Name and Email !";
            

            
        }

        

        private void btnLogIn_Click(object sender, EventArgs e) //check spaces in UserName/ password / email
        {
            if (txtUserName.Text.Trim() == "" || txtPassWord.Text.Trim() == "" || txtEmail.Text.Trim() == "")
            {
                
                lblError.Show(); //if there are spaces in username, this message will appear

                
            }
            else
            {
                lblError.Hide();
                Form2 f2 = new Form2(txtUserName.Text); //create a object from form2 to handle that form
                f2.Show();
                this.Hide(); 
            }

            
        }

        

        private void btnLogIn_MouseHover(object sender, EventArgs e) //change the login button color
        {
            btnLogIn.BackColor = Color.LimeGreen ; 
        }

        private void btnLogIn_MouseLeave(object sender, EventArgs e)
        {
            btnLogIn.BackColor = Color.RoyalBlue;
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
