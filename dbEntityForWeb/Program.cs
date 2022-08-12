using dbEntityForWeb;
using dbEntityForWeb.Entity;
using Microsoft.EntityFrameworkCore;

using (var db = new Context())
{

    //var Company1 = new Company() { Name = "Microfibra", CompanyDetails = " sovetskaya street, house 13, appartment 26" };
    //var Company2 = new Company() { Name = "Lesopoval", CompanyDetails = " Lesnoy pereylok street, house 3, appartment 1" };
    //var Company3 = new Company() { Name = "Microfibra", CompanyDetails = " Liniskuy prospeckt street, house 24, appartment 3" };

    //var payment1 = new Payment() { Cost = 1405, Contributed = 1405, Paid = true };
    //var payment2 = new Payment() { Cost = 1405, Contributed = 1425, Paid = true };
    //var payment3 = new Payment() { Cost = 1405, Contributed = 1400, Paid = false };

    ////Payment [] payments = new Payment[3];
    ////payments[0] = new Payment() { Cost = 1405, Contributed = 1405 };
    ////payments[1] = new Payment() { Cost = 1405, Contributed = 1425 };
    ////payments[2] = new Payment() { Cost = 1405, Contributed = 1400 };
    ////payments[3] = new Payment() { Cost = 1405, Contributed = 1405 };

    //var person1 = new Client()
    //{
    //    Name = "Max",
    //    PhoneNumber = 89641443826,
    //    Company = Company3,
    //    Payment = payment1
    //};
    //var person2 = new Client()
    //{
    //    Name = "Gector",
    //    PhoneNumber = 11641443826,
    //    Company = Company2,
    //    Payment = payment2

    //};
    //var person3 = new Client()
    //{
    //    Name = "Sofia",
    //    PhoneNumber = 896422243826,
    //    Company = Company2,
    //    Payment = payment3

    //};
    //db.Clients.Add(person1);
    //db.Clients.Add(person2);
    //db.Clients.Add(person3);
    //db.SaveChanges();
}
using (var context = new Context())
{
    var persons = context.Clients.Include(p => p.Company);
;
    foreach (var person in persons)
    {
        Console.WriteLine($"{person.Name} {person.PhoneNumber} {person.Company?.Name}");

    }
    Console.WriteLine("----------------------------------------------");
}
using (var context = new Context())
{
    var persons = context.Clients
        .Join(context.Companys,
        p => p.CurrentCompanyId,
        d => d.Id,
        (person, company) =>
        new {
            PersonId = person.Id,
            Company = company.Name
        });

    foreach (var person in persons)
    {
        Console.WriteLine(person.PersonId);
        Console.WriteLine(person.Company);
    }
}