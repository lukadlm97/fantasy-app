using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace fantasy_app.Domain.Services.PasswordServices
{
    public interface IPasswordService
    {
        bool CheckIsPasswordIsConfirmed(string password, string confirmedPassword);
    }
}
