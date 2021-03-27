using System.Collections.Generic;
using Restapi.Models;

namespace Restapi.Data
{
    public interface ICommandsRepo
    {
        IEnumerable<apis> GetData();
        apis GetDataById(int id);
    }
}