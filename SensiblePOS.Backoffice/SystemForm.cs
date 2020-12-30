using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Threading.Tasks;
using System.Windows.Forms;

using SensiblePOS.Backoffice.Models;
using SensiblePOS.Data;

namespace SensiblePOS.Backoffice
{
    public partial class SystemForm : Form
    {
        private SensiblePOSContext _context = null;

        private List<Zone> _zones = new List<Zone>();
        private BindingSource zoneBindingSource = null;
        private BindingSource queueBindingSource = null;

        private ResourceManager _locRM = new ResourceManager("SensiblePOS.Backoffice.Resources.SystemForm", typeof(SystemForm).Assembly);
        public SystemForm(SensiblePOSContext context)
        {
            _context = context;
            InitializeComponent();
            BuildGridViewAndBindingSource();
            BuildVatTypeComboBox();
            BuildZoneQueueComboBox();
        }

        private void SystemForm_Load(object sender, EventArgs e)
        {
            var systemValues = _context.SystemInfos.ToDictionary(s => s.Name, s => s.Value);
            // Receipt.
            printHeaderTextBox.Text = GetSystemConfiguration<string>(systemValues, "RECEIPT_HEADER", "").Replace("\n", "\r\n");
            printTailerTextBox.Text = GetSystemConfiguration<string>(systemValues, "RECEIPT_TAILER", "").Replace("\n", "\r\n");
            printQtyNumeric.Value = GetSystemConfiguration<int>(systemValues, "PRINT_COPY", 2);

            // Vat.
            vatTypeComboBox.SelectedValue = GetSystemConfiguration<string>(systemValues, "VAT_TYPE", "include");
            vatNumeric.Value = GetSystemConfiguration<decimal>(systemValues, "VAT", 7.0m);

            // Service charge.
            enableServicechargeCheckBox.Checked = GetSystemConfiguration<bool>(systemValues, "SERVICE_CHARGE_ENABLE", false);
            servicechargeNumeric.Value = GetSystemConfiguration<decimal>(systemValues, "SERVICE_CHARGE", 15.0m);

            // Promptpay.
            enablePromptpayCheckBox.Checked = GetSystemConfiguration<bool>(systemValues, "PROMPTPAY_ENABLE", false);
            promptpayIdTextBox.Text = GetSystemConfiguration<string>(systemValues, "PROMPTPAY_ID", "");

            // Queue.
            enableQueueCheckBox.Checked = GetSystemConfiguration<bool>(systemValues, "QUEUE_ENABLE", false);
            RefreshQueueData();

            // Zone.
            _zones = _context.Zones.Where(z => !z.Inactive).OrderBy(z => z.Id).ToList();
            zoneBindingSource.DataSource = _zones;
            zoneBindingSource.ResetBindings(false);
        }

