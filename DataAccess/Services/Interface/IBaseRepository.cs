using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities.Abstract;

namespace DataAccess.Services.Interface
{
    public interface IBaseRepository<T> where T : BaseEntity
    {
    }
}
