using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace DXWebApplication1.SpillGlass
{
    public partial class PurchaseOrder : DevExpress.XtraReports.UI.XtraReport
    {
        public PurchaseOrder()
        {
            this.InvDocID.Description = "InvDocID";
            this.InvDocID.Name = "InvDocID";
            this.InvDocID.Type = typeof(int);
            this.InvDocID.ValueInfo = "38722";
            dynamicListLookUpSettings1.DataMember = "RptGetPODetails";
            dynamicListLookUpSettings1.DataSource = this.PurchaseOrderDB;
            dynamicListLookUpSettings1.DisplayMember = "InvDocID";
            dynamicListLookUpSettings1.FilterString = null;
            dynamicListLookUpSettings1.SortMember = null;
            dynamicListLookUpSettings1.ValueMember = "InvDocID";
            this.InvDocID.ValueSourceSettings = dynamicListLookUpSettings1;
            InitializeComponent();
        }

    }
}
