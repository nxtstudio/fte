using System;
using System.Collections.Generic;

namespace FTE.Hiring.Models
{
    public class Group
    {
        public Guid Id { get; set; }
        public Guid Name { get; set; }

        public List<User> Users { get; set; }
    }

}
