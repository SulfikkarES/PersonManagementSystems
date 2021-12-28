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
    public partial class CountryList : Form
    {
        public CountryList()
        {
            InitializeComponent();
        }

        private void countryList_Load(object sender, EventArgs e)
        {
            Country dsobj = new Country();
            try
            {
                DataTable dtcountry = dsobj.GetAllCountries();
                dgvCountryList.DataSource = dtcountry;
            }
            catch (SqlException ex)
            {
                MessageBox.Show( ex.Message);
            }
            
        }

        private void dgvCountryList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
