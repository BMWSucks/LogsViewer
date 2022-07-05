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
            }
            dataGridView1.DataSource = logList;
            string[] arrayLogDetailsText = File.ReadAllText("LogDetails.txt").Split('\n');
            for (int i = 0; i < arrayLogDetailsText.Length; i++)
            {
                string[] logDetailsLine = arrayLogDetailsText[i].Split('\t');
                logDetailsList.Add(LogDetails.createLogDetails(logDetailsLine));
            }
            dataGridView2.DataSource = logDetailsList;
        }

        private void focusChanged(object sender, EventArgs e)
        {
            List<LogDetails> logDetailsVisible = new List<LogDetails>(); 
            foreach (LogDetails logDetails in logDetailsList)
            {
                int.TryParse(dataGridView1[0, dataGridView1.CurrentCell.RowIndex].Value.ToString(), out int result);
                if (result == logDetails.LogId)
                {
                    logDetailsVisible.Add(logDetails);
                }
            }
            dataGridView2.DataSource = logDetailsVisible;
        }
    }
}