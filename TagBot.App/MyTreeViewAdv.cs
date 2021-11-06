using Aga.Controls.Tree;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TagBot.App
{
    class MyTreeViewAdv : TreeViewAdv
    {
        [Browsable(true)]
        [Category("Custom Behavior")]
        [Description("Custom TreeViewAdv")]
        [DisplayName("MyTreeViewAdv")]

        public void AutoSizeColumns(ColumnHeaderAutoResizeStyle headerAutoSize)
        {
            if (Columns.Count <= 0)
                throw new Exception("Treeviewadv doesn't contain any columns");
            foreach (TreeColumn tc in Columns)
                AutoSizeColumn(tc, headerAutoSize);
        }
        public void AutoSizeColumn(TreeColumn col, ColumnHeaderAutoResizeStyle headerAutoSize)
        {
            if (!Columns.Contains(col))
                throw new ArgumentException("column is not a part of treeviewadv", "col");
            if (headerAutoSize == ColumnHeaderAutoResizeStyle.None)
                return;
            int tempWidth = TextRenderer.MeasureText(col.Header, _measureContext.Font).Width + 3;
            if (col.SortOrder != SortOrder.None)
            {
                tempWidth += col.SortMarkSize.Width + 8;
            }
            foreach (TreeNodeAdv tna in VisibleNodes)
            {
                foreach (NodeControlInfo nci in GetNodeControls(tna))
                {
                    if (nci.Control.ParentColumn == col)
                    {
                        int nWidth = 0;
                        Size sizeCntrl = nci.Control.GetActualSize(tna, _measureContext);
                        if (col.Index == 0)
                            nWidth += nci.Bounds.X;
                        if (!sizeCntrl.IsEmpty)
                            tempWidth = Math.Max(tempWidth, (sizeCntrl.Width + nWidth));
                        if (headerAutoSize == ColumnHeaderAutoResizeStyle.HeaderSize)
                        {
                            Size sizeText = TextRenderer.MeasureText(col.Header, _measureContext.Font);
                            if (!sizeText.IsEmpty)
                            {
                                int textWidth = sizeText.Width;
                                if (col.SortOrder != SortOrder.None)
                                    textWidth += col.SortMarkSize.Width + 8; //SortOrderMarkMargin
                                tempWidth = Math.Max(tempWidth, textWidth + 3);
                            }
                        }
                    }
                }
            }
            col.Width = tempWidth;
        }
    }
}
