using DataLayer.Context;
using DataLayer.Models;
using DataLayer.Repositories;
using DataLayer.Serives;
using System.Runtime.InteropServices.Marshalling;


UnitOfWork db = new UnitOfWork();

AccountingDbContext dbContext = new AccountingDbContext();
GenericRepository<Customer> repo = new GenericRepository<Customer>(dbContext);


//var list = db.CustomerRepository.GetAllCustomer();
var list = repo.Get(s => s.FullName.Contains("ALi"));

foreach (var customer in list)
{
    Console.WriteLine($"ID: {customer.CustomerId} - Name: {customer.FullName} - Mobile: {customer.Mobile} - Email: {customer.Email} - Address: {customer.Address}");
}

db.Dispose();
