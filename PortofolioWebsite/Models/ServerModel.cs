using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PortofolioWebsite.Models
{
    /// <summary>
    /// This represents a game server with all its relevant information.
    /// </summary>
    [Table("servers")] // Specify the correct lowercase table name (postgres is case senstitive)
    public class ServerModel
    {
        [Key]
        [Column("id")] // Map to lowercase column name in the database
        public long Id { get; private set; } // Private setter for read-only outside EF

        [Column("guid")]
        public string Guid { get; private set; }

        [Column("port")]
        public int? Port { get; private set; }

        [Column("address")]
        public string Address { get; private set; }

        [Column("playercount")]
        public short? PlayerCount { get; private set; }

        [Column("maxplayercount")]
        public short? MaxPlayerCount { get; private set; }

        [Column("servername")]
        public string ServerName { get; private set; }

        [Column("gamemodule")]
        public string GameModule { get; private set; }

        [Column("gametype")]
        public string GameType { get; private set; }

        [Column("isofficial")]
        public bool? IsOfficial { get; private set; }

        [Column("passwordprotected")]
        public bool? PasswordProtected { get; private set; }

        [Column("hostname")]
        public string HostName { get; private set; }

        [Column("loadedmodules")]
        public string LoadedModules { get; private set; }

        [Column("allowsoptionalmodules")]
        public bool? AllowsOptionalModules { get; private set; }

        [Column("crossplayenabled")]
        public bool? CrossplayEnabled { get; private set; }

        [Column("hostid")]
        public string HostId { get; private set; }

        [Column("map")]
        public string Map { get; private set; }

        [Column("updated_at")]
        public DateTime? UpdatedAt { get; private set; }
        public virtual IReadOnlyCollection<PlayerCountHistoryModel> PlayerCountHistories { get; private set; } = new List<PlayerCountHistoryModel>();

    }
}
