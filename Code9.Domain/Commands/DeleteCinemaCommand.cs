using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace Code9.Domain.Commands
{
    public record DeleteCinemaCommand : IRequest<Unit>
    {
        public Guid Id { get; set; }
    }
}
