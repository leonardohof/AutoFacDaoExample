using Core.Data.Models;
using System.Collections.Generic;

namespace Core.Data
{
    public interface IBusinessLogic<Entity> where Entity : BaseEntity
    {
        Entity GetById(int id);

        IEnumerable<Entity> GetAll();
    }
}
