using Contracts.Repository;
using Data.DataContext;
using Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class VehicleRepository : IVehicleRepository<Vehicle>
    {
        private readonly CarStoreDataContext db = new CarStoreDataContext();
        public Vehicle AddVehicle(Vehicle obj)
        {
            return db.Vehicle.Add(obj);
        }

        public Vehicle DeleteVehicle(Vehicle obj)
        {
            return db.Vehicle.Remove(obj);
        }

        public Vehicle GetById(int Id)
        {
            return db.Vehicle.Where(x => x.Id == Id).FirstOrDefault();
        }

        public IEnumerable<Vehicle> GetVehicleList()
        {
            return db.Vehicle.ToList();
        }

        public void SaveVehicle()
        {
            db.SaveChanges();
        }
    }
}
