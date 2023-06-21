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
    public partial class Form3forBike : Form
    {

        CustomerDetailsFormcs CD1 = new CustomerDetailsFormcs(); //create a object from "CustomerDetailsFormcs" form to handle that form



        public Form3forBike()
        {
            InitializeComponent();
        }

 
        

        private void button3_Click(object sender, EventArgs e) //when click the "Rent Now" button this form will hide and "CustomerDetailsFormcs" will show
        {
         
            CD1.Show();
            this.Hide();
        }

        

        private void btnRentBike1_Click(object sender, EventArgs e)//when click the "Rent Now" button this form will hide and "CustomerDetailsFormcs" will show
        {
          
            CD1.Show();
            this.Hide();
        }

        private void btnRentBike2_Click(object sender, EventArgs e)//when click the "Rent Now" button this form will hide and "CustomerDetailsFormcs" will show
        {

          
            CD1.Show();
            this.Hide();
        }

        


        //below methods used to change the color of "Rent Now" buttons
        private void btnRentBike1_MouseHover(object sender, EventArgs e)
        {
            btnRentBike1.BackColor = Color.Crimson;
                
        }

        private void btnRentBike1_MouseLeave(object sender, EventArgs e)
        {
            btnRentBike1.BackColor = Color.DarkBlue;
        }

        private void btnRentBike2_MouseHover(object sender, EventArgs e)
        {
            btnRentBike2.BackColor = Color.Crimson;
        }

        private void btnRentBike2_MouseLeave(object sender, EventArgs e)
        {
            btnRentBike2.BackColor = Color.DarkBlue;
        }

        private void btnRentBike3_MouseHover(object sender, EventArgs e)
        {
            btnRentBike3.BackColor = Color.Crimson;
        }

        private void btnRentBike3_MouseLeave(object sender, EventArgs e)
        {
            btnRentBike3.BackColor = Color.DarkBlue;
        }

        
    }
}
