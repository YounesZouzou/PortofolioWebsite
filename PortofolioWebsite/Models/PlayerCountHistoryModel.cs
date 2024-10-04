using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PortofolioWebsite.Models
{
    public class PlayerCountHistoryModel
    {
        [Key] // Ensures that Entity Framework recognizes this as the primary key
        [Column("id")]
        public long Id { get; private set; }

        [ForeignKey("Server")]
        [Column("server_id")]
        public long ServerId { get; private set; }

        [Column("playercount")]
        public short PlayerCount { get; private set; }

        [Column("observed_at")]
        public DateTime ObservedAt { get; private set; }

        // Navigation property to the related server
        public virtual ServerModel Server { get; set; }
    }
}
