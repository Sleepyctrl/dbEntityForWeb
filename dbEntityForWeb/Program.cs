using dbEntityForWeb;
using dbEntityForWeb.Entity;

using (var db = new Context())
{

    var Company1 = new Company() { Name = "Microfibra", CompanyDetails = " sovetskaya street, house 13, appartment 26" };
    var payment1 = new Payment() { Cost = 1405, Contributed = 1405};
    if(payment1.Contributed==payment1.Cost)
    {
        payment1.Paid = true;
    }
    var person1 = new Client()
    {
        Name = "Max",
        PhoneNumber = 89641443826,
        Company = Company1,
        Payment = payment1

    };
    db.Clients.Add(person1);
    //    context.Persons.Add(person2);
    //    context.Persons.Add(person3);
    db.SaveChanges();
}
