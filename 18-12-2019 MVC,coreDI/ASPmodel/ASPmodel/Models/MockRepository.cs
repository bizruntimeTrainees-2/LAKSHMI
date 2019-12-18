using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPmodel.Models
{
    public class MockRepository : ModelRepository
    {
        private List<Models> _modelList;

        public MockRepository()
        {
            _modelList = new List<Models>()
            {
                new Models() {Id = 1,Name = "Mary",Department = "HR",Email = "mary@gmail.com"},
                new Models() {Id = 2,Name = "sana",Department = "IT",Email = "sana@gmail.com"},
                new Models() {Id = 3,Name = "krishna",Department = "PayRoll",Email = "krishna@gmail.com"},
            };

        }
        public Models GetModels(int Id)
        {
            return _modelList.FirstOrDefault(e => e.Id == Id);
        }
    }
}
