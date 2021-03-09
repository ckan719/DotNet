using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VietLot
{
    public partial class VietLot : Form
    {
        int giay = 5;
        int myGiai = 10;
        String myNum;
        int dem = 0;
        int[,] result;
        int[] lenRs = { 5, 5, 4, 4, 4, 4, 4, 3, 2 };
        int[] numG = { 1, 1, 1, 2, 7, 1, 3, 1, 1 };
        int[] numGnow = { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        int rule = 0;
        int delay = 1000;
        bool flag = true;
        int index = 8;
        public VietLot()
        {
            InitializeComponent();
            result = new int[10,10];
            defaultColor();
            for(int i = 0; i< 9; ++i)
            {
                for(int j = 0; j < numG[i]; ++j)
                {
                    result[i,j] = -1;
                }
            }
            cbxChonGiaiThuong.SelectedIndex = 0;
            cbxCachQuay.SelectedIndex = 0;
        }
        public int getResult(String s)
        {
            int rs = 8;

            switch (s)
            {
                case "Giải 8":
                    {
                        return 8;
                        break;
                    }
                case "Giải 7":
                    {
                        return 7;
                        break;
                    }
                case "Giải 6":
                    {
                        return 6;
                        break;
                    }
                case "Giải 5":
                    {
                        return 5;
                        break;
                    }
                case "Giải 4":
                    {
                        return 4;
                        break;
                    }
                case "Giải 3":
                    {
                        return 3;
                        break;
                    }
                case "Giải 2":
                    {
                        return 2;
                        break;
                    }
                case "Giải 1":
                    {
                        return 1;
                        break;
                    }
                case "Giải Đặc Biệt":
                    {
                        return 0;
                        break;
                    }
                default:
                    {
                        break;
                    }
            }

            return rs;
        }
        public String castResult(int n, int len)
        {
            //return String.Format("{0:0#}", n);

            String rs = n + "";
            if (rs.Length != len)
            {
                int rslen = rs.Length;
                for (int i = 0; i < len - rslen; ++i)
                {
                    rs = "0" + rs;
                }
            }
            return rs;
        }
        public void getResults(int choose, int count)
        {
            Random rand = new Random();
            switch (choose)
            {
                case 8:
                    {

                        result[choose,count] = rand.Next(0, 99);
                        break;
                    }
                case 7:
                    {
                        result[choose,count] = rand.Next(0, 999);
                        break;
                    }
                case 6:
                    {
                        result[choose,count] = rand.Next(0, 9999);
                        break;
                    }
                case 5:
                    {
                        result[choose,count] = rand.Next(0, 9999);
                        break;
                    }
                case 4:
                    {
                        result[choose,count] = rand.Next(0, 9999);
                        break;
                    }
                case 3:
                    {
                        result[choose,count] = rand.Next(0, 9999);
                        break;
                    }
                case 2:
                    {
                        result[choose,count] = rand.Next(0, 9999);
                        break;
                    }
                case 1:
                    {
                        result[choose,count] = rand.Next(0, 99999);
                        break;
                    }
                case 0:
                    {
                        result[choose,count] = rand.Next(0, 99999);
                        break;
                    }
                default:
                    {
                        break;
                    }
            }
        }
        public void doShowGiai(int choose)
        {
            switch (choose)
            {
                case 8:
                    {
                        if (tvGiai8.Text == "")
                            tvGiai8.Text = castResult(result[choose, numGnow[choose]], lenRs[choose]);
                        else
                        {
                            tvGiai8.Text = tvGiai8.Text + "    " + castResult(result[choose, numGnow[choose]], lenRs[choose]);
                        }
                        break;
                    }
                case 7:
                    {
                        if (tvGiai7.Text == "")
                            tvGiai7.Text = castResult(result[choose, numGnow[choose]], lenRs[choose]);
                        else
                        {
                            tvGiai7.Text = tvGiai7.Text + "    " + castResult(result[choose, numGnow[choose]], lenRs[choose]);
                        }
                        break;
                    }
                case 6:
                    {
                        if (tvGiai6.Text == "")
                            tvGiai6.Text = castResult(result[choose, numGnow[choose]], lenRs[choose]);
                        else
                        {
                            tvGiai6.Text = tvGiai6.Text + "    " + castResult(result[choose, numGnow[choose]], lenRs[choose]);
                        }
                        break;
                    }
                case 5:
                    {
                        if (tvGiai5.Text == "")
                            tvGiai5.Text = castResult(result[choose, numGnow[choose]], lenRs[choose]);
                        else
                        {
                            tvGiai5.Text = tvGiai5.Text + "    " + castResult(result[choose, numGnow[choose]], lenRs[choose]);
                        }
                        break;
                    }
                case 4:
                    {
                        if (tvGiai4.Text == "")
                            tvGiai4.Text = castResult(result[choose, numGnow[choose]], lenRs[choose]);
                        else
                        {
                            tvGiai4.Text = tvGiai4.Text + "    " + castResult(result[choose, numGnow[choose]], lenRs[choose]);
                        }
                        break;
                    }
                case 3:
                    {
                        if (tvGiai3.Text == "")
                            tvGiai3.Text = castResult(result[choose, numGnow[choose]], lenRs[choose]);
                        else
                        {
                            tvGiai3.Text = tvGiai3.Text + "    " + castResult(result[choose, numGnow[choose]], lenRs[choose]);
                        }
                        break;
                    }
                case 2:
                    {
                        if (tvGiai2.Text == "")
                            tvGiai2.Text = castResult(result[choose, numGnow[choose]], lenRs[choose]);
                        else
                        {
                            tvGiai2.Text = tvGiai2.Text + "    " + castResult(result[choose, numGnow[choose]], lenRs[choose]);
                        }
                        break;
                    }
                case 1:
                    {
                        if (tvGiai1.Text == "")
                            tvGiai1.Text = castResult(result[choose, numGnow[choose]], lenRs[choose]);
                        else
                        {
                            tvGiai1.Text = tvGiai1.Text + "    " + castResult(result[choose, numGnow[choose]], lenRs[choose]);
                        }
                        break;
                    }
                case 0:
                    {
                        if (tvGiaiDB.Text == "")
                            tvGiaiDB.Text = castResult(result[choose, numGnow[choose]], lenRs[choose]);
                        else
                        {
                            tvGiaiDB.Text = tvGiaiDB.Text + "    " + castResult(result[choose, numGnow[choose]], lenRs[choose]);
                        }
                        break;
                    }
            }
        }
        public void doSingle()
        {
            int choose = getResult(cbxChonGiaiThuong.Text);
            getResults(choose,numGnow[choose]);
            tvShow.Text = castResult(result[choose, numGnow[choose]], lenRs[choose]);
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int choose = getResult(cbxChonGiaiThuong.Text);
            if (flag == true)
            {
                if (numGnow[choose] == numG[choose]) return;
                timer1.Enabled = true;
                flag = false;
            }else
            {
                doShowGiai(choose);
                numGnow[choose]++;
                timer1.Enabled = false;
                flag = true;
            }
         

        }
        private void btReset_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= 8; ++i)
            {
                numGnow[i] = 0;
                for(int j = 0; j< numG[i]; ++j)
                {
                    result[i, j] = -1;
                }
            }
            tvShow.Text = "";
            cbxChonGiaiThuong.SelectedIndex = 0;
            tvGiaiDB.Text = "";
            tvGiai1.Text = "";
            tvGiai2.Text = "";
            tvGiai3.Text = "";
            tvGiai4.Text = "";
            tvGiai5.Text = "";
            tvGiai6.Text = "";
            tvGiai7.Text = "";
            tvGiai8.Text = "";
        }
        public int castCachQuay(String n)
        {
            switch (n)
            {
                case "Single":
                    {
                        return 0;
                        break;
                    }
                default:
                    {
                        return 1;
                        break;
                    }
            }
        }
        private void cbxCachQuay_SelectedIndexChanged(object sender, EventArgs e)
        {
            rule = castCachQuay(cbxCachQuay.Text);

        }
        private void tbDelay_TextChanged(object sender, EventArgs e)
        {
            try
            {
                delay = int.Parse(tbDelay.Text);
            }
            catch (Exception)
            {

            }
            giay = Math.Max(delay,1);
            tbDelay.Text = giay.ToString();
        }


        int delayTime = 30;
        bool conti = false;

        private void timer1_Tick(object sender, EventArgs e)
        {

            int choose = getResult(cbxChonGiaiThuong.Text);

     
            if (rule == 0)
            {
                btReset.Enabled = false;
                cbxChonGiaiThuong.Enabled = false;
                cbxCachQuay.Enabled = false;
                tbDelay.Enabled = false;
                btRandom.Enabled = false;
                ++dem;
                if (numGnow[choose] < numG[choose])
                    doSingle();
                else return;
                if (giay == dem / 10)
                {
                    doShowGiai(choose);
                    numGnow[choose]++;
                    timer1.Enabled = false;
                    btReset.Enabled = true;
                    cbxChonGiaiThuong.Enabled = true;
                    cbxCachQuay.Enabled = true;
                    tbDelay.Enabled = true;
                    btRandom.Enabled = true;
                    flag = true;
                    dem = 0;
                }
            }
            else
            {

                if (conti)
                {
                    if (delayTime > 0)
                    {
                        delayTime--;
                        return;
                    }
                    else
                    {
                        delayTime = 30;
                        conti = false;
                    }
                }
                btRandom.Enabled = false;
                btReset.Enabled = false;
                cbxCachQuay.Enabled = false;
                cbxChonGiaiThuong.Enabled = false;
                tbDelay.Enabled = false;
                ++dem;
                index = cbxChonGiaiThuong.SelectedIndex;
                if (index < 8)
                {
                    if (numGnow[choose] < numG[choose])
                        doSingle();
                    else cbxChonGiaiThuong.SelectedIndex = cbxChonGiaiThuong.SelectedIndex + 1;
                    if (giay == dem / 10)
                    {
                        doShowGiai(getResult(cbxChonGiaiThuong.Text));
                        conti = true;
                        numGnow[choose]++;
                        dem = 0;

                    }
                    
                }
                else
                {
                    if (numGnow[choose] < numG[choose])
                        doSingle();
                    else return;
                    if (giay == dem / 10)
                    {
                        doShowGiai(choose);
                        numGnow[choose]++;
                        timer1.Enabled = false;
                        dem = 0;
                        flag = true;
                        cbxChonGiaiThuong.Enabled = true;
                        btRandom.Enabled = true;
                        cbxCachQuay.Enabled = true;
                        tbDelay.Enabled = true;
                        btReset.Enabled = true;
                    }
                    
                }
            }
        }
        public void defaultColor()
        {
            pnGiai8.BackColor = Color.White;
            pnGiai7.BackColor = Color.White;
            pnGiai6.BackColor = Color.White;
            pnGiai5.BackColor = Color.White;
            pnGiai4.BackColor = Color.White;
            pnGiai3.BackColor = Color.White;
            pnGiai2.BackColor = Color.White;
            pnGiai1.BackColor = Color.White;
            pnGiaiDB.BackColor = Color.White;
        }
        private void cbxChonGiaiThuong_SelectedIndexChanged(object sender, EventArgs e)
        {
            defaultColor();
            //tvShow.Text = "";
            int choose = getResult(cbxChonGiaiThuong.Text);
            switch (choose)
            {
                case 8:
                    {
                        pnGiai8.BackColor = Color.Aqua;
                        break;
                    }
                case 7:
                    {
                        pnGiai7.BackColor = Color.Aqua;
                        break;
                    }
                case 6:
                    {
                        pnGiai6.BackColor = Color.Aqua;
                        break;
                    }
                case 5:
                    {
                        pnGiai5.BackColor = Color.Aqua;
                        break;
                    }
                case 4:
                    {
                        pnGiai4.BackColor = Color.Aqua;
                        break;
                    }
                case 3:
                    {
                        pnGiai3.BackColor = Color.Aqua;
                        break;
                    }
                case 2:
                    {
                        pnGiai2.BackColor = Color.Aqua;
                        break;
                    }
                case 1:
                    {
                        pnGiai1.BackColor = Color.Aqua;
                        break;
                    }
                case 0:
                    {
                        pnGiaiDB.BackColor = Color.Aqua;
                        break;
                    }
            }
        }

        public void dofind(int i)
        {
            TextBox t = new TextBox();
            if (i == 8) t = tvGiai8;
            else if (i == 7) t = tvGiai7;
            else if (i == 6) t = tvGiai6;
            else if (i == 5) t = tvGiai5;
            else if (i == 4) t = tvGiai4;
            else if (i == 3) t = tvGiai3;
            else if (i == 2) t = tvGiai2;
            else if (i == 1) t = tvGiai1;
            else if (i == 0) t = tvGiaiDB;
            String s = myNum.Substring(myNum.Length - lenRs[i]);
            String[] keySplit = { " " };
            String[] list = t.Text.Split(keySplit, StringSplitOptions.RemoveEmptyEntries);
            foreach(String c in list)
            {
                String temp = c.Substring(c.Length - lenRs[i]);
                if(temp == s)
                {
                    myGiai = Math.Min(myGiai, i);
                    return;
                }
            }
            int num = 0;
            String tt = tvGiaiDB.Text;
            for(int j = 0; j < tt.Length; ++j)
            {
                if (myNum[j] == tt[j]) ++num;
            }
            if (num == 4) myGiai = Math.Min(myGiai, 8);
        }
        public void findGiaiThuong()
        {
            for(int i = 8; i >=0; --i)
            {
                dofind(i);
            }
            if (myGiai >= 10)
                MessageBox.Show("Bạn đã không trúng giải lào .");
            else if (myGiai < 10)
            {
                String ddd = "Bạn đã trúng giải: " + myGiai.ToString();
                if (myGiai == 0) MessageBox.Show("Bạn đã trúng giải đặc biệt .");
                else MessageBox.Show(ddd);
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            myNum = tbNhapSo.Text;
            if (myNum.Length < 5) return;
         

            findGiaiThuong();

            myGiai = 10;
        }
    }
}
