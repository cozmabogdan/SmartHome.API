using SmartHome.API.Models;
using System.Collections.Generic;
using System.Linq;

namespace SmartHome.API.Demo
{
    public class DataSeed
    {
        private readonly ApiContext _ctx;

        public DataSeed(ApiContext ctx)
        {
            _ctx = ctx;
        }

        public void SeedData()
        {
            if (!_ctx.Servers.Any())
            {
                SeedServers();
                _ctx.SaveChanges();
            }
        }

        internal void SeedServers()
        {
            var servers = BuildServerList();

            foreach (var server in servers)
            {
                _ctx.Servers.Add(server);
            }
        }

        internal static List<Server> BuildServerList()
        {
            return new List<Server>()
            {
                new Server
                {
                    Id = 1,
                    Name = "Camera",
                    IsOnline = true
                },

                new Server
                {
                    Id = 2,
                    Name = "Lampa",
                    IsOnline = true
                },
            };
        }
    }
}