using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PortofolioWebsite.Models
{
    /// <summary>
    /// This represents a game server with all its relevant information.
    /// </summary>
    public class ServerModel
    {
        [Key]
        public long Id { get; }  // The Id is read-only since postgres handles it
        public string Guid { get; private set; }
        public int? Port { get; private set; }
        public string Address { get; private set; }
        public short? PlayerCount { get; private set; }
        public short? MaxPlayerCount { get; private set; }
        public string ServerName { get; private set; }
        public string GameModule { get; private set; }
        public string GameType { get; private set; }
        public bool? IsOfficial { get; private set; }
        public bool? PasswordProtected { get; private set; }
        public string HostName { get; private set; }
        /// <summary>
        /// This is a JSON data type representing the loaded modules.
        /// </summary>
        public string LoadedModules { get; private set; }
        public bool? AllowsOptionalModules { get; private set; }
        public bool? CrossplayEnabled { get; private set; }
        public string HostId { get; private set; }
        public string Map { get; private set; }
        public DateTime? UpdatedAt { get; private set; }
        public virtual IReadOnlyCollection<PlayerCountHistoryModel> PlayerCountHistories { get; private set; } = new List<PlayerCountHistoryModel>();

    }
}
