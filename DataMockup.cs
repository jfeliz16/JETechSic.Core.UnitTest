using JETech.SIC.Core.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace JETechSic.Core.UnitTest
{
    public class DataMockup
    {
        public static Person[] GetPerson() => new[]
        {
            new Person
            {                 
                 FullName = "Andrick Lora ",
                 FirstName = "Andrick",
                 LastName = "Lora",
                 Address = "Juan de morfa"
            },
            new Person
            {
                 FullName = "Andrick 2 Lora 2",
                 FirstName = "Andrick 2",
                 LastName = "Lora 2",
                 Address = "Juan de morfa"
            },
            new Person
            {
                 FullName = "Andrick 3 Lora 3",
                 FirstName = "Andrick 3",
                 LastName = "Lora 3",
                 Address = "Juan de morfa"
            },
            new Person
            {
                 FullName = "Andrick 4 Lora 4",
                 FirstName = "Andrick 4",
                 LastName = "Lora 4",
                 Address = "Juan de morfa"
            },
        };
    }
}
