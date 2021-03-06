﻿using System;
using System.Threading.Tasks;
using Microsoft.Identity.Client;

namespace TheReviewer.Core
{
    public interface IIdentityService
    {
        Task<AuthenticationResult> Login();
        Task<AuthenticationResult> GetCachedSignInToken();
        Task<AuthenticationResult> ResetPassword();
        Task<AuthenticationResult> EditProfile();
        void Logout();
        UIParent UIParent { get; set; }
    }
}
