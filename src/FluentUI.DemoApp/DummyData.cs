using System;
using System.Collections.Generic;
using System.Text;

namespace FluentUI.DemoApp
{
    class DummyData
    {
        public string Name { get; set; }
        public bool Active { get; set; }
        public string City { get; set; }
        public string Email { get; set; }

        public static DummyData[] Get() =>
            new[] {
            new DummyData() { Name = "Frances", Active = true, City = Cities[new Random().Next(0,2)], Email = "purus@Morbineque.com" },
            new DummyData() { Name = "Blossom", Active = true, City = Cities[new Random().Next(0,2)], Email = "ut.lacus.Nulla@ipsumDonecsollicitudin.ca" },
            new DummyData() { Name = "Tallulah", Active = true, City = Cities[new Random().Next(0,2)], Email = "nec.ante.blandit@Nulla.co.uk" },
            new DummyData() { Name = "Jasmine", Active = true, City = Cities[new Random().Next(0,2)], Email = "lobortis@quama.org" },
            new DummyData() { Name = "Charles", Active = false, City = Cities[new Random().Next(0,2)], Email = "tincidunt.adipiscing@Aenean.edu" },
            new DummyData()  { Name = "Chiquita", Active = true, City = Cities[new Random().Next(0,2)], Email = "non@eleifendnondapibus.net" },
            new DummyData() { Name = "Bianca", Active = true, City = Cities[new Random().Next(0,2)], Email = "Duis@nisinibhlacinia.net" },
            new DummyData() { Name = "Jocelyn", Active = false, City = Cities[new Random().Next(0,2)], Email = "placerat@nonfeugiatnec.net" },
            new DummyData() { Name = "Kylee", Active = false, City = Cities[new Random().Next(0,2)], Email = "mauris.ipsum.porta@neque.net" },
            new DummyData() { Name = "Basil", Active = true, City = Cities[new Random().Next(0,2)], Email = "vehicula.Pellentesque@Suspendissecommodo.edu" },
            new DummyData() { Name = "Xenos", Active = true, City = Cities[new Random().Next(0,2)], Email = "sed@purus.co.uk" },
            new DummyData() { Name = "Jasper", Active = false, City = Cities[new Random().Next(0,2)], Email = "Nam.consequat@Proinvel.co.uk" },
            new DummyData() { Name = "Randall", Active = true, City = Cities[new Random().Next(0,2)], Email = "magna.sed.dui@Aliquamnecenim.co.uk" },
            new DummyData() { Name = "Kiona", Active = true, City = Cities[new Random().Next(0,2)], Email = "neque@eu.edu" },
            new DummyData() { Name = "Francis", Active = false, City = Cities[new Random().Next(0,2)], Email = "nunc@pharetra.ca" },
            new DummyData() { Name = "Jade", Active = false, City =Cities[new Random().Next(0,2)], Email = "Pellentesque.habitant@ornareFusce.co.uk" },
            new DummyData() { Name = "Erica", Active = false, City = Cities[new Random().Next(0,2)], Email = "ultricies.ligula@facilisisvitaeorci.org" },
            new DummyData() { Name = "Berk", Active = false, City = Cities[new Random().Next(0,2)], Email = "penatibus.et@cursus.edu" },
            new DummyData() { Name = "Hilel", Active = true, City = Cities[new Random().Next(0,2)], Email = "Fusce.aliquam@urnaconvallis.com" },
            new DummyData() { Name = "Zachery", Active = false, City = Cities[new Random().Next(0,2)], Email = "pharetra.ut.pharetra@nisiMauris.co.uk" }
        };


        public static string[] Cities => new[] 
        {
            "Ludlow",
            "Mariquina",
            "Montjovet"
        };
    }

}
