using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;
using USPolitics.Service.DTOs;

namespace USPolitics.Service.Interfaces
{
    public interface IAccountManager
    {
        void Register(RegisterDTO registerDto);
        JObject Login(LoginDTO loginDto);
    }
}
