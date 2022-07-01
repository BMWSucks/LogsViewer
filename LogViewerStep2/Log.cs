using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogsViewer_
{
    internal class Log
    {
        public Log(int id,int userId, int entryId, int operation, DateTime date, int entityType)
        {
            Id = id;
            UserId = userId;
            EntryId = entryId;
            Operation = operation;
            Date = date;
            EntityType = entityType;
        }
        public static Log createLog(string[] s)
        {
            Log log = new Log(int.Parse(s[0]), int.Parse(s[1]), int.Parse(s[2]), int.Parse(s[3]), Convert.ToDateTime(s[4]), int.Parse(s[5]));
            return log;
        }

        public int Id{ get; set; }
        public int UserId{ get; set; }
    public int EntryId{ get; set; }
    public int Operation{ get; set; }
    public DateTime Date{ get; set; }
    public int EntityType{ get; set; }
    }
}
