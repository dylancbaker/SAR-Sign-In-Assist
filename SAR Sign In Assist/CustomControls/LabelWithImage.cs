using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAR_Sign_In_Assist.CustomControls
{
    public partial class LabelWithImage : UserControl
    {
        [Description("Text displayed on the label portion"), Category("Appearance")]
        public string Txt { get => lbl.Text; set => lbl.Text = value; }
        [Description("Image shown in the Picture portion"), Category("Appearance")]
        public Image Img { get => pic.Image; set => pic.Image = value; }
        [Description("Font for the label"), Category("Appearance")]
        public Font LabelFont { get => lbl.Font; set => lbl.Font = value; }

        public LabelWithImage()
        {
            InitializeComponent();
        }
    }
}
