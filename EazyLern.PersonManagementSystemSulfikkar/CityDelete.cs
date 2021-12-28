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
    public partial class CityDelete : Form
    {
        public CityDelete()
        {
            InitializeComponent();
        }

        private void btnDeleteSave_Click(object sender, EventArgs e)
        {
            int result;

            City ctydeleteobj = new City();
            ctydeleteobj.CityName = txtDeleteName.Text;
            ctydeleteobj.CountryId = Convert.ToInt32(cmbDeleteCity.SelectedValue);
            ctydeleteobj.CityDescription = rtDeleteDescription.Text;

            try
            {
                result = ctydeleteobj.DeleteACity();

                if (result >= 1)
                {
                    MessageBox.Show("City Deleted seccessfully");
                }
                else
                {
                    MessageBox.Show("Failure in Deleting a City, So please try again");
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnDeleteCancel_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in Controls)
            {
                if (ctrl is TextBox || ctrl is RichTextBox)
                {
                    ctrl.Text = "";
                }
            }
        }

        private void CityDelete_Load(object sender, EventArgs e)
        {
            Country dObj = new Country();
            DataTable dtCountry = dObj.GetAllCountries();

            cmbDeleteCity.DataSource = dtCountry;
            cmbDeleteCity.DisplayMember = "cou_countryname";
            cmbDeleteCity.ValueMember = "cou_countryid";

        }

        private void cmbDeleteCity_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
