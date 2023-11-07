using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities
{
    public class Contact : EntityBase
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Message { get; set; }
        public bool isRead { get; set; }
    }
}
