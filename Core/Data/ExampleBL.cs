using Core.Data.Models;
using System.Collections.Generic;

namespace Core.Data
{
    public class ExampleBL : IBusinessLogic<Example>
    {
        public IEnumerable<Example> GetAll()
        {
            return new List<Example>()
            {
                new Example() { Id = 1, Title = "Test 1" },
                new Example() { Id = 2, Title = "Test 2" },
            };
        }

        public Example GetById(int id)
        {
            return new Example() { Id = id, Title = "No Title" };
        }
    }
}
