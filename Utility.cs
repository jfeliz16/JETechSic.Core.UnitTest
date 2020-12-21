using JETech.SIC.Core.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace JETechSic.Core.UnitTest
{
    public class Utility
    {
        public static SicDbContext GetInMemorySicDbContext()
        {
            var options = new DbContextOptionsBuilder<SicDbContext>()
            .UseInMemoryDatabase(Guid.NewGuid().ToString())
            .Options;

            var context = new SicDbContext(options);

            context.Persons.AddRange(DataMockup.GetPerson());
            //context.xadmsucursalmst.AddRange(MockupData.Sucursales());
            //context.eadmtasacambiodet.AddRange(MockupData.TasasCambio());
            //context.xadmsectordirmst.AddRange(MockupData.Sector());
            //context.xadmmonedamst.AddRange(MockupData.Monedas());
            //context.eadmrolcfg.AddRange(MockupData.Roles());
            //context.eadmrolatributodet.AddRange(MockupData.Atributos());
            //context.xadmciudadmst.AddRange(MockupData.Ciudades());
            //context.eadmtipoidcfg.AddRange(MockupData.TiposIdentificacion());
            //context.eadmsectorfinmst.AddRange(MockupData.SectoresEconomicos());
            //context.eadmfuenterecmst.AddRange(MockupData.FuenteRecursos());
            //context.xadmprovinciamst.AddRange(MockupData.Provincias());
            //context.xadmpaismst.AddRange(MockupData.Paises());
            //context.xadmpaisdet.AddRange(MockupData.DetallePais());
            //context.eadmmotivomst.AddRange(MockupData.Motivos());
            context.SaveChanges();
            return context;
        }
    }
}
