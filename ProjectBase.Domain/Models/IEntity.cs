using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectBase.Domain.Models
{
    interface IEntity<TPrimaryKey>
    {
        #region Properties

        TPrimaryKey Id { get; }

        #endregion
    }
}
