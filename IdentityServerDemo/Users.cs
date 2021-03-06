﻿using System.Collections.Generic;
using System.Security.Claims;
using Thinktecture.IdentityServer.Core.Services.InMemory;

namespace IdentityServerDemo
{
    public class Users
    {
        public static List<InMemoryUser> Get()
        {
            return new List<InMemoryUser>
            {
                new InMemoryUser
                {
                    Username = "bob",
                    Password = "bob",
                    Enabled = true,
                    Subject = "1",
                    Claims = new List<Claim>
                    {
                        new Claim("name", "Bob Smith")
                    }
                },
                new InMemoryUser
                {
                    Username = "jrustle",
                    Password = "password",
                    Enabled = true,
                    Subject = "2",
                    Claims = new List<Claim>
                    {
                        new Claim("name", "James Rustle")
                    }
                }
            };
        }
    }
}