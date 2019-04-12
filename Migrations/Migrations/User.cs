﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Migrations
{
    public class User
    {
        public Guid Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public DateTime? CreationDate { get; set; }
        public User()
        {
            Id = Guid.NewGuid();
        }
    }
}
