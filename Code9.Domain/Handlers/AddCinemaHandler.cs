using Code9.Domain.Commands;
using Code9.Domain.Interfaces;
using Code9.Domain.Models;
using Code9.Domain.Queries;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code9.Domain.Handlers
{
    internal class AddCinemaHandler : IRequestHandler<AddCinemaCommand, Cinema>
    {
        private readonly ICinemaRepository _cinemaRepository;
        public AddCinemaHandler(ICinemaRepository cinemaRepository)
        {
            _cinemaRepository = cinemaRepository;

        }
        
        public Task<Cinema> Handle(AddCinemaCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
            
        }
    }
}
