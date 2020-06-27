using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace AnnoyingButtonForm
{
    public partial class AnnoyingButton : Form
    {
        private int main_width = 408;
        private int main_height = 435;
        private int location_x = 204;
        private int location_y = 217;
        private int proportion_x;
        private int proportion_y;

        private void PositionCheck()
        {
            if (location_x < 0)
                Button.Location = new Point(0, location_y);
            if (location_x > main_width)
                Button.Location = new Point(main_width, location_y);
            if (location_y < 0)
                Button.Location = new Point(location_x, 0);
            if (location_y > main_height)
                Button.Location = new Point(location_x, main_height);
        }

        public AnnoyingButton()
        {
            InitializeComponent();
            NewProportion();
        }

        private void NewProportion()
        {
            proportion_x = 100 * location_x / main_width;
            proportion_y = 100 * location_y / main_height;
        }

        private void Dashboard_Resize(object sender, EventArgs e)
        {
            Control control_dashboard = (Control)sender;
            main_width = control_dashboard.Size.Width - 92;
            main_height = control_dashboard.Size.Height - 65;
            location_x = Button.Location.X;
            location_y = Button.Location.Y;
            Button.Location = new Point(proportion_x * main_width / 100, proportion_y * main_height / 100);
            PositionCheck();
        }

        private void Button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Поздравляем! Вы смогли нажать на кнопку!");
        }

        private void AnnoyingButton_MouseMove(object sender, MouseEventArgs e)
        {
            double temp = Math.Abs(Math.Sqrt(Math.Pow(Button.Location.X + 37.5 - e.X, 2) + Math.Pow(Button.Location.Y + 12.5 - e.Y, 2)));
            if (temp > 100)
                return;
            else
            {
                if (Button.Location.X >= 0 && Button.Location.X <= main_width)
                {
                    
                    Button.Location = new Point(Button.Location.X + Convert.ToInt32((Button.Location.X + 37.5 - e.X) * 10 / temp),
                                                Button.Location.Y + Convert.ToInt32((Button.Location.Y + 12.5 - e.Y) * 10 / temp));

                }

                location_x = Button.Location.X;
                location_y = Button.Location.Y;
                NewProportion();
                PositionCheck();
            }
        }
    }
}
