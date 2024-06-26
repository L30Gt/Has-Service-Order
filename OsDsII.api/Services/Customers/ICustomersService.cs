﻿using OsDsII.api.Dtos.Customers;

namespace OsDsII.api.Services.Customers
{
    public interface ICustomersService
    {
        public Task<IEnumerable<CustomerDto>> GetAllAsync();
        public Task<CustomerDto> GetByIdAsync(int id);
        public Task CreateAsync(CreateCustomerDto customer);
        public Task DeleteAsync(int id);
        public Task UpdateAsync(int id, CreateCustomerDto customer);
    }
}
