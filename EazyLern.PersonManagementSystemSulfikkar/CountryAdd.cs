using EazyLern.PersonManagementSystemSulfikkar.Components;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EazyLern.PersonManagementSystemSulfikkar
{
    public partial class CountryAdd : Form
    {
        public CountryAdd()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int result = 0;
            Country dsobj = new Country();
            dsobj.CountryName = txtName.Text;
            dsobj.CountryDescription = rtDescription.Text;
            //dsobj.CountryAddedBy = txtAddedBy.Text;

            try
            {
                result = dsobj.InsertACountry();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("exception occured", ex.Message);
            }

            if(result >= 1)
            {
                MessageBox.Show("Country added successfully");
            }
            else
            {
                MessageBox.Show("Failure in addeing a Country, So please try again");
            }
        }

        private void rtDescription_TextChanged(object sender, EventArgs e)
        {

        }

        private void countryAdd_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in Controls)
            {
                if (ctrl is TextBox || ctrl is RichTextBox)
                {
                    ctrl.Text = "";
                }
            }
        }
    }
}
