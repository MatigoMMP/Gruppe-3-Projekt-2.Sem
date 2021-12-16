using System;
using System.ComponentModel.DataAnnotations;

namespace festivalsql.Shared.Models
{
    public class Partout
    {
        [Key]
        public int partout_id { get; set; }

        public string navn { get; set; }

        public string email { get; set; }

        public int telefon { get; set; }
    }
}
