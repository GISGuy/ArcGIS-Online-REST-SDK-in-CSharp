﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArcGIS_Online_REST_SDK.Data
{
    public class FeaturesResult
    {
        public int OBJECTID { get; set; }
        public Boolean Success { get; set; }
        public ResultError Error { get; set; }
    }
}
