﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectBase.Domain.Models
{
    public interface ISoftDelete
    {
        /// <summary>
        /// Used to mark an Entity as 'Deleted'. 
        /// </summary>
        bool IsDeleted { get; set; }
    }
}
