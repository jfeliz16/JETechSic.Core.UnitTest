﻿using JETech.NetCoreWeb;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using JETech.SIC.Core.Clients.Models;
using System.Linq;
using JETech.SIC.Core.Data.Entities;
using JETech.NetCoreWeb.Types;
using JETechSic.Core.UnitTest;
using JETech.SIC.Core.Clients.Interfaces;

namespace JETech.SIC.Core.UnitTest.Client
{
    public class ClientService
    {
        private readonly SicDbContext _dbContext;
        private readonly IClientService _srvClient;

        public ClientService() {
            _dbContext = Utility.GetInMemorySicDbContext();
            _srvClient = new JETech.SIC.Core.Clients.Services.ClientService(_dbContext);
        }

        [Fact]
        public void GetClients() 
        {
            ActionQueryArgs<ClientModel> args = new ActionQueryArgs<ClientModel>();

            var result = _srvClient.GetClients(args);
          
            Assert.NotNull(result.Data);
            Assert.True(result.Data.Count() > 0);
        }

        [Fact]
        public void GetClients_Paging()
        {
            ActionQueryArgs<ClientModel> args = new ActionQueryArgs<ClientModel>(){};

            args.PageArgs = new PageArgs() { Num = 2, Size = 10 };            

            var result =  _srvClient.GetClients(args);

            Assert.NotNull(result.Data);
            Assert.Equal(10, result.Data.ToList().Count);
        }
    }
}
