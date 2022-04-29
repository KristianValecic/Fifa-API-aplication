using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib.Dal
{
    public interface IRepository
    {
        Task<T> GetOnlineDataAsync<T>(string endpoint);

        Task<T> GetOfflineDataAsync<T>(string endpoint);
    }
}
