using JETech.NetCoreWeb;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace JETech.SIC.Core.UnitTest.Client
{
    public class Client
    {
        [Fact]
        public async void GetClients() 
        {
            ActionQueryArgs<Clients.Models.ClientModel> args = new ActionQueryArgs<Clients.Models.ClientModel>();

            JETech.SIC.Core.Clients.Domain.Client client = new Clients.Domain.Client();

            var result = await client.GetClients(args);

            Assert.NotNull(result.Data);
        }
    }
}
