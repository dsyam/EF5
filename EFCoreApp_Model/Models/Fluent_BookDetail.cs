﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreApp_Model.Models
{
    public class Fluent_BookDetail
    {

        public int BookDetail_Id { get; set; }


        public int NumberOfChapters { get; set; }

        public int NumberOfPages { get; set; }
        
        public double Weight { get; set; }

       
    }
}