        private void resetQueuButton_Click(object sender, EventArgs e)
        {
            var current = queueBindingSource.Current as ZoneQueueInfo;
            if (current != null)
            {
                string msg = string.Format(_locRM.GetString("DIALOG_MSG_RESET_QUEUE"), current.ZoneName);
                if (MessageBox.Show(msg, _locRM.GetString("DIALOG_TITLE_RESET_QUEUE"), MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    var target = _context.ZoneQueues.Where(q => q.Id == current.Id).Single();
                    target.CurrentQueue = 0;
                    target.UpdateDate = DateTime.Now;
                    _context.SaveChanges();
                    current.Current = 0;
                    QueueBindingSource_CurrentChanged(this, null);
                }
            }
        }

        private void addZoneButton_Click(object sender, EventArgs e)
        {
            using (var setForm = new InputForm())
            {
                setForm.Text = _locRM.GetString("ADD_NEW_ZONE");
                if (setForm.ShowDialog() == DialogResult.OK)
                {
                    var newZone = new Zone
                    {
                        Title = setForm.Value,
                        ColorCode = "#ffffff",
                        Inactive = false
                    };
                    _context.Zones.Add(newZone);
                    _context.SaveChanges();
                    _zones.Add(newZone); 
                    zoneBindingSource.ResetBindings(false);
                    zoneBindingSource.MoveLast();
                }
            }
        }

        private void BuildGridViewAndBindingSource()
        {
            // Binding sources.
            // [Queuezone]
            queueBindingSource = new BindingSource();
            queueBindingSource.DataSource = typeof(ZoneQueueInfo);
            queueBindingSource.CurrentChanged += QueueBindingSource_CurrentChanged;
            // [Zone]
            zoneBindingSource = new BindingSource();
            //zoneBindingSource.DataSource = typeof(Zone);

            // Gridview.
            // [Zone].
            var zoneIdTextBoxColumn = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Id",
                HeaderText = "Id",
                MinimumWidth = 40,
                Width = 50,
                ReadOnly = true,
            };
            var zoneTitleTextBoxColumn = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Title",
                HeaderText = "Title",
                MinimumWidth = 8,
                AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill,
                ReadOnly = true,
            };
            zoneGridView.AutoGenerateColumns = false;
            zoneGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                zoneIdTextBoxColumn,
                zoneTitleTextBoxColumn});
            zoneGridView.DataSource = zoneBindingSource;
        }

        private void BuildVatTypeComboBox()
        {
            var methods = new List<KeyValuePair<string, string>>();

            methods.Add(new KeyValuePair<string, string>("include", "Include VAT"));
            methods.Add(new KeyValuePair<string, string>("exclude", "Exclude VAT"));
            methods.Add(new KeyValuePair<string, string>("none", "No VAT"));
            
            vatTypeComboBox.DisplayMember = "Value";
            vatTypeComboBox.ValueMember = "Key";
            vatTypeComboBox.DataSource = new BindingSource(methods, null);
        }
        
        private void BuildZoneQueueComboBox()
        {
            queueZoneComboBox.DisplayMember = "ZoneName";
            queueZoneComboBox.ValueMember = "Id";
            queueZoneComboBox.DataSource = queueBindingSource;
        } 

        private void saveButton_Click(object sender, EventArgs e)
        {
            var systemValues = _context.SystemInfos.ToDictionary(s => s.Name);

            // Receipt.
            systemValues["RECEIPT_HEADER"].Value = printHeaderTextBox.Text.Replace("\r\n", "\n");
            systemValues["RECEIPT_TAILER"].Value = printTailerTextBox.Text.Replace("\r\n", "\n");
            systemValues["PRINT_COPY"].Value = Convert.ToInt32(printQtyNumeric.Value).ToString();

            // Vat.
            systemValues["VAT_TYPE"].Value = vatTypeComboBox.SelectedValue.ToString();
            systemValues["VAT"].Value = vatNumeric.Value.ToString();

            // Service charge.
            systemValues["SERVICE_CHARGE_ENABLE"].Value = enableServicechargeCheckBox.Checked.ToString();
            systemValues["SERVICE_CHARGE"].Value = servicechargeNumeric.Value.ToString();

            // Promptpay.
            systemValues["PROMPTPAY_ENABLE"].Value = enablePromptpayCheckBox.Checked.ToString();
            systemValues["PROMPTPAY_ID"].Value = promptpayIdTextBox.Text;

            // Queue.
            systemValues["QUEUE_ENABLE"].Value = enableQueueCheckBox.Checked.ToString();

            _context.SaveChanges();

            MessageBox.Show(_locRM.GetString("DATA_SAVED"), this.Text, MessageBoxButtons.OK);
        }

        private void QueueBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            var current = queueBindingSource.Current as ZoneQueueInfo;
            if (current != null)
            {
                currentQueueLabel.Text = string.Format(_locRM.GetString("MASK_LAST_QUEUE"), current.Current);
            }
        }

        private void RefreshQueueData()
        {
            var queues = (from zq in _context.ZoneQueues
                          join z in _context.Zones on zq.ZoneId equals z.Id
                          where !zq.Inactive
                          orderby z.Title
                          select new ZoneQueueInfo
                          {
                              Id = zq.Id,
                              ZoneName = z.Title,
                              Current = zq.CurrentQueue
                          }).ToList();
            queueBindingSource.DataSource = queues;
            queueBindingSource.ResetBindings(false);
        }

        private T GetSystemConfiguration<T>(Dictionary<string, string> systems, string key, object defaultVal = null)
        {
            string value = "";
            systems.TryGetValue(key, out value);
            try
            {
                return (T)Convert.ChangeType(value, typeof(T));
            }
            catch (Exception ex)
            {
                return defaultVal != null ? (T)defaultVal : default(T);
            }
        }
    }
}
