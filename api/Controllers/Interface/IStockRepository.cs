using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Models;

namespace api.Controllers.Interface
{
    public interface IStockRepository
    {
        Task<List<Stock>> GetAllAsync();
    }
}