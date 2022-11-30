using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WSB.Models;

namespace WSB.Repositories
{
    public interface IExchangeRepository
    {
        ExchangeRate getCurrency(string cuurrency);
    }
}
