using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoFakeData
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btLuong_Click(object sender, EventArgs e)
        {
            String BangCap = cbBangCap.Text.ToString();
            String SoNamKinhNghiem = cbSoNamKinhNghiem.Text.ToString();
            String ChucVu = cbChucVu.Text.ToString();
            String NoiDaoTao = cbNoiDaoTao.Text.ToString();
            String NangLuc = cbNangLuc.Text.ToString();

            Random rd = new Random();

            if (BangCap == "Tiến sĩ")
            {
                if (SoNamKinhNghiem == "7")
                {
                    if (NoiDaoTao == "Trong nước")
                    {
                        if (ChucVu == "Trưởng phòng")
                        {
                            if (NangLuc == "A")
                            {
                                tbLuong.Text = rd.Next(65, 75).ToString(); 
                            }
                            else
                            {
                                tbLuong.Text = rd.Next(60, 70).ToString();
                            }   
                        }
                        else
                        {
                            if (NangLuc == "A")
                            {
                                tbLuong.Text = rd.Next(40, 50).ToString();
                            }
                            else
                            {
                                tbLuong.Text = rd.Next(30, 40).ToString();
                            }
                        }    
                    }
                    else
                    {
                        if (ChucVu == "Trưởng phòng")
                        {
                            if (NangLuc == "A")
                            {
                                tbLuong.Text = rd.Next(70, 80).ToString();
                            }
                            else
                            {
                                tbLuong.Text = rd.Next(65, 75).ToString();
                            }
                        }
                        else
                        {
                            if (NangLuc == "A")
                            {
                                tbLuong.Text = rd.Next(60, 70).ToString();
                            }
                            else
                            {
                                tbLuong.Text = rd.Next(50, 60).ToString();
                            }
                        }
                    }    
                }
            }
        }
    }
}