﻿using Core.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Data
{
    public interface IBusinessLogic<Entity> where Entity : BaseEntity
    {
        Entity GetById(int id);

        IEnumerable<Entity> GetAll();
    }
}