﻿using Core.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entity.Concrete
{
    public class OperationClaim:IEntity
    {
        public int OparationClaimId { get; set; }
        public string Name { get; set; }
    }
}
