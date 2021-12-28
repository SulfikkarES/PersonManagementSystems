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
    public partial class CityAdd : Form
    {
        public CityAdd()
        {
            InitializeComponent();
        }

        private void skillAdd_Load(object sender, EventArgs e)
        {
            Country dObj = new Country();
            DataTable dtCountry = dObj.GetAllCountries();

            cmbCountryName.DataSource = dtCountry; 
            cmbCountryName.DisplayMember = "cou_countryname";
            cmbCountryName.ValueMember = "cou_countryid";

        }

        private void lblCaption_Click(object sender, EventArgs e)
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            int result=0;
            City adobj = new City();
            adobj.CityName = txtNmae.Text;
            adobj.CityDescription = rtDescription.Text;
            adobj.CountryId = Convert.ToInt32(cmbCountryName.SelectedValue);//  SelectedValue); 
            //adobj.CityAddedBy = txtAddedBy.Text;
            try
            {
                result = adobj.InsertACity();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Exception occured" ,ex.Message);
            }

            if(result >= 1)
            {
                MessageBox.Show("City added seccessfully");
            }
            else
            {
                MessageBox.Show("Failure in addeing a city, So please try again");
            }
        }
    }
}
