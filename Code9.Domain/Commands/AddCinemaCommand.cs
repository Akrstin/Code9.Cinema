using Code9.Domain.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code9.Domain.Commands
{
    public class AddCinemaCommand : IRequest<Cinema>
    {
        public string City { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int NumberOfAuditoriums { get; set; }
        [Required]
        public string Street { get; set; }
    }
}
