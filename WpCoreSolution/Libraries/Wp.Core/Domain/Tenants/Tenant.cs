﻿using System;
using System.Collections.Generic;
using System.Text;
using Wp.Common;

namespace Wp.Core.Domain.Tenants
{
    public class Tenant : Entity
    {
        public Guid TenantId { get; set; }
        public string TenantName { get; set; }
        public string ConnectionString { get; set; }
    }
}
