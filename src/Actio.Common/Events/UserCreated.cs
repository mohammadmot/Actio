using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Actio.Common.Events
{
    public class UserCreated : IEvents
    {
        public string Email { get; }
        public string Name { get; }
        protected UserCreated()
        {

        }

        public UserCreated(string email, string name) // force to fill parameters in new instance
        {
            Email = email;
            Name = name;
        }
    }
}