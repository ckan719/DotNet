using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XepHinh
{
    public partial class form : Form
    {
        int num = 3;
        int oldId = 1;
        bool flag = false;
        Button[] arrButton;
        public form()
        {
            InitializeComponent();
        }



        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            num = int.Parse(getNum.Value.ToString());
            btRand.Visible = true;
            oldId = 1;
            flag = false;
            build();
        }
        public void build()
        {
            arrButton = new Button[51];
            panel1.Controls.Clear();
            int startT = 0;
            int startL = 0;
            int id = 1;
            panel1.Size = new Size(num * 100 + num * 10, num * 100 + num * 10);
            form.ActiveForm.Width = num * 100 + num * 10 + 20;
            form.ActiveForm.Height = num * 100 + num * 10 + 150;
            for (int i = 0; i < num; ++i)
            {
                for (int j = 0; j < num; ++j)
                {
                    arrButton[id] = new Button();
                    arrButton[id].Top = startT;
                    arrButton[id].Left = startL;
                    startL += 105;
                    arrButton[id].Size = new Size(100, 100);
                    if (id != 1)
                    {
                        arrButton[id].Text = (id - 1).ToString();
                        arrButton[id].BackColor = Color.Cyan;
                    }
                    arrButton[id].FlatStyle = FlatStyle.Flat;
                    arrButton[id].Font = new Font(arrButton[id].Font.FontFamily, 20);
                    panel1.Controls.Add(arrButton[id]);
                    arrButton[id].Click += myButtonClick;
                    ++id;
                }
                startT += 105;
                startL = 0;
            }
        }

        public void swap(Button x, Button y)
        {
            String stemp = x.Text;
            x.Text = y.Text;
            y.Text = stemp;
            Color ctemp = x.BackColor;
            x.BackColor = y.BackColor;
            y.BackColor = ctemp;
        }

        private void myButtonClick(object o, EventArgs e)
        {
            if (flag == true) return;
            Button te = (Button)o;
            Button temp = arrButton[oldId];
            if( oldId + 1 <= num*num &&arrButton[oldId + 1].Text == te.Text )
            {
                swap(arrButton[oldId], arrButton[oldId + 1]);
                oldId += 1;
            }
            else if(oldId > 1 && arrButton[oldId - 1].Text == te.Text)
            {
                swap(arrButton[oldId], arrButton[oldId - 1]);
                oldId -= 1;
            }else if ( oldId + num <= num*num && arrButton[oldId + num].Text == te.Text)
            {
                swap(arrButton[oldId], arrButton[oldId + num]);
                oldId += num;
            }else if( oldId - num >= 1  && arrButton[oldId - num].Text == te.Text)
            {
                swap(arrButton[oldId], arrButton[oldId - num]);
                oldId = oldId - num;
            }
            bool cc = false;
            for(int i = 1; i <= num*num; ++i)
            {
                {
                    if (i == num * num) cc = true;
                }
                if (arrButton[i].Text != i.ToString())
                {
                    break;
                }
                Console.WriteLine(arrButton[i].Text);
                
            }
            if (cc == true)
            {
                flag = true;
                MessageBox.Show("Win!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            for(int i = 1; i <= num*num; ++i)
            {
               int t =  rand.Next(1, num * num);
                swap(arrButton[i], arrButton[t]);
                if (arrButton[t].Text == "") oldId = t;
                if (arrButton[i].Text == "") oldId = i;
            }
        }
    }
}
