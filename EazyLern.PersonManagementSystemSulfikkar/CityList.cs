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
    public partial class CityList : Form
    {
        private object cmbEditCountry;

        public CityList()
        {
            InitializeComponent();
        }

        private void dgvCities_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void cityList_Load(object sender, EventArgs e)
        {
            City adobj = new City();

            try
            {
                DataSet dsResult = adobj.GetAllCities(Convert.ToInt32(cmbEditCountry.ToString()));
                dgvCities.DataSource = dsResult.Tables[0];
            }


            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
