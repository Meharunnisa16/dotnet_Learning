using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi1.Models;

namespace WebApi1.services
{
    public interface IDataServices
    {
        DataValues AddDataValues(DataValues values);
       Dictionary<string, DataValues> GetDataValues(DataValues values);
    }
}
