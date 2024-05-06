using System.Net;

namespace OsDsII.api.Exceptions
{
    public class NotFoundException : BaseException
    {
        public NotFoundException(string message) :
            base
                (
                "HSO-002", // código identificador de erros
                message,
                HttpStatusCode.Conflict,
                StatusCodes.Status409Conflict,
                null,
                DateTimeOffset.UtcNow,
                null
            )
        { }
    }
}
