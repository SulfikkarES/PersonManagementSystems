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
    public partial class CityEdit : Form
    {
        public CityEdit()
        {
            InitializeComponent();
        }

        private void btnEditSave_Click(object sender, EventArgs e)
        {
            int result;

            City ctyeditobj = new City();
            ctyeditobj.CityName = txtEditName.Text;
            ctyeditobj.CityDescription = rtEditDescription.Text;
            ctyeditobj.CountryId = Convert.ToInt32(cmbCountryDetails.SelectedValue);
           
            try
            {
                result = ctyeditobj.EditACity();

                if (result >= 1)
                {
                    MessageBox.Show("City Editted seccessfully");
                }
                else
                {
                    MessageBox.Show("Failure in Editing a City, So please try again");
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void cityEdit_Load(object sender, EventArgs e)
        {
            Country dObj = new Country();
            DataTable dtCountry = dObj.GetAllCountries();

            cmbCountryDetails.DataSource = dtCountry;
            cmbCountryDetails.DisplayMember = "cou_countryname";
            cmbCountryDetails.ValueMember = "cou_countryid";

        }

        private void lblEditAddedby_Click(object sender, EventArgs e)
        {

        }

        private void btnEditCancel_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in Controls)
            {
                if (ctrl is TextBox || ctrl is RichTextBox)
                {
                    ctrl.Text = "";
                }
            }
        }

        private void lblEditCountryName_Click(object sender, EventArgs e)
        {

        }
    }
}
