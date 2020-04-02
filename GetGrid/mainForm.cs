using System;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic.FileIO;
using System.Collections.ObjectModel;
using System.Diagnostics;

namespace GetGrid
{
    public partial class mainForm : Form
    {
        string appDirectory;
        string tableNameFilePath;
        string configFilePath;
        AppConfig cfg;

        public mainForm()
        {
            appDirectory = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\GetGrid";
            Directory.CreateDirectory(appDirectory);
            tableNameFilePath = appDirectory + @"\tableName.txt";
            configFilePath = appDirectory + @"\config.txt";
            cfg = new AppConfig(configFilePath);
            cfg.ReadConfigXml();

            InitializeComponent();

            try
            {
                using (StreamReader streamReader = new StreamReader(tableNameFilePath, Encoding.Default))
                {
                    while (streamReader.Peek() >= 0) cmbTableName.Items.Add(streamReader.ReadLine());
                }
            }
            catch { }
        }

        private void btnRefreshGrid_Click(object sender, EventArgs e)
        {
            try
            {
                Collection<string> lines = new Collection<string>();
                string tsv = "";
                IDataObject data = Clipboard.GetDataObject();
                if (data.GetDataPresent(DataFormats.Text)) tsv = (string)data.GetData(DataFormats.Text);
                else throw new Exception("クリップボードにテーブル形式のデータがありません");

                if (tsv.Length > 100000)
                {
                    string msg = "";
                    msg += "長さ" + tsv.Length + "のデータを読み込もうとしています。" + Environment.NewLine;
                    msg += "環境によっては時間がかかったり動作停止する恐れがあります。" + Environment.NewLine;
                    msg += "続行しますか？";
                    DialogResult result = MessageBox.Show(msg, "警告",
                        MessageBoxButtons.OKCancel,
                        MessageBoxIcon.Exclamation,
                        MessageBoxDefaultButton.Button2);
                    if (result == DialogResult.Cancel) return;
                }

                using (Stream stream = new MemoryStream(Encoding.Default.GetBytes(tsv)))
                {
                    TextFieldParser parser = new TextFieldParser(stream, Encoding.GetEncoding("shift_jis"));
                    parser.TrimWhiteSpace = false;
                    parser.TextFieldType = FieldType.Delimited;
                    parser.SetDelimiters("\t");
                    dataGridView.Columns.Clear();
                    dataGridView.Rows.Clear();
                    string[] colheaders = parser.ReadFields();
                    for (int i = 0, n = colheaders.Length; i < n; i++)
                    {
                        dataGridView.Columns.Add(colheaders[i], colheaders[i]);
                    }
                    while (!parser.EndOfData)
                    {
                        string[] row = parser.ReadFields();
                        dataGridView.Rows.Add(row);
                    }
                }
                info.Text = "クリップボードのテーブルを読み込みました";
            }
            catch (Exception ex)
            {
                info.Text = "Error: " + ex.Message;
            }
        }

        private void btnGetInsert_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView.RowCount == 0) throw new Exception("データがありません");
                string sqlFilePath = appDirectory + @"\" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".txt";
                string tableName = cmbTableName.Text;
                if (!cmbTableName.Items.Contains(tableName)) cmbTableName.Items.Add(tableName);
                
