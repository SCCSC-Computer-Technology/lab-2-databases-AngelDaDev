using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AParada_Lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cityBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cityBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cityDBDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cityDBDataSet.City' table. You can move, or remove it, as needed.
            this.cityTableAdapter.Fill(this.cityDBDataSet.City);

        }

        private void getTotalPopulationBtn_Click(object sender, EventArgs e)
        {
            int populationTotal = (int)this.cityTableAdapter.SumPopulationQry();
            MessageBox.Show("Total Population of All Cities: \n" + populationTotal.ToString("N"));
        }

        private void getAvgPopulationBtn_Click(object sender, EventArgs e)
        {
            double populationAvg = (double)this.cityTableAdapter.AvgPopulationQry();
            MessageBox.Show("Average City Population: \n" + populationAvg.ToString("N"));
        }

        private void getHighestPopulationBtn_Click(object sender, EventArgs e)
        {
            int maxPopulation = (int)this.cityTableAdapter.HighestPopulationQry();
            MessageBox.Show("Highest City Population: \n" + maxPopulation.ToString("N"));

        }

        private void getLowestPopulationBtn_Click(object sender, EventArgs e)
        {
            int minPopulation = (int)this.cityTableAdapter.LowestPopulationQry();
            MessageBox.Show("Lowest City Population: \n" + minPopulation.ToString("N"));
        }
    }
}
