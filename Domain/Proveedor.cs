﻿using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Proveedor : IEntidad
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
    }
}
