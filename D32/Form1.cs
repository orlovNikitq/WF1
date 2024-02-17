using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace D32
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //paint1();
            paint2();
        }
        void paint1()
        {
            MessageBox.Show("Текст сообщения");
            MessageBox.Show("Текст сообщения", "Заголовок сообщения", MessageBoxButtons.OKCancel);
            MessageBox.Show("Текст сообщения", "Заголовок сообщения",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
        void paint2()
        {
            MessageBox.Show("Сообщение от программиста!");
            MessageBox.Show("Сообщение от программиста!","Это заглавие");
            DialogResult res = MessageBox.Show("Сообщение от программиста!", "Выбор",MessageBoxButtons.YesNoCancel);
            string choice = "";
            if (res == DialogResult.Yes) choice += "Да";
            else if (res == DialogResult.No) choice += "Нет";
            else choice += "Отмена";
            MessageBox.Show($"Вы выбрали {choice}");
        }
    }
}
