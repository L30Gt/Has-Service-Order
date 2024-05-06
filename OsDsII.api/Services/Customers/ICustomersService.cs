using OsDsII.api.Dtos;

namespace OsDsII.api.Services.Customers
{
    public interface ICustomersService
    {
        public Task CreateAsync(CreateCustomerDto customer);
        public Task<IEnumerable<CustomerDto>> GetAllAsync();
        public Task<CustomerDto> GetByIdAsync(int id);

    }
}
