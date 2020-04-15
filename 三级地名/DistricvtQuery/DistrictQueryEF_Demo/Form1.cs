using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DistrictQueryEF_Demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            comboBoxPro.DisplayMember = "ProvinceName";
            comboBoxPro.ValueMember = "ProvinceID";

            comboBoxCity.DisplayMember = "CityName";
            comboBoxCity.ValueMember = "CityID";

            comboBoxDist.DisplayMember = "DistrictName";
            comboBoxDist.ValueMember = "DistrictID";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Database1Entities db = new Database1Entities();
            comboBoxPro.DataSource = db.Province.OrderBy(t => t.ProvinceSort).ToList();
        }

        private void comboBoxCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            Database1Entities db = new Database1Entities();
            var CityID = (int)comboBoxCity.SelectedValue;
            comboBoxDist.DataSource = db.District.Where(t => t.CityID == CityID).OrderBy(t => t.DistrictSort).ToList();
        }

        private void comboBoxPro_SelectedIndexChanged(object sender, EventArgs e)
        {
            Database1Entities db = new Database1Entities();
            var ProID = (int)comboBoxPro.SelectedValue;
            comboBoxCity.DataSource = db.City.Where(t => t.ProvinceID == ProID).OrderBy(t => t.CitySort).ToList();
        }
    }
}