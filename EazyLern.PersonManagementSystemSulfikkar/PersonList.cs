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
    public partial class PersonList : Form
    {
        public PersonList()
        {
            InitializeComponent();
        }

        private void PersonList_Load(object sender, EventArgs e)
        {
            Person eobj = new Person();
            try
            {
                DataTable dtperson = eobj.GetAllPersonWithCityNameAndCountryName();
                dgvPersonList.DataSource = dtperson;
            }
            catch(SqlException ex)
            {
                MessageBox.Show("Exception occured", ex.Message); 
            }
        }
    }
}