                string[] row = new string[dataGridView.ColumnCount];
                for (int i = 0, n = dataGridView.ColumnCount; i < n; i++)
                {
                    row[i] = dataGridView.Columns[i].HeaderText;
                }
                string header = "INSERT INTO " + tableName + " (" + string.Join(",", row) + ") VALUES ";
                using (StreamWriter streamWriter = new StreamWriter(sqlFilePath, false, Encoding.GetEncoding("shift_jis")))
                {
                    for (int i = 0, n = dataGridView.RowCount; i < n; i++)
                    {
                        for (int j = 0, m = dataGridView.ColumnCount; j < m; j++)
                        {
                            row[j] = FomuraValues((string)dataGridView[j, i].Value);
                        }
                        streamWriter.WriteLine(header + "(" + string.Join(",", row) + ")" + cfg.Separator);
                    }
                }
                Process.Start(sqlFilePath);
                info.Text = "INSERT文の生成が完了しました";
            }
            catch (Exception ex)
            {
                info.Text = "Error: " + ex.Message;
            }
        }

        private void btnGetUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView.RowCount == 0) throw new Exception("データがありません");
                string sqlFilePath = appDirectory + @"\" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".txt";
                string tableName = cmbTableName.Text;
                if (!cmbTableName.Items.Contains(tableName)) cmbTableName.Items.Add(tableName);

                string[] header = new string[dataGridView.ColumnCount];
                for (int i = 0, n = dataGridView.ColumnCount; i < n; i++)
                {
                    header[i] = dataGridView.Columns[i].HeaderText;
                }
                int blankColIndex = Array.IndexOf(header, string.Empty);
                if (blankColIndex == -1) throw new Exception("UPDATEの生成には空白列が必要です");
                string[] row = new string[dataGridView.ColumnCount];
                using (StreamWriter streamWriter = new StreamWriter(sqlFilePath, false, Encoding.GetEncoding("shift_jis")))
                {
                    for (int i = 0, n = dataGridView.RowCount; i < n; i++)
                    {
                        string[] setFomura = new string[row.Length - blankColIndex - 1];
                        for (int j = 0, m = setFomura.Length; j < m; j++)
                        {
                            setFomura[j] = FomuraSet(header[blankColIndex + 1 + j], (string)dataGridView[blankColIndex + 1 + j, i].Value);
                        }
                        string[] whereFomura = new string[blankColIndex];
                        for (int j = 0, m = whereFomura.Length; j < m; j++)
                        {
                            whereFomura[j] = FomuraWhere(header[j], (string)dataGridView[j, i].Value);
                        }
                        streamWriter.WriteLine("UPDATE " + tableName + " SET " + string.Join(",", setFomura) + " WHERE " + string.Join(" AND ", whereFomura) + cfg.Separator);
                    }
                }
                Process.Start(sqlFilePath);
                info.Text = "UPDATE文の生成が完了しました";
            }
            catch (Exception ex)
            {
                info.Text = "Error: " + ex.Message;
            }
        }

        private void btnGetDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView.RowCount == 0) throw new Exception("データがありません");
                string sqlFilePath = appDirectory + @"\" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".txt";
                string tableName = cmbTableName.Text;
                if (!cmbTableName.Items.Contains(tableName)) cmbTableName.Items.Add(tableName);

                string[] header = new string[dataGridView.ColumnCount];
                for (int i = 0, n = dataGridView.ColumnCount; i < n; i++)
                {
                    header[i] = dataGridView.Columns[i].HeaderText;
                }
                string[] row = new string[dataGridView.ColumnCount];
                using (StreamWriter streamWriter = new StreamWriter(sqlFilePath, false, Encoding.GetEncoding("shift_jis")))
                {
                    for (int i = 0, n = dataGridView.RowCount; i < n; i++)
                    {
                        for (int j = 0, m = dataGridView.ColumnCount; j < m; j++)
                        {
                            row[j] = FomuraWhere(header[j], (string)dataGridView[j, i].Value);
                        }
                        streamWriter.WriteLine("DELETE FROM " + tableName + " WHERE " + string.Join(" AND ", row) + cfg.Separator);
                    }
                }
                Process.Start(sqlFilePath);
                info.Text = "DELETE文の生成が完了しました";
            }
            catch (Exception ex)
            {
                info.Text = "Error: " + ex.Message;
            }
        }

        private void mainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            using (StreamWriter streamWriter = new StreamWriter(tableNameFilePath, false, Encoding.GetEncoding("shift_jis")))
            {
                foreach (string tableName in cmbTableName.Items)
                {
                    streamWriter.WriteLine(tableName);
                }
            }
        }

        private void miTableNameDelete_Click(object sender, EventArgs e)
        {
            string tableName = cmbTableName.Text;
            if (cmbTableName.Items.Contains(tableName)) cmbTableName.Items.Remove(tableName);
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            menuConfig.Show(Cursor.Position);
        }

        private void miOpenLog_Click(object sender, EventArgs e)
        {
            Process.Start(appDirectory);
        }

        private void miOpenConfig_Click(object sender, EventArgs e)
        {
            AppConfig cfgResult = ConfigForm.ShowDialogAndGetResult(cfg);
            if (cfgResult == null) return;
            cfg = cfgResult;
            cfg.WriteConfigXml();
        }

        private string FomuraSet(string header, string value)
        {
            string fomura = null;
            fomura = header + "=" + cfg.QuotePre + "'" + value + "'";
            return fomura;
        }

        private string FomuraWhere(string header, string value)
        {
            string fomura = null;
            if(value.Equals(cfg.AsNull)) fomura = header + " IS NULL";
            else fomura = header + "=" + cfg.QuotePre + "'" + value + "'";
            return fomura;
        }

        private string FomuraValues(string value)
        {
            string fomura = null;
            if (value.Equals(cfg.AsNull)) fomura = "NULL";
            else fomura = cfg.QuotePre + "'" + value + "'";
            return fomura;
        }

        private void miHelp_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"https://tyspine.com/pub-getgrid");
        }
    }
}
