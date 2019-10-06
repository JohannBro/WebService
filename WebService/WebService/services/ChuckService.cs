using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WebService.bo;

namespace WebService.services
{
    public interface ChuckService
    {
        Task<List<Joke>> GetJokes();
    }
}
