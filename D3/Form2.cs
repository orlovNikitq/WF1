using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace D3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            MoveToStart();
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
        }

        private void MoveToStart()
        {
            Point point = panel1.Location;
            point.Offset(15, 15);
            Cursor.Position = PointToScreen(point);
        }

        private void label_finish_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Уровень 2 пройден!");
            Application.Exit();
        }

        private void panel1_MouseLeave(object sender, EventArgs e)
        {
            MoveToStart();
        }

        private void label35_MouseEnter(object sender, EventArgs e)
        {
            MoveToStart();
        }
    }
}
