using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Backend4.Services
{
    public interface ISignUpCheckService
    {
        bool Registrate(String firstname, String lastname, Int32 day, Int32 month, Int32 year, String gender);
    }
}
