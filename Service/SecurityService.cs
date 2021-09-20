﻿using Milestone.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Milestone.Service
{
    /**
     * Class in charge of authenticating the user with the database
     * @TODO - Implement
     */
    public class SecurityService
    {
        SecurityDA secure = new SecurityDA();

        public bool IsValid(UserModel user)
        {
            return secure.findUser(user);
        }

        public bool CreateUser(UserModel user)
        {
            return secure.createUser(user);
        }

    }
}
