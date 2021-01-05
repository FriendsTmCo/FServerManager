using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Services.Server.Repository
{
    public interface IPoweRepository
    {
        Task<int> Shutdown(int option);
        Task<int> Restart(int option);
        
    }

    public interface IUserControllerRepository
    {
        Task<int> NewUser(string userName, string password);
        Task<int> ResetPassword(string userName, string newPassword);
        Task<int> DeleteExistUser(string userName, string password);
    }
}