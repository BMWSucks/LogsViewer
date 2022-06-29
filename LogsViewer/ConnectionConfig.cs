using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft;

namespace LogsViewer_
{
    internal class ConnectionConfig
    {
        public ConnectionConfig(string laboratoryName, string connectionString)
        {
            LaboratoryName = laboratoryName;
            ConnectionString = connectionString;
        }

        public string LaboratoryName { get;set; }
        
        public string ConnectionString { get; set; }
        public override string ToString()
        {
            return LaboratoryName + ":" + ConnectionString;
        }
        public string[] get(){
        string[] ret = {LaboratoryName,ConnectionString};
            return ret;
        }
    }
}
