using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogsViewer_
{
    internal class LogDetails
    {
        public int Id { get; set; }
        public int LogId { get; set; }
        public string PropertyName { get; set; }
        public string NewValue { get; set; }
        public string OldValue { get; set; }
    }
}
