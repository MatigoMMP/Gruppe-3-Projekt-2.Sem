using System.ComponentModel.DataAnnotations;

namespace festivalsql.Shared.Models
{
    public class Job
    {
        [Key]
        public int opgave_id { get; set; }

        public int opgavedetalje_id { get; set; }

        public int placering_id { get; set; }

        public int status_id { get; set; }
    }
}
