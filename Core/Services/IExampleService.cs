using Core.Data.Models;
using System.Collections.Generic;

namespace Core.Services
{
    public partial interface IExampleService
    {
        IEnumerable<Example> GetAll();
    }
}
