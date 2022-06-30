using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
namespace LogsViewer_
{
    public partial class ConfigEditorForm : Form
    {
        public ConfigEditorForm()
        {
            InitializeComponent();
        }
        private void ConfigEditorForm_Load(object sender, EventArgs e)
        {
            string path = "connectionConfigs.json";
            List < ConnectionConfig > jt = new List<ConnectionConfig> ();
            if (!File.Exists(path)){
                MessageBox.Show("Файла не существует");
                return;
                
            }
            try
            {
                string s = File.ReadAllText(path);
                jt = JsonConvert.DeserializeObject<List<ConnectionConfig>>(s);
            
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            for (int i = 0; i < jt.Count; i++)
            {
            dataGridView1.Rows.Add (jt[i].get());
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path = "connectionConfigs.json";
            checkToNull(dataGridView1);
            string s = "[";
            ConnectionConfig[] cc = formArray(dataGridView1);
            string[] res = new string[cc.Length];
            for(int i = 0;i < res.Length;i++){
            
            res[i] = JsonConvert.SerializeObject(cc[i]);
                if (i != res.Length - 1)
                {
                    s += res[i] + ",";
                }else{
                    s += res[i];
                }
            }
            s += "]";
            if(!File.Exists(path)){
                File.Create(path).Close();
            }
            System.IO.File.WriteAllText(path, s);

        }
        public bool checkToNull(DataGridView dt ){
            bool flag = true;
            for (int i = 0; i < dt.RowCount - 1; i++)
            {
                try
                {
                    if (dt[0, i].Value == null && dt[0, i].Value.ToString().Length < 1)
                    {
                        MessageBox.Show("GG");
                        flag = false;
                    }
                }
                catch (Exception ex)
                {
                    flag = false;
                }
            }
            return flag;

        }
        ConnectionConfig[] formArray(DataGridView dt){
        ConnectionConfig[] result = new ConnectionConfig[dt.Rows.Count - 1];
            for (int i = 0; i < dt.Rows.Count - 1; i++)
            {
                if (dt[1, i].Value != null)
                {
                    result[i] = new ConnectionConfig(dt[0, i].Value.ToString(), dt[1, i].Value.ToString());
                }
                else
                {
                    result[i] = new ConnectionConfig(dt[0, i].Value.ToString(), "");
                }
            }
        return result;
        }
    }
}
