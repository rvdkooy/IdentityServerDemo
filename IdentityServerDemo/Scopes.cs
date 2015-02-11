﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Thinktecture.IdentityServer.Core.Models;

namespace IdentityServerDemo
{
    public class Scopes
    {
        public static IEnumerable<Scope> Get()
        {
            var scopes = new List<Scope>();

            scopes.Add(StandardScopes.OpenId);
            scopes.Add(StandardScopes.Profile);

            var api1 = new Scope()
            {
                Enabled = true,
                Type = ScopeType.Resource,
                Name = "api1"
            };
            scopes.Add(api1);

            return scopes;
        }
    }

  
}
