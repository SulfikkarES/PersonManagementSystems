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
    public partial class TestPersonAdd : Form
    {
        public TestPersonAdd()
        {
            InitializeComponent();
        }

        private void btnNewSave_Click(object sender, EventArgs e)
        {
            Person tobj = new Person();
            tobj.FullName = txtTestName.Text;
            tobj.EmailAddress = txtTestEmail.Text;
            tobj.CountryId = Convert.ToInt32(cmbTestCountryy.SelectedValue);
            tobj.CityId = Convert.ToInt32(cmbTestCity.SelectedValue);





            //string perdbconnectionstring = "Data Source=el-iib-0\\SQLEXPRESS2017;Initial Catalog=dbsPersonManagementSystemSulfikkar;user id=sa;password=L0ncok#08L0ncok#08";
            string SelectQuery = " select cou_countryname from pms_country ";

            SqlConnection perdbCon = null;
            DataTable dtPerson = new DataTable();

            perdbCon = PersonDBConnection.GetConnetction(); //new SqlConnection(perdbconnectionstring);
            perdbCon.Open();

            SqlCommand daPerson = new SqlCommand(SelectQuery, perdbCon);
            SqlDataReader dr = daPerson.ExecuteReader();

            while (dr.Read)
            {
                cmbTestCountryy.Items.Add(dr.GetValue(1).ToString());
            }
            dr.Close();
            perdbCon.Close();
        }







    }

    private void TestPersonAdd_Load(object sender, EventArgs e)
    {


       
    }
}

    


