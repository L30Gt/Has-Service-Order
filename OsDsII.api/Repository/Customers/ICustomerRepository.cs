﻿using OsDsII.api.Models;

namespace OsDsII.api.Repository.Customers
{
    public interface ICustomerRepository
    {
        public Task<List<Customer>> GetAllAsync();
        public Task<Customer> GetByIdAsync(int id);
        public Task<Customer> GetCustomerByEmailAsync(string email);
        public Task AddCustomerAsync(Customer customer);
        public Task DeleteCustomerAsync(Customer customer);
        public Task UpdateCustomerAsync(Customer customer);
    }
}
