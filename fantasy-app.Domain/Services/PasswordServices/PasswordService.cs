using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace fantasy_app.Domain.Services.PasswordServices
{
    public class PasswordService : IPasswordService
    {
        public bool CheckIsPasswordIsConfirmed(string password, string confirmedPassword)
        {
            if (password == confirmedPassword)
                return true;
            return false;
        }
    }
}
