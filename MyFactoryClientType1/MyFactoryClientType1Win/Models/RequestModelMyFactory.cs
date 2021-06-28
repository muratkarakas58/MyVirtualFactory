﻿using MyFactoryClientType1.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFactoryClientType1.Models
{
    /// <summary>
    /// Serialize edebilmek için Serializable attributü ile işaretliyoruz.
    /// </summary
    [Serializable()]
    public class RequestModelMyFactory
    {
        public ModelTypeEnum ModelTypeCode { get; set; }
        public string Description { get; set; }

    }
}
