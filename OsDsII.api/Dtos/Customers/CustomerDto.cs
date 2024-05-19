using OsDsII.api.Models;

namespace OsDsII.api.Dtos.Customers
{
    public record CustomerDto(string Name, string Email, string Phone)
    {
        public CustomerDto() : this("", "", "") { }
    }
}
