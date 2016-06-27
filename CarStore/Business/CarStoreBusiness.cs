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
        public string AddVehicle(Vehicle entity)
        {
            string _info;
            try
            {
                Castle.Resolve<IVehicleRepository<Vehicle>>().AddVehicle(entity);
                Castle.Resolve<IVehicleRepository<Vehicle>>().SaveVehicle();
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
            var entity = Castle.Resolve<IVehicleRepository<Vehicle>>().GetById(id);

            if (entity != null)
            {
                try
                {
                    Castle.Resolve<IVehicleRepository<Vehicle>>().DeleteVehicle(entity);
                    Castle.Resolve<IVehicleRepository<Vehicle>>().SaveVehicle();
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
            return Castle.Resolve<IVehicleRepository<Vehicle>>().GetVehicleList();
        }
    }
}
