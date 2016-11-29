using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestingDatabase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'miranSanDataSet.Country' table. You can move, or remove it, as needed.
            this.countryTableAdapter.Fill(this.miranSanDataSet.Country);
            using (MiranSanEntities context = new MiranSanEntities())
            {
                var query = context.Country.Where(x => x.CountryID > 40 && x.CountryID < 50);
                var result = query.ToList();
                foreach (var item in result)
                {
                    Console.WriteLine(item.Name);
                }
            }
            Console.WriteLine("U novom branch-u");
        }
    }
}
