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
    public partial class Form4forCars : Form
    {


        public Form4forCars()
        {
            InitializeComponent();
        }

        CustomerDetailsFormcs CD2 = new CustomerDetailsFormcs(); //this object created for handle "CustomerDetailsFormcs" Form



        private void btnRentCar1_Click(object sender, EventArgs e)//when click the "Rent Now" button this form will hide and "CustomerDetailsFormcs" will show
        {
           
            CD2.Show();
            this.Hide();
        }



        private void btnRentCar2_Click(object sender, EventArgs e)//when click the "Rent Now" button this form will hide and "CustomerDetailsFormcs" will show
        {
           
            CD2.Show();
            this.Hide();
        }

        private void btnRentCar3_Click(object sender, EventArgs e)//when click the "Rent Now" button this form will hide and "CustomerDetailsFormcs" will show
        {
           
            CD2.Show();
            this.Hide();

        }


        //those below methods are used to change the color of "Rent Now" button
        private void btnRentCar1_MouseHover(object sender, EventArgs e)
        {
            btnRentCar1.BackColor = Color.Crimson;
        }

        private void btnRentCar1_MouseLeave(object sender, EventArgs e)
        {
            btnRentCar1.BackColor = Color.DarkBlue;
        }

        private void btnRentCar2_MouseHover(object sender, EventArgs e)
        {
            btnRentCar2.BackColor = Color.Crimson;
        }

        private void btnRentCar2_MouseLeave(object sender, EventArgs e)
        {
            btnRentCar2.BackColor = Color.DarkBlue;
        }

        private void btnRentCar3_MouseHover(object sender, EventArgs e)
        {
            btnRentCar3.BackColor = Color.Crimson;
        }

        private void btnRentCar3_MouseLeave(object sender, EventArgs e)
        {
            btnRentCar3.BackColor = Color.DarkBlue;
        }

        
    }

}
