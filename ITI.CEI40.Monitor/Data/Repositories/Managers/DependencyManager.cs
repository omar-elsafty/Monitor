﻿using ITI.CEI40.Monitor.Data.Repositories.Managers.Interfaces;
using ITI.CEI40.Monitor.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ITI.CEI40.Monitor.Data.Repositories.Managers
{
    public class DependencyManager : Reposiotry<ApplicationDbContext, Dependencies>, IDependencyManager
    {
        public DependencyManager(ApplicationDbContext context) : base(context)
        {
        }
    }
}
