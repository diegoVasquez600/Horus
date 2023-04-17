using Horus.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Horus.Services.Interfaces
{
    public interface ILogin
    {
        Task<LoginResponse> Login(User user);
    }
}
