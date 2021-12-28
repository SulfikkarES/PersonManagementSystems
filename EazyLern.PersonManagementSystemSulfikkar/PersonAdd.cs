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
    public partial class PersonAdd : Form
    {
        public PersonAdd()
        {
            InitializeComponent();
        }

        private void btnDeleteCancel_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in Controls)
            {
                if (ctrl is TextBox || ctrl is RichTextBox || ctrl is ComboBox )
                {
                    ctrl.Text = "";
                }
            }
        }

        private void btnNewSave_Click(object sender, EventArgs e)
        {

            int result = 0;
            Person probj = new Person();
            probj.FullName = txtNewName.Text;
            probj.EmailAddress = txtNewEmail.Text ;
            probj.CountryId = Convert.ToInt32(cmbNewCountryy.SelectedValue);
            probj.CityId = Convert.ToInt32(cmbNewCity.SelectedValue);
;           
          
            //dsobj.CountryAddedBy = txtAddedBy.Text;

            try
            {
                result = probj.InsertAPerson();
            }
            catch (SqlException ex)
            {
                MessageBox.Show( ex.Message);
            }

            if (result >= 1)
            {
                MessageBox.Show("Person added successfully");
            }
            else
            {
                MessageBox.Show("Failure in addeing a Person, So please try again");
            }
        }

        private void PersonAdd_Load(object sender, EventArgs e)
        {
             Person pobj = new Person();
            cmbNewCountryy.DataSource = pobj.GetAll1Countries();

            cmbNewCountryy.ValueMember = "cou_countryId";
            cmbNewCountryy.DisplayMember = "cou_countryname";


            cmbNewCity.DataSource = pobj.GetAll1Cities(cmbNewCountryy.SelectedValue.ToString());


            City skObj = new City();
            DataTable dtCity = null;

            try
            {
                DataSet dsResult = skObj.GetAllCities(Convert.ToInt32(cmbNewCountryy.SelectedValue.ToString()));
                dtCity = dsResult.Tables[0];
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

            cmbNewCity.DataSource = dtCity;
            cmbNewCity.DisplayMember = "cit_cityname";
            cmbNewCity.ValueMember = "cit_cityid";

            Country dObj = new Country();
            DataTable dtPerson = dObj.GetAllCountries();


            cmbNewCountryy.DataSource = dtPerson;
            cmbNewCountryy.DisplayMember = "cit_cityname";
            cmbNewCountryy.ValueMember = "cit_cityid";


        }

        private void cmbNewCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            Person cobj = new Person();
           
            //cmbNewCity.DataSource   = cobj.GetAll1Cities(cmbNewCountryy.SelectedValue.ToString());

            //cmbNewCity.DataSource = dtPerson;
            //cmbNewCity.DisplayMember = "cit_cityname";
           // cmbNewCity.ValueMember = "cit_cityid";




        }

        private void cmbNewCountryy_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int value = Convert.ToInt32(cmbNewCountryy.SelectedValue);
                City obj = new City();
                DataSet ds = new DataSet();
                obj.CountryId = value;
                ds = obj.GetAllCities(value);
                cmbNewCity.DataSource = ds;
                cmbNewCity.ValueMember = "cit_cityid";
                cmbNewCity.DisplayMember = "cit_city";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
               //cmbNewCountryy.DataSource  =  cobj.GetAll1Cities(); 

            //cmbNewCity.DataSource = cobj.GetAll1Cities(cmbNewCountryy.SelectedValue.ToString());
        }

        private void lblDeleteAddedBy_Click(object sender, EventArgs e)
        {

        }

        private void lblNewPerson_Click(object sender, EventArgs e)
        {

        }

        private void txtDeleteAddedBy_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNewEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNewName_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblCountryCountry_Click(object sender, EventArgs e)
        {

        }

        private void lblNewCity_Click(object sender, EventArgs e)
        {

        }

        private void lblNewEmail_Click(object sender, EventArgs e)
        {

        }

        private void lblNewName_Click(object sender, EventArgs e)
        {

        }
    }
}
