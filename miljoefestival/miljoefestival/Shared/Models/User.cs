﻿using System;
using System.ComponentModel.DataAnnotations;

namespace miljoefestival.Shared.Models
{
    public class User
    {
        [Key]
        public int bruger_id { get; set; }

        public string fornavn { get; set; }

        public string efternavn { get; set; }

        public DateTime foedselsdato { get; set; }

        public string email { get; set; }

        public string username { get; set; }
    }
}
