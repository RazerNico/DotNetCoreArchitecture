﻿using DotNetCoreArchitecture.SeedWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCoreArchitecture.Application.Interfaces
{
    public interface IDomainEventContext
    {
        IEnumerable<Event> GetDomainEvents();
    }
}
