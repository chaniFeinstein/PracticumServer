using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.DTO_s
{
    public class UserDTO
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string TZ { get; set; }
        public string Gender { get; set; }
        public DateTime BornDate { get; set; }
        public string HMO { get; set; }
        public int FamilyId { get; set; }
        public string Status { get; set; }
        public string GetTz { get; set; }
    }
}
