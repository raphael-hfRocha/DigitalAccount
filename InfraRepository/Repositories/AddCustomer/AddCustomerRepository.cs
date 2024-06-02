using System;
using Domain.Contracts.Repositories.AddCustomer;
using Domain.Entities;

namespace InfraRepository.Repositories.AddCustomer;
public class AddCustomerRepository : IAddCustomerRepository
{
    private readonly IList<Customer> _customers = new List<Customer>();


    public void AddCustomer(Customer customer)
    {
        _customers.Add(customer);
        throw new NotImplementedException();
    }
}
