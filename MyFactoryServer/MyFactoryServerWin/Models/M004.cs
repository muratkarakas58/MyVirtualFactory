using MyFactoryServer.Enums;
using MyFactoryServer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFactoryServerWin.Models
{
    public class M004 : BaseModel
    {
        public string UserName { get; set; }
        public MachineTypeEnum MachineType { get; set; }
        public int QuantityToBeProduced { get; set; }
        public ProductionUnitTypeEnum ProductionUnitType { get; set; }
    }
}
