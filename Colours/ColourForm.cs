using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColoursForm
{
    public partial class ColourForm : Form
    {
        private int hex_red = 125;
        private int hex_green = 125;
        private int hex_blue = 125;
        public ColourForm()
        {
            InitializeComponent();
        }

        private void labelRed_Click(object sender, EventArgs e)
        {
            TrackBar track_red = (TrackBar)sender;
            hex_red = track_red.Value;
            BoxBackColour();
            toolTipColour.SetToolTip(track_red, Convert.ToString(track_red.Value));
        }

        private void labelGreen_Click(object sender, EventArgs e)
        {
            TrackBar track_green = (TrackBar)sender;
            hex_green = track_green.Value;
            BoxBackColour();
            toolTipColour.SetToolTip(track_green, Convert.ToString(track_green.Value));
        }

        private void labelBlue_Click(object sender, EventArgs e)
        {
            TrackBar track_blue = (TrackBar)sender;
            hex_blue = track_blue.Value;
            BoxBackColour();
            toolTipColour.SetToolTip(track_blue, Convert.ToString(track_blue.Value));
        }

        private void BoxBackColour()
        {
            string hex_colour = "#" + $"{hex_red:X}" + $"{hex_green:X}" + $"{hex_blue:X}";
            Clipboard.SetText("hex_colour");
            toolTipColour.SetToolTip(ColourBox, hex_colour);
            ColourBox.BackColor = Color.FromArgb(hex_red, hex_green, hex_blue);
        }
    }
}
