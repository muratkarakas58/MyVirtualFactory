using MyFactoryClientType1.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFactoryClientType1.Models
{
    public class M001:BaseModel
    {
        public string MachineName { get; set; }
        public int MachineId { get; set; }

        public MachineTypeEnum MachineType { get; set; }
        public int ProductionSpeeedOfMachine { get; set; } 
        public ProductionUnitTypeEnum ProductionUnitType { get; set; }
        public MachineStatusEnum MachineStatus { get; set; } 

    }
}
