﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib.Dal
{
    public static class RepositoryFactory
    {
        public static IRepository GetRepo() => new Repository();
    }
}
