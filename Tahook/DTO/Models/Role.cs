﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tahook.DTO.Model
{
    public class Role
    {
        public int Id { get; set; }

        public string Description { get; set; }

        public int UserId { get; set; }

        public List<User> Users { get; set; }

        //public Role(int id, string description, int userId)
        //{
        //    Id = id;
        //    Description = description;
        //    UserId = userId;
        //}
    }
}
