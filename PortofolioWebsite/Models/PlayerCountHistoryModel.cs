using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PortofolioWebsite.Models
{
    public class PlayerCountHistoryModel
    {
        [Key]
        public long Id { get; } // The Id is read-only since postgres handles it

        [ForeignKey("Server")]
        public long ServerId { get; }

        public short PlayerCount { get; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime ObservedAt { get; } = DateTime.UtcNow;

        // Used to unique identify it to a playercount
        public virtual ServerModel Server { get; }
    }
}
