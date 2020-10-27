using System;
using System.Drawing;
using System.ComponentModel;
using System.Windows.Forms;
using System.Drawing.Design;
using System.Runtime.InteropServices;

namespace SoftLiu_LibraryWinFormCustomComponent.Button
{
    [DefaultEvent("ReadOnlyChanged")]
    public class CustomRadioButton : RadioButton
    {
        [DefaultValue(false)]
        [RefreshProperties(RefreshProperties.Repaint)]
        //[SRCategoryAttribute("CatBehavior")]
        //[SRDescriptionAttribute("RadioButtonReadOnlyDescr")]
        public bool ReadOnly { get; set; }

        protected override void OnClick(EventArgs e)
        {
            if (!ReadOnly)
                base.OnClick(e);
        }

        // 定义委托
        public event EventHandler ReadOnlyChanged;
        protected virtual void OnReadOnlyChanged(object sender, EventArgs e)
        {
            if (ReadOnlyChanged != null)
            {
                ReadOnlyChanged(sender, e);
            }
        }
    }
}
