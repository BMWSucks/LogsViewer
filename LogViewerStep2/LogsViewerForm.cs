using LogsViewer_;
namespace LogViewerStep2
{
    public partial class LogsViewerForm : Form
    {
        List<LogDetails> logDetailsList = new List<LogDetails>();
        List<Log> logList = new List<Log>();
        public LogsViewerForm()
        {
            InitializeComponent();
        }

        private void LogsViewerForm_Load(object sender, EventArgs e)
        {
            string[] arrayLogText = File.ReadAllText("Logs.txt").Split('\n');
            for (int i = 0; i < arrayLogText.Length; i++)
            {
                string[] logLine = arrayLogText[i].Split('\t');
                logList.Add(Log.createLog(logLine));
                dataGridView1.Rows.Add(logLine);
            }
            string[] arrayLogDetailsText = File.ReadAllText("LogDetails.txt").Split('\n');
            for (int i = 0; i < arrayLogDetailsText.Length; i++)
            {
                string[] logDetailsLine = arrayLogDetailsText[i].Split('\t');
                logDetailsList.Add(LogDetails.createLogDetails(logDetailsLine));
                dataGridView2.Rows.Add(logDetailsLine);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentCell.ColumnIndex != 0)
            {
                return;
            }
            dataGridView2.Rows.Clear();
            foreach (LogDetails logDetails in logDetailsList)
            {
                if (logDetails.LogId == int.Parse(dataGridView1.CurrentCell.Value.ToString()))
                {
                    dataGridView2.Rows.Add(logDetails.get());
                }
            }
        }
    }
}