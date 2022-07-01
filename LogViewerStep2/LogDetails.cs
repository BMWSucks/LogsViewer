using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogsViewer_
{
    internal class LogDetails
    {
        public LogDetails(int id, int logId, string propertyName, string newValue, string oldValue)
        {
            Id = id;
            LogId = logId;
            PropertyName = propertyName;
            NewValue = newValue;
            OldValue = oldValue;
        }
        public static LogDetails createLogDetails(string[] s) {
            LogDetails logDetails = new LogDetails(int.Parse(s[0]), int.Parse(s[1]),s[2], s[3],s[4]);
            return logDetails;
        }
        public string[] get(){
        string[] s = new string[]{Id + "",LogId + "",PropertyName,NewValue,OldValue};
            return s;
        }

        public int Id { get; set; }
        public int LogId { get; set; }
        public string PropertyName { get; set; }
        public string NewValue { get; set; }
        public string OldValue { get; set; }
    }
}
