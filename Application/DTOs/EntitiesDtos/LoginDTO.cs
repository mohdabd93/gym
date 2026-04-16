using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.EntitiesDtos
{
    public class LoginDTO
    {
        public string Email { get; set; }
        public string PassWord { get; set; } // should change it to hashcode
    }
}
