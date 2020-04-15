using DistrictQueryLocalDb.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DistrictQueryLocalDb.UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            comboBoxPro.DisplayMember = "ProName";
            comboBoxPro.ValueMember = "ProvinceID";

            comboBoxCity.DisplayMember = "CityName";
            comboBoxCity.ValueMember = "CityID";

            comboBoxDist.DisplayMember = "DistrictName";
            comboBoxDist.ValueMember = "DistrictID";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxPro.DataSource = Data.Provinces.OrderBy(t => t.ProSort).ToList();
        }

        private void comboBoxPro_SelectedIndexChanged(object sender, EventArgs e)
        {
            var ProID = (int)comboBoxPro.SelectedValue;
            comboBoxCity.DataSource = Data.Cities.Where(t => t.ProvinceID == ProID).OrderBy(t => t.CitySort).ToList();
        }

        private void comboBoxCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            var CityID = (int)comboBoxCity.SelectedValue;
            comboBoxDist.DataSource = Data.Districts.Where(t => t.CityID == CityID).OrderBy(t => t.DistrictSort).ToList();
        }
    }
}