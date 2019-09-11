﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ExactAdm.Domain.Models
{
    public class UserTemp
    {
        public string USERID { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string PASSWORD { get; set; }
        public string FIRST_NAME { get; set; }
        public string LAST_NAME { get; set; }
        public string EMAILID { get; set; }
        public string PHONE { get; set; }
        public string ACCESS_LEVEL { get; set; }
        public string READ_ONLY { get; set; }
    }
}