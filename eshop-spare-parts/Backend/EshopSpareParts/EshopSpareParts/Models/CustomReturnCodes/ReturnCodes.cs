﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EshopSpareParts.Models.CustomReturnCodes
{
    public class ReturnCodes
    {
        public const int Ok = 200;

        public const int Created = 201;

        public const int BadRequest = 400;

        public const int Unauthorized = 401;

        public const int Forbidden = 403;

        public const int NotFound = 404;
    }
}