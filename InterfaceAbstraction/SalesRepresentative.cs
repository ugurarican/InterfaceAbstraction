﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAbstraction
{
    public class SalesRepresentative : IWorker
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Department { get; set; }

        public void Duty()
        {
            Console.WriteLine("Satış temsilcisi olarak çalışıyorum.");
        }
    }
}
