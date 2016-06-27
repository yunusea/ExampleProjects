using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Repository
{
    public interface IVehicleRepository<T> where T : class
    {
        T AddVehicle(T obj);
        IEnumerable<T> GetVehicleList();
        T GetById(int Id);
        T DeleteVehicle(T obj);
        void SaveVehicle();
    }
}
