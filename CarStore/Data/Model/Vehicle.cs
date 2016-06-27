using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Model
{
    public class Vehicle
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("Marka:")]
        public string Brand { get; set; }

        [DisplayName("Model:")]
        public string Model { get; set; }

        [DisplayName("Plaka:")]
        public string Plate { get; set; }

        [DisplayName("Tipi:")]
        public int Type { get; set; }

        [DisplayName("Durum:")]
        public bool Status { get; set; }
    }
}
