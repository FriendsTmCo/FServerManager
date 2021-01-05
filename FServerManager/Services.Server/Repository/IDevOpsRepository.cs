using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Services.Server.Repository
{
    public interface IDevOpsRepository
    {
        Task<int> InsertNewSite();
    }
}
