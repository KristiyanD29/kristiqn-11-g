using kristiqn_11_g.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kristiqn_11_g.Controller
{

    internal class CarsController
    {

        public List<Car> GetAll()
        {
            using (CarsEntities db = new CarsEntities())
            {
                { return db.Cars.ToList(); }
            }

        }

        public void AddCar(Car car)
        {
            using (CarsEntities db = new CarsEntities())
            {
                car.Id = db.Cars.ToList().LastOrDefault().Id + 1;
                db.Cars.Add(car);
                db.SaveChanges();
            }
        }
    }
}