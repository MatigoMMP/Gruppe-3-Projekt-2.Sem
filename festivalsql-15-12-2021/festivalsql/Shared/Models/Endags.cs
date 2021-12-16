using System;
using System.ComponentModel.DataAnnotations;

namespace festivalsql.Shared.Models
{
    public class Endags
    {
        [Key]
        public int endags_id { get; set; }

        public string navn { get; set; }

        public string email { get; set; }

        public int telefon { get; set; }
    }
}
