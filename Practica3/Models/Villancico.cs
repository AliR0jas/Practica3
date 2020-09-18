﻿using System;
using System.Collections.Generic;

namespace Practica3.Models
{
    public partial class Villancico
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Compositor { get; set; }
        public int? Anyo { get; set; }
        public string Letra { get; set; }
        public string VideoUrl { get; set; }
    }
}
