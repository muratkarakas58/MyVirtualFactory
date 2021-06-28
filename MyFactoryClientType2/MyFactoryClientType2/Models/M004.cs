using MyFactoryClientType2.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFactoryClientType2.Models
{
    public class M004:BaseModel
    {
        public string UserName { get; set; }
        public MachineTypeEnum MachineType { get; set; }
        public int QuantityToBeProduced { get; set; }
        public ProductionUnitTypeEnum ProductionUnitType { get; set; }
    }
}
