using JETech.NetCoreWeb;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using JETech.SIC.Core.Clients.Models;
using System.Linq;
using JETech.SIC.Core.Data.Entities;

namespace JETech.SIC.Core.UnitTest.Client
{
    public class Client
    {
        private readonly SicDbContext _dbContext;

        public Client() {
            _dbContext = new SicDbContext();
        }

        [Fact]
        public async void GetClients() 
        {
            ActionQueryArgs<ClientModel> args = new ActionQueryArgs<ClientModel>();
            

            JETech.SIC.Core.Clients.Domain.Client client = new Clients.Domain.Client(_dbContext);

            var result = await client.GetClients(args);

            Assert.NotNull(result.Data);
        }

        [Fact]
        public async void GetClients_Paging()
        {
            ActionQueryArgs<ClientModel> args = new ActionQueryArgs<ClientModel>(){};

            args.PageArgs = new PageArgs() { Num = 2, Size = 10 };            

            Clients.Domain.Client client = new Clients.Domain.Client(_dbContext);

            var result = await client.GetClients(args);

            Assert.NotNull(result.Data);
            Assert.Equal(10, result.Data.ToList().Count);
        }
    }
}
