using MediatR;
using VehicleMakes.Core.Bases;

namespace VehicleMakes.Core.Features.Emails.Commands.Models
{
    public class SendEmailCommand : IRequest<Response<string>>
    {
        public string Email { get; set; }
        public string Message { get; set; }
    }
}
