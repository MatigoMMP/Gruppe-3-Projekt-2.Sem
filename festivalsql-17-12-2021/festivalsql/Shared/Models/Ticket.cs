using System.ComponentModel.DataAnnotations;

namespace festivalsql.Shared.Models
{
    public class Ticket
    {
        public string navn { get; set; }

        public string email { get; set; }

        public int telefon { get; set; }
    }

    public class Partout : Ticket
    {
        [Key]
        public int partout_id { get; set; }
    }

    public class OneDay : Ticket
    {
        [Key]
        public int endags_id { get; set; }

        public string dato { get; set; }
    }
}
