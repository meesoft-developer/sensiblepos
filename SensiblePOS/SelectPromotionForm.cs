using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Windows.Forms;

using SensiblePOS.Data;
using SensiblePOS.Models;

namespace SensiblePOS
{
    public partial class SelectPromotionForm : Form
    {
        public PromotionInfo SelecedtPromotion { get; set; }
        public SensiblePOSContext Context { get; set; }

        private ResourceManager _locRM = new ResourceManager("SensiblePOS.Resources.SelectPromotionForm", typeof(SelectPromotionForm).Assembly);

        public SelectPromotionForm()
        {
            InitializeComponent();
        }

        private void SelectPromotionForm_Load(object sender, EventArgs e)
        {
            var listPromotions = Context.Promotions.Where(p => !p.Inactive && p.ShowInList && p.Effective <= DateTime.Now && p.Expire >= DateTime.Now && !p.HasSubSchedule);

            var listPromoInSubSch = from p in Context.Promotions
                                    join sch in Context.PromotionSubSchedules on p.Id equals sch.PromotionId
                                    where !p.Inactive && p.ShowInList && p.HasSubSchedule
                                    && sch.EffectiveDate <= DateTime.Now && sch.ExpireDate >= DateTime.Now
                                    select p;
            var finalList = (from p in listPromotions.Union(listPromoInSubSch)
                             select new PromotionInfo
                             {
                                 Id = p.Id,
                                 ItemCode = p.Code,
                                 Title = p.Title,
                                 Description = p.Description,
                                 PercentDC = p.PercentDc,
                                 ValueDC = p.ValueDc,
                                 MaximumDC = p.MaximumDc,
                                 HasAttachProduct = p.HasAttachItem,
                                 EffectProductId = p.TargetProductId,
                                 LimitedProductQty = p.LimitProductQty,
                                 HasCondition = p.HasCondition,
                                 MeetCondition = false,// !p.HasCondition
                             }).ToList();
            promotionInfoBindingSource.DataSource = finalList;
            promotionInfoBindingSource.ResetBindings(false);

            findPromotionTextBox.Focus();
            findPromotionTextBox.Select();
        }

        private void findPromotionTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (!string.IsNullOrEmpty(findPromotionTextBox.Text))
                {
                    var code = findPromotionTextBox.Text;
                    var target = Context.Promotions.FirstOrDefault(p => p.Code == code && !p.Inactive && p.Effective <= DateTime.Now && p.Expire >= DateTime.Now);
                    if (target != null)
                    {
                        bool isEffect = true;
                        if (target.HasSubSchedule)
                        {
                            var time = Context.PromotionSubSchedules.FirstOrDefault(s => s.PromotionId == target.Id && s.EffectiveDate <= DateTime.Now && s.ExpireDate >= DateTime.Now);
                            isEffect = (time != null);
                        }

                        if (isEffect)
                        {
                            SelecedtPromotion = new PromotionInfo
                            {
                                Id = target.Id,
                                ItemCode = target.Code,
                                Title = target.Title,
                                Description = target.Description,
                                EffectProductId = target.TargetProductId,
                                HasAttachProduct = target.HasAttachItem,
                                LimitedProductQty = target.LimitProductQty,
                                PercentDC = target.PercentDc,
                                ValueDC = target.ValueDc,
                                MaximumDC = target.MaximumDc,
                                HasCondition = target.HasCondition,
                                MeetCondition = false,
                            };
                            promotionNameLabel.Text = target.Title;
                            okButton.Select();
                            e.Handled = false;
                            return;
                        }
                    }
                    MessageBox.Show(_locRM.GetString("DIALOG_MSG_PROMOTION_NOT_FOUND"), _locRM.GetString("DIALOG_TITLE_FIND_PROMOTION"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                e.Handled = false;
                return;
            }
        }

        private void canceButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void promotionInfoBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            var selected = promotionInfoBindingSource.Current as PromotionInfo;
            if (selected != null)
            {
                SelecedtPromotion = selected;
            }
        }

        private void promotionDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
