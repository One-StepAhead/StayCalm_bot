using System;
using System.Collections.Generic;

namespace StayCalmBot.Models.Entities
{
    public partial class Applicationsforconsultation
    {
        public int Id { get; set; }
        public string ClientId { get; set; } = null!;
        public string ClientMessage { get; set; } = null!;
        public DateTime ApplicationDate { get; set; }

        public virtual Client Client { get; set; } = null!;
    }
}
