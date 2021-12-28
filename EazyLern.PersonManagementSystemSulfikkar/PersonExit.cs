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
    public partial class PersonExit : Form
    {
        public PersonExit()
        {
            InitializeComponent();
        }

        private void PersonExit_Load(object sender, EventArgs e)
        {

            City skObj = new City();
            DataTable dtCity = null;

            try
            {
                
                DataSet dsResult = (skObj.GetAllCities(Convert.ToInt32(cmbNewCountryy.SelectedValue.ToString())));
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
            cmbNewCountryy.DisplayMember = "cou_countryname";
            cmbNewCountryy.ValueMember = "cou_countryid";



            //            Person pobj = new Person();
            //            Person pobj = new Person();
            //          cmbNewCountryy.DataSource = pobj.GetAll1Countries();

            //CountyBind();
        }

        private void btnNewSave_Click(object sender, EventArgs e)
        {
            Person pobj = new Person();
            pobj.FullName = txtNewName.Text;
            pobj.EmailAddress = txtNewEmail.Text;
            pobj.CountryId = Convert.ToInt32(cmbNewCountryy.SelectedValue);
            pobj.CityId = Convert.ToInt32(cmbNewCity.SelectedValue);

        }

        public void CountyBind()
        {

            SqlDataAdapter dadpPerson;
            string SelectQuery = " select cou_countryname from pms_country ";
            SqlConnection perdbCon = null;


            try
            {
                //SqlConnection perdbCon = null;
                //byte[] array = new byte[500];

                perdbCon = PersonDBConnection.GetConnetction();//new SqlConnection(perdbconnectionstring);
                perdbCon.Open();
                dadpPerson = new SqlDataAdapter(SelectQuery, perdbCon);


                //SqlConnection perdbCon = new SqlConnection(@"Data Source = el - iib - 0\\SQLEXPRESS2017; Initial Catalog = dbsPersonManagementSystemSulfikkar; user id = sa; password = L0ncok#08L0ncok#08"); //new SqlConnection(perdbconnectionstring);
                // perdbCon.Open();

                //daPerson.Fill(dtPerson);

                SqlCommand daPerson = new SqlCommand(SelectQuery, perdbCon);
                SqlDataReader dr = daPerson.ExecuteReader();

                while (dr.Read())
                {
                    cmbNewCountryy.Items.Add(dr.GetValue(1).ToString());
                }

                dr.Close();
                perdbCon.Close();
            }
            catch (IndexOutOfRangeException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbNewCountryy_SelectedIndexChanged(object sender, EventArgs e)
        {
            City skObj = new City();
            DataTable dtCity = null;

            try
            {
                DataSet dsResult = skObj.GetAllCities(Convert.ToInt32(cmbNewCountryy .SelectedValue.ToString()));
                dtCity = dsResult.Tables[0];
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

            cmbNewCity.DataSource = dtCity;
            cmbNewCity.DisplayMember = "cit_cityname";
            cmbNewCity.ValueMember = "cit_cityid";



            //Person pobj = new Person();
            //cmbNewCountryy.DataSource = pobj.GetAllPersonWithCityNameAndCountryName();

        }

        private void cmbNewCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            City skObj = new City();
            DataTable dtCity = null;

            try
            {
                DataSet dsResult =  skObj.GetAllCities(Convert.ToInt32(cmbNewCity.SelectedValue.ToString()));
               
                dtCity = dsResult.Tables[0];
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

            cmbNewCity.DataSource = dtCity;
            //cmbNewCountryy.SelectedValue.ToString();
            cmbNewCity.DisplayMember = "cit_cityname";
            cmbNewCity.ValueMember = "cit_cityid";


            //Person cobj = new Person();
            //cmbNewCity.DataSource = cobj.GetAll1Cities(cmbNewCountryy.SelectedValue.ToString());
        }
    }
}
