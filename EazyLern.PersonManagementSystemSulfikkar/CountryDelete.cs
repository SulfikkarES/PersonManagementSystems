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
    public partial class CountryDelete : Form
    {
        public CountryDelete()
        {
            InitializeComponent();
        }

        private void btnDeleteSave_Click(object sender, EventArgs e)
        {
            int result = 0;

            Country cntrydeleteobj = new Country();
            cntrydeleteobj.CountryId = Convert.ToInt32(txtDeleteName.Text);
        
            try
            {
                result = cntrydeleteobj.DeleteACountry();
            }
            catch (SqlException ex)
            {
                MessageBox.Show( ex.Message);
            }

            if (result >= 1)
            {
                MessageBox.Show("Country deleted seccessfully");
            }
            else
            {
                MessageBox.Show("Failure in deleting a country, So please try again");
            }
        }

        private void countryDelete_Load(object sender, EventArgs e)
        {

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

        private void txtDeleteName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
