using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerceWtech.Data.ORM.Entities
{
    public class AdminUser:BaseEntity
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
