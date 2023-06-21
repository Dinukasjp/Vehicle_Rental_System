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
    public partial class Form5Van : Form
    {
 
        public Form5Van()
        {
            InitializeComponent();
        }

        CustomerDetailsFormcs CD3 = new CustomerDetailsFormcs(); //this object created for handle "CustomerDetailsFormcs" Form
                                                                



        private void btnRentVan1_Click(object sender, EventArgs e)
        {

            //when click the "Rent Now" button this form will hide and "CustomerDetailsFormcs" will show
            CD3.Show();
            this.Hide();

        }

        private void btnRentVan2_Click(object sender, EventArgs e)
        {
            //when click the "Rent Now" button this form will hide and "CustomerDetailsFormcs" will show
            CD3.Show();
            this.Hide();
        }

        private void btnRentVan3_Click(object sender, EventArgs e)
        {
            //when click the "Rent Now" button this form will hide and "CustomerDetailsFormcs" will show
            CD3.Show();
            this.Hide();
        }


        //those below methods are used to change the color of "Rent Now" button
        private void btnRentVan1_MouseHover(object sender, EventArgs e)
        {
            btnRentVan1.BackColor = Color.Crimson;
        }

        private void btnRentVan1_MouseLeave(object sender, EventArgs e)
        {
            btnRentVan1.BackColor = Color.DarkBlue;
        }

        private void btnRentVan2_MouseHover(object sender, EventArgs e)
        {
            btnRentVan2.BackColor = Color.Crimson;
        }

        private void btnRentVan2_MouseLeave(object sender, EventArgs e)
        {
            btnRentVan2.BackColor = Color.DarkBlue;
        }

        private void btnRentVan3_MouseHover(object sender, EventArgs e)
        {
            btnRentVan3.BackColor = Color.Crimson;
        }

        private void btnRentVan3_MouseLeave(object sender, EventArgs e)
        {
            btnRentVan3.BackColor = Color.DarkBlue;
        }

        

        
    }
}
