using kristiqn_11_g.Controller;
using kristiqn_11_g.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kristiqn_11_g.View
{
    public partial class CarsView : Form
    {
        CarsController carsController = new CarsController();

        public CarsView()
        {
            InitializeComponent();
        }

        private void CarsView_Load(object sender, EventArgs e)
        {
            dgvCars.DataSource = carsController.GetAll();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Car car = new Car();
            car.Model = txtModel.Text;
            car.Year = txtGodina.Text;
            carsController.AddCar(car);
            dgvCars.DataSource = carsController.GetAll();
        }
    }
}
