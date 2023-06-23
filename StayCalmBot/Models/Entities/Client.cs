using System;
using System.Collections.Generic;

namespace StayCalmBot.Models.Entities
{
    public partial class Client
    {
        public Client()
        {
            Applicationsforconsultations = new HashSet<Applicationsforconsultation>();
        }

        public string ChatId { get; set; } = null!;
        public string UserName { get; set; } = null!;
        public string? FirstName { get; set; }
        public decimal? PhoneNumber { get; set; }
        public string? EmailAddress { get; set; }

        public virtual ICollection<Applicationsforconsultation> Applicationsforconsultations { get; set; }
    }
}
