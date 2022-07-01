using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogsViewer_
{
    internal class Log
    {
    public int Id{ get; set; }
    public int EntryId{ get; set; }
    public int Operation{ get; set; }
    public DateTime Date{ get; set; }
    public int EntityType{ get; set; }
    }
}
