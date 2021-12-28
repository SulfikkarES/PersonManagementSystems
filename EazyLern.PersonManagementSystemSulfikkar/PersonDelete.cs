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
    public partial class PersonDelete : Form
    {
        public PersonDelete()
        {
            InitializeComponent();
        }

        private void btnDeleteSave_Click(object sender, EventArgs e)
        {
            int result;

            Person prdeleteobj = new Person();
            prdeleteobj.PersonId =Convert.ToInt32(txtDeleteName.Text);
            //prdeleteobj.AddedBy = txtDeleteAddedBy.Text;

            try
            {
                result = prdeleteobj.DeleteAPerson();
                if (result >= 1)
                {
                    MessageBox.Show("Person Deleted seccessfully");
                }
                else
                {
                    MessageBox.Show("Failure in Deleting a Person, So please try again");
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void PersonDelete_Load(object sender, EventArgs e)
        {
            City skObj = new City();
            DataTable dtCity = null;

            try
            {
                DataSet dsResult = skObj.GetAllCities(Convert.ToInt32(cmbDeleteCountry.SelectedValue.ToString()));
                dtCity = dsResult.Tables[0];
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Exception", ex.Message);
            }

            cmbDeleteCity.DataSource = dtCity;

            cmbDeleteCity.DisplayMember = "cit_cityname";
            cmbDeleteCity.ValueMember = "cit_cityid";

            Country dObj = new Country();
            DataTable dtCountry = dObj.GetAllCountries();

            cmbDeleteCountry.DataSource = dtCountry;
            cmbDeleteCountry.DisplayMember = "cou_countryname";
            cmbDeleteCountry.ValueMember = "cou_countryid";

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

        private void lblDeleteAddedBy_Click(object sender, EventArgs e)
        {

        }

        private void lblDeletePerson_Click(object sender, EventArgs e)
        {

        }

        private void txtDeleteAddedBy_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbDeleteCountry_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbDeleteCity_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtDeleteEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDeleteName_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblDeleteCountry_Click(object sender, EventArgs e)
        {

        }

        private void lblDeleteCity_Click(object sender, EventArgs e)
        {

        }

        private void lblDeleteEmail_Click(object sender, EventArgs e)
        {

        }

        private void lblDeleteName_Click(object sender, EventArgs e)
        {

        }
    }
}
