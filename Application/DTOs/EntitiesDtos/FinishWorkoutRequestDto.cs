using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.EntitiesDtos
{
    public class FinishWorkoutRequestDto
    {
        public Guid UserId { get; set; }
        public DateTime? EndTime{ get; set; }
    }
}
