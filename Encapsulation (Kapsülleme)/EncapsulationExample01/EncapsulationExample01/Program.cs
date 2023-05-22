using EncapsulationExample01.Models;

Customer customer = new Customer()
{
    Id = 2,
    FirstName = "Harun",
    SoyAd = "Uysal",
};

Console.WriteLine(customer.FirstName + "\n"+ customer.SoyAd + "\n" + customer.Id
    );