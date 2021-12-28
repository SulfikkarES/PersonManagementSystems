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
    public partial class CountryEdit : Form
    {
        public CountryEdit()
        {
            InitializeComponent();
        }

        private void btnEditSave_Click(object sender, EventArgs e)
        {

            int result = 0;

            Country cntryeditobj = new Country();
            cntryeditobj.CountryId = Convert.ToInt32(txtEditName.Text);
            cntryeditobj.CountryDescription = rtEditDescription.Text;
            cntryeditobj.CountryName =txtEditCountryName.Text;
            
            try
            {
                result = cntryeditobj.EditACountry();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (result >= 1)
            {
                MessageBox.Show("Country editted seccessfully");
            }
            else
            {
                MessageBox.Show("Failure in Editing a country, So please try again");
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

        private void txtEditName_TextChanged(object sender, EventArgs e)
        {

        }

        private void CountryEdit_Load(object sender, EventArgs e)
        {

        }
    }
}




