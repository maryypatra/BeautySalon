﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mariya.Data
{
    public class Visit
    {
        public int Id { get; set; }

        public int MasterId { get; set; }

        public int ClientId { get; set; }

        public int ServiceId { get; set; }

        public DateTime Time { get; set; }


        public string Status { get; set; }
    }
}
