using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;

namespace Entities.Concrete
{
    public class Customer: IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public bool Gender { get; set; }
        public DateTime BirthDate { get; set; }
        public string Telephone1 { get; set; }
        public string Telephone2 { get; set; }
        public DateTime CreateDate { get; set; }
        public bool Status { get; set; }
        public string Role { get; set; }
    }
}
