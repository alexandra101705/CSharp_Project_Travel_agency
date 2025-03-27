﻿namespace Agentie_turism_transport_csharp.Domain
{
    public class SoftUser : Entity<long>
    {
        public string username { get; set; }
        public string password { get; set; }

        public SoftUser(string username, string password)
        {
            this.username = username;
            this.password = password;
        }

        public override string ToString()
        {
            return username;
        }
    }
}