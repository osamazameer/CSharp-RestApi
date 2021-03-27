using System.Collections.Generic;
using Restapi.Models;

namespace Restapi.Data
{
    public class MockCommandsRepo : ICommandsRepo
    {
        public IEnumerable<apis> GetData()
        {
            var requests = new List<apis>
            {
                new apis{Id=0, Name="Osama", Designation="Frontend Developer" },
                new apis { Id = 0, Name = "Shujja", Designation = "Frontend Developer" },
            };
            return requests;
        }
        public apis GetDataById(int id)
        {
            return new apis { Id = 0, Name = "Shujja", Designation = "Frontend Developer" }
        }

    }
}