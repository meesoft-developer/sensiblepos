using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace SensiblePOS.Backoffice.Utilities
{
    public static class ExportTools
    {
        public static string ShowSaveFileDialog(string reportName)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            string name = reportName + "_" + DateTime.Now.ToString("ddMMMMyy");
            int n = name.LastIndexOf(".") + 1;
            if (n > 0) name = name.Substring(n, name.Length - n);
            dlg.Title = "Export To CSV Document";
            dlg.FileName = name;
            dlg.Filter = "Comma Delimited|*.csv";
            if (dlg.ShowDialog() == DialogResult.OK) return dlg.FileName;
            return "";
        }

        public static void ExportGridViewToCSV(DataGridView view, List<string> summaryText, string path, Encoding encoding)
        {
            string forHash = "0";
            using (var textWriter = new System.IO.StreamWriter(path, false, encoding))
            {
                List<int> writeColumnIndex = new List<int>();
                foreach (var summary in summaryText)
                {
                    textWriter.WriteLine(summary);
                    forHash += summary.GetHashCode().ToString();
                }
                string headerText = "";
                for (int i = 0; i < view.Columns.Count; i++)
                {
                    if (view.Columns[i].Visible)
                    {
                        string header = view.Columns[i].HeaderText;
                        if (string.IsNullOrEmpty(headerText))
                            headerText = view.Columns[i].HeaderText;
                        else
                            headerText += "," + view.Columns[i].HeaderText;
                        writeColumnIndex.Add(i);
                    }
                }
                textWriter.WriteLine(headerText);
                forHash += headerText.GetHashCode().ToString();

                for (int i = 0; i < view.Rows.Count; i++)
                {
                    string dataText = "";
                    for (int j = 0; j < view.Columns.Count; j++)
                    {
                        if (writeColumnIndex.Contains(j))
                        {
                            var text = view.Rows[i].Cells[j].FormattedValue.ToString();
                            decimal a = 0;
                            if (view.Rows[i].Cells[j].ValueType == typeof(decimal) || decimal.TryParse(text, out a))
                                text = text.Replace(",", string.Empty); //Remove comma.
                            if (string.IsNullOrEmpty(dataText) && j == 0)
                                dataText = text;
                            else
                                dataText += "," + text;
                        }
                    }
                    textWriter.WriteLine(dataText);
                    forHash += dataText.GetHashCode().ToString();
                }
                textWriter.WriteLine(""); 

                //Add signature 
                byte[] hashBytes = BitConverter.GetBytes(forHash.GetHashCode());
                textWriter.WriteLine("Signature," + BitConverter.ToString(hashBytes).Replace("-", ""));
            }

            //stamp suignature
            System.IO.File.SetAttributes(path, System.IO.FileAttributes.ReadOnly);
        }
    }
}
