using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace PetHotelDomain
{
    public class Owner
    {
        public Owner() 
        {
            Cats = new List<Cats>();
        }  
        public int ownerId { get; set; }
        public string ownerName { get; set; }
        public string ownerEmail { get; set; }
        public string ownerPhone { get; set; }

        public List<Cats> Cats { get; set; }

    }
}
