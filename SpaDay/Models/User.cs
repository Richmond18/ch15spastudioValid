﻿using System;
namespace SpaDay.Models
{
    public class User
    {
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string VerifyPassword { get; set; }

        public User()
        {
        }

        public User(string u, string e, string p, string v)
        {
            Username = u;
            Email = e;
            Password = p;
            VerifyPassword = v;


        }

    }
}
