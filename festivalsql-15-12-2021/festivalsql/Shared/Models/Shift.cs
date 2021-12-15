using System;
using System.ComponentModel.DataAnnotations;

namespace festivalsql.Shared.Models
{
    public class Shift
    {
        [Key]
        public int vagt_id { get; set; }

        public DateTime starttid { get; set; }

        public DateTime sluttid { get; set; }

        public int opgave_id { get; set; }

        public int bruger_id { get; set; }
    }
}
