using OsDsII.api.Models;

namespace OsDsII.api.Dtos.ServiceOrders
{
    public record ServiceOrderDto (string Description, double Price, StatusServiceOrder Status, DateTimeOffset OpeningDate, DateTimeOffset FinishDate, List<Comment> Comments);
}
