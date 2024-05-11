using Code9.Domain.Interfaces;
using System;
using MediatR;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Code9.Domain.Queries;
using Code9.Domain.Models;

namespace Code9.Domain.Handlers
{
    public class GetAllCinemaHandler : IRequestHandler<GetAllCinemasQuery, List<Cinema>>
    {
        private readonly ICinemaRepository _cinemaRepository;

        public GetAllCinemaHandler(ICinemaRepository cinemaRepository)
        {
            _cinemaRepository = cinemaRepository;
        }

        public async Task<List<Cinema>> Handle(GetAllCinemasQuery request, CancellationToken cancellationToken)
        {
            return await _cinemaRepository.GetAllCinemas();
        }
    }
}
