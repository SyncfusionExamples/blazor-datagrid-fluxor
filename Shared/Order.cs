﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluxorSyncfusionGrid.Shared
{
    public  class Order
    {

        public int? OrderID { get; set; }
        public int? EmployeeID { get; set; }
        public string? CustomerID { get; set; }
        public bool? Verified { get; set; }
        public string? ShipCity { get; set; }
        public string? ShipCountry { get; set; }
        public string? ShipName { get; set; }
        public string? ShipAddress { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime ShippedDate { get; set; }
        public double Freight { get; set; }
    }
}
