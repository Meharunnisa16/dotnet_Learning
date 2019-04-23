using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi1.Models;

namespace WebApi1.services
{
    public class DataServices : IDataServices
    {
        private readonly Dictionary<string, DataValues> _dataValues;

        public DataServices()
        {
            _dataValues = new Dictionary<string, DataValues> ();
        }
        public DataValues AddDataValues(DataValues values)
        {
            _dataValues.Add(values.Name, values);

            return values;
        }

        public Dictionary<string, DataValues> GetDataValues()
        {
            return _dataValues;
        }
    }
}
