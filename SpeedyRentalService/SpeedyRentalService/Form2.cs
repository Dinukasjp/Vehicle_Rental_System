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
    public partial class Form2 : Form
    {
        private string UserNameValue;

        public Form2()
        {
            InitializeComponent();
        }

        public Form2(string UserNameValue) //this constructor used to pass the user name value from form1 to form2
        {
            InitializeComponent();
            this.UserNameValue = UserNameValue;
      
        }

        //these three objects used to handle "form3forBike / Form4forCars / Form5Van" forms
        Form3forBike f3 = new Form3forBike() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
        Form4forCars f4 = new Form4forCars() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
        Form5Van f5 = new Form5Van() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };


        private void Form2_Load(object sender, EventArgs e)
        {
            lblWelcomeMessage.Text = "Hello.. " + UserNameValue + " Welcome Speedy Rental Service!";
            
        }

        

        private void btnViewDetailsBike_Click(object sender, EventArgs e)
        {
            
            this.panel1.Controls.Add(f3); // "Form3forBike" form load inside the panel in "Form2"
            f4.Hide(); // hide "Form4forCars" form 
            f5.Hide(); // hide "Form5Van"
            f3.Show(); //show "form3forBike" form
    
        }

        private void btnViewDetailsCar_Click(object sender, EventArgs e)
        {
            
            this.panel1.Controls.Add(f4); //"Form4forCars" form load inside the panel in "Form2"
            f3.Hide(); //hide "form3forBike"
            f5.Hide(); //hide "Form5Van" 
            f4.Show(); //show "Form4forCars" form
 
        }

        private void ViewDetailsVan_Click(object sender, EventArgs e)
        {
            this.panel1.Controls.Add(f5); //"Form5Van" form load inside the panel in "Form2"
            f3.Hide(); //hide "form3forBike"
            f4.Hide(); // hide "Form4forCars" form
            f5.Show(); //show "Form5Van" form
             //hide this "form2" form

        }

        //below methods are used to change the color of "More" buttons in "Form2"
        private void btnViewDetailsBike_MouseHover(object sender, EventArgs e)
        {
            btnViewDetailsBike.BackColor = Color.Crimson;
        }

        private void btnViewDetailsBike_MouseLeave(object sender, EventArgs e)
        {
            btnViewDetailsBike.BackColor = Color.DarkBlue;
        }

        private void btnViewDetailsCar_MouseHover(object sender, EventArgs e)
        {
            btnViewDetailsCar.BackColor = Color.Crimson;
        }

        private void btnViewDetailsCar_MouseLeave(object sender, EventArgs e)
        {
            btnViewDetailsCar.BackColor = Color.DarkBlue;
        }

        private void ViewDetailsVan_MouseHover(object sender, EventArgs e)
        {
            btnViewDetailsVan.BackColor = Color.Crimson;
        }

        private void btnViewDetailsVan_MouseLeave(object sender, EventArgs e)
        {
            btnViewDetailsVan.BackColor = Color.DarkBlue; 
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
