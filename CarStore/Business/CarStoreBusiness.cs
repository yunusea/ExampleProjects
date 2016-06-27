using Contracts.Repository;
using Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class CarStoreBusiness
    {
        private readonly IVehicleRepository<Vehicle> _vehicleRepository;

        public CarStoreBusiness(IVehicleRepository<Vehicle> VehicleRepository)
        {
            _vehicleRepository = VehicleRepository;
        }

        public string AddVehicle(Vehicle entity)
        {
            string _info;
            try
            {
                _vehicleRepository.AddVehicle(entity);
                _vehicleRepository.SaveVehicle();
                _info = entity.Brand + " marka " + entity.Model + " model bir araç eklendi.";
            }
            catch (Exception error)
            {
                _info = "Ekleme işlemi sırasında bir hata oluştu. <br />" + error ;
            }

            return _info;
        }

        public string DeleteVehicle(int id)
        {
            string _info;
            var entity = _vehicleRepository.GetById(id);

            if (entity != null)
            {
                try
                {
                    _vehicleRepository.DeleteVehicle(entity);
                    _vehicleRepository.SaveVehicle();
                    _info = entity.Brand + " marka " + entity.Model + " model " + entity.Plate + " plakalı aracı sildiniz.";
                }
                catch (Exception error)
                {
                    _info = "Silme işlemi sırasında bir hata oluştu. <br />" + error;
                }
            }
            else
            {
                _info = "Silmek istediğiniz araç bulunamadı.";
            }
            return _info;
        }

        public IEnumerable<Vehicle> GetList()
        {
            return _vehicleRepository.GetVehicleList();
        }
    }
}
