using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static People_Class.Program.Person;

namespace Lab6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PersonV2 temp = new PersonV2();

            //Storing all the data into their rightful variables
            temp.FirstName = txtFirstName.Text;

            temp.MiddleName = txtMiddleName.Text;

            temp.LastName = txtLastName.Text;

            temp.Street1 = txtStreet1.Text;

            temp.Street2 = txtStreet2.Text;

            temp.City = txtCity.Text;

            temp.State = txtState.Text;

            temp.Zip = txtZip.Text;

            temp.Phone = txtPhone.Text;

            temp.Email = txtEmail.Text;

            temp.CellPhone = txtCellPhone.Text;

            temp.InstagramURL = txtInstagramURL.Text;


            // displaying back to user whether they are missing or did anything wrong while filling up the form other wise letting user know that record has been added
            if (temp.Feedback.Contains("ERROR:"))
            {
                lblFeedback.Text = temp.Feedback;
            }

            else
            {
                lblFeedback.Text = temp.AddARecord();
            }
        }





        }

  
    
}
