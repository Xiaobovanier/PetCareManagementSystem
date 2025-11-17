using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetCareManagementSystemV2.Models
{
    public class Pet
    {
        public int PetId { get; set; }
        public int OwnerId { get; set; }
        public string PetName { get; set; } = "";
        public string Species { get; set; } = "";
        public string Breed { get; set; } = "";
        public DateTime? BirthDate { get; set; }
        public string Notes { get; set; } = "";
    }
}

