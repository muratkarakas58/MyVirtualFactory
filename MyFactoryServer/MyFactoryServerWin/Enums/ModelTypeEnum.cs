using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFactoryServer.Enums
{
    public enum ModelTypeEnum
    {
        M001 = 1, // Machine Login
        M002 = 2, // Send work to machine
        M003 = 3, // Login user
        M004 = 4, // Send work to server from user
        M005 = 5, // Sistemdeki makinaların listesinin sunucudan çekilmesi
        M006 =6,//Makinanın o anki durumunun ve şu ana kadar yaptığı işlerin sunucudan çekilmesi
        M007 =7//
    }
}
