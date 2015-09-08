using System.Collections.Generic;
using Core.Data.Models;
using Core.Data;

namespace Core.Services
{
    public class ExampleService : IExampleService
    {
        private readonly IBusinessLogic<Example> _exampleBL;

        public ExampleService(IBusinessLogic<Example> exampleBL)
        {
            this._exampleBL = exampleBL;
        }

        public IEnumerable<Example> GetAll()
        {
            return this._exampleBL.GetAll();
        }
    }
}
