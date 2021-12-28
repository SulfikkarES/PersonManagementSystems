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
    public partial class PersonEdit : Form
    {
        public PersonEdit()
        {
            InitializeComponent();
        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }

        private void btnEditSave_Click(object sender, EventArgs e)
        {

            int result;

            Person preditobj = new Person();
            preditobj.PersonId = Convert.ToInt32(txtEditName.Text);
            preditobj.EmailAddress = txtEditEmail.Text;
            preditobj.CityId = Convert.ToInt32(cmbEditCity.SelectedValue);
            //preditobj.CountryId = Convert.ToInt32(cmbEditCountry.SelectedValue);
            preditobj.FullName = txtEditName.Text;
                //ditobj.FullName = txtEditAddedBy.Text;

            try
            {
                result = preditobj.EditAPerson();

                if (result >= 1)
                {
                    MessageBox.Show("Person added seccessfully");
                }
                else
                {
                    MessageBox.Show("Failure in addeing a Person, So please try again");
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void PersonEdit_Load(object sender, EventArgs e)
        {
            City skObj = new City();
            DataTable dtCity = null;

            try
            {
                DataSet dsResult = skObj.GetAllCities(Convert.ToInt32(cmbEditCountry .SelectedValue.ToString()));
                dtCity = dsResult.Tables[0];
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Exception", ex.Message);
            }

            cmbEditCity.DataSource = dtCity;

            cmbEditCity.DisplayMember = "cit_cityname";
            cmbEditCity.ValueMember = "cit_cityid";

            Country dObj = new Country();
            DataTable dtCountry = dObj.GetAllCountries();

            cmbEditCountry.DataSource = dtCountry;
            cmbEditCountry.DisplayMember = "cou_countryname";
            cmbEditCountry.ValueMember = "cou_countryid";

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int result;

            Person pobj = new Person();
            pobj.FullName = txtEditName.Text;
            pobj.EmailAddress = txtEditEmail.Text;
            pobj.CityId = Convert.ToInt32(cmbEditCity.SelectedValue);
            pobj.CountryId = Convert.ToInt32(cmbEditCountry.SelectedValue);
            //pobj.AddedBy = txtEditAddedBy.Text;

            try
            {
                result = pobj.InsertAPerson();

                if (result >= 1)
                {
                    MessageBox.Show("Person added seccessfully");
                }
                else
                {
                    MessageBox.Show("Failure in addeing a Person, So please try again");
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
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

        private void lblEditPerson_Click(object sender, EventArgs e)
        {

        }
    }
}
