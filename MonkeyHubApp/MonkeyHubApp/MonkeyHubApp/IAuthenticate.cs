﻿using Microsoft.WindowsAzure.MobileServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonkeyHubApp
{
    public interface IAuthenticate
    {
        Task<MobileServiceUser> Authenticate(MobileServiceClient client,
            MobileServiceAuthenticationProvider provider);
    }
}
