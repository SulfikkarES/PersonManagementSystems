using EazyLern.PersonManagementSystemSulfikkar.Components;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EazyLern.PersonManagementSystemSulfikkar
{
    public partial class PersonMenu : Form
    {
        public PersonMenu()
        {
            InitializeComponent();
        }

        private void deleteToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void countryToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void deleteToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            CountryEdit cntry = new CountryEdit();
            cntry.MdiParent = this;
            cntry.Show();
        }

        private void newToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CityAdd cty = new CityAdd();
            cty.MdiParent = this;
            cty.Show();
        }

        private void listToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CityList ctylst = new CityList();
            ctylst.MdiParent = this;
            ctylst.Show();
        }

        private void updateToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            CountryList cntry = new CountryList();
            cntry.MdiParent = this;
            cntry.Show();
        }

        private void lsiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CountryAdd ctrad = new CountryAdd();
            ctrad.MdiParent = this;
            ctrad.Show();
        }

        private void listToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PersonList plst = new PersonList();
            plst.MdiParent = this;
            plst.Show();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PersonAdd prsad = new PersonAdd();
            prsad.MdiParent = this;
            prsad.Show();
        }

        private void updateToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CityEdit ctyedit = new CityEdit();
            ctyedit.MdiParent = this;
            ctyedit.Show();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PersonEdit predit = new PersonEdit();
            predit.MdiParent = this;
            predit.Show(); 
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PersonDelete prdelete = new PersonDelete();
            prdelete.MdiParent = this;
            prdelete.Show();
        }

        private void deleteToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            CityDelete ctydlt = new CityDelete();
            ctydlt.MdiParent = this;
            ctydlt.Show();
        }

        private void deleteToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            CountryDelete cntrydelt = new CountryDelete();
            cntrydelt.MdiParent = this;
            cntrydelt.Show();
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PersonExit pexobj = new PersonExit();
            pexobj.MdiParent = this;
            pexobj.Show();

        }
    }
}
