﻿using ClientEntities.Account;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mega.Engine.Interfaces
{
    public interface IAccountEngine
    {
        LoginResponse Login(LoginRequest request);
    }
}
