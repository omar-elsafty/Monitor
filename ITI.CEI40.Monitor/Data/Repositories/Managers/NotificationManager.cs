﻿using ITI.CEI40.Monitor.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ITI.CEI40.Monitor.Data.Repositories.Managers.Interfaces
{
    public class NotificationManager : Reposiotry<ApplicationDbContext,Notification> , INotificationManager
    {
        public NotificationManager(ApplicationDbContext context) :base(context)
        {
        }


    }
}
