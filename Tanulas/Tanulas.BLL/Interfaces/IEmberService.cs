using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tanulas.DAL.Entities;

namespace Tanulas.BLL.Interfaces
{
    public interface IEmberService
    {
        IEnumerable<Ember> GetEmberek();
    }
}
