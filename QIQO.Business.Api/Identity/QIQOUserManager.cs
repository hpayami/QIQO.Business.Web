﻿using System;
using System.Collections.Generic;
using Microsoft.Extensions.Logging;
using QIQO.Business.Client.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Options;
using Microsoft.AspNetCore.Builder;

namespace QIQO.Business.Identity
{
    public class QIQOUserManager : UserManager<User>
    {
        public QIQOUserManager(IUserStore<User> store, IOptions<IdentityOptions> optionsAccessor, 
            IPasswordHasher<User> passwordHasher, IEnumerable<IUserValidator<User>> userValidators, 
            IEnumerable<IPasswordValidator<User>> passwordValidators, ILookupNormalizer keyNormalizer, 
            IdentityErrorDescriber errors, IServiceProvider services, ILogger<UserManager<User>> logger, 
            IHttpContextAccessor contextAccessor) : 
            base(store, optionsAccessor, passwordHasher, userValidators, passwordValidators, keyNormalizer, errors, services, logger) //, contextAccessor)
        {
        }
    }
}