using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.AddRange(System.IO.Ports.SerialPort.GetPortNames());
            comboBox1.SelectedIndex = 0;
            serialPort1.ReadTimeout = (2000);
            serialPort1.WriteTimeout = (2000);
        }

        private void outPort()
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {   

                serialPort1.PortName = comboBox1.Text; 
                serialPort1.BaudRate = (9600);
                serialPort1.Open();
                groupBox1.Visible = false; // Bağlanma işlemi tamamlanınca bağlantı ekranını gizler.
                groupBox2.Visible = true; // Bağlanma işlemi tamamlanınca kumanda ekranını gösterir.
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString()); // Herhangi bir hatada bize hatayı bildirir.
            }
        
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            outPort(); // hazır fonksiyonu çalıştırır.

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.W)
            {
                serialPort1.Write("F");
                button2.BackColor = Color.Yellow;

            }
            else if (e.KeyCode == Keys.Left || e.KeyCode == Keys.A)
            {
                serialPort1.Write("L");
                button3.BackColor = Color.Yellow;
            }
            else if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D)
            {

                serialPort1.Write("R");
                button4.BackColor = Color.Yellow;
            }
            else if (e.KeyCode == Keys.Down || e.KeyCode == Keys.S)
            {
                serialPort1.Write("B");
                button5.BackColor = Color.Yellow;
            }
            else if (e.KeyCode == Keys.NumPad0 || e.KeyCode == Keys.D0)
            {
                serialPort1.Write("0");
                button6.BackColor = Color.Yellow;
            }
            else if (e.KeyCode == Keys.NumPad1 || e.KeyCode == Keys.D1)
            {
                serialPort1.Write("1");
                button7.BackColor = Color.Yellow;
            }
            else if (e.KeyCode == Keys.NumPad2 || e.KeyCode == Keys.D2)
            {
                serialPort1.Write("2");
                button8.BackColor = Color.Yellow;
            }
            else if (e.KeyCode == Keys.NumPad3 || e.KeyCode == Keys.D3)
            {
                serialPort1.Write("3");
                button9.BackColor = Color.Yellow;
            }
            else if (e.KeyCode == Keys.NumPad4 || e.KeyCode == Keys.D4)
            {
                serialPort1.Write("4");
                button10.BackColor = Color.Yellow;
            }
            else if (e.KeyCode == Keys.NumPad5 || e.KeyCode == Keys.D5)
            {
                serialPort1.Write("5");
                button11.BackColor = Color.Yellow;
            }
            else if (e.KeyCode == Keys.NumPad6 || e.KeyCode == Keys.D6)
            {
                serialPort1.Write("6");
                button12.BackColor = Color.Yellow;
            }
            else if (e.KeyCode == Keys.NumPad7 || e.KeyCode == Keys.D7)
            {
                serialPort1.Write("7");
                button13.BackColor = Color.Yellow;
            }
            else if (e.KeyCode == Keys.NumPad8 || e.KeyCode == Keys.D8)
            {
                serialPort1.Write("8");
                button14.BackColor = Color.Yellow;
            }
            else if (e.KeyCode == Keys.NumPad9 || e.KeyCode == Keys.D9)
            {
                serialPort1.Write("9");
                button15.BackColor = Color.Yellow;
            }
        }
        private void Form1_KeyUp(object sender, KeyEventArgs e) // Tuştan parmağı çekince
        {
            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.W)
            { button2.BackColor = Color.Silver; }
            else if (e.KeyCode == Keys.Left || e.KeyCode == Keys.A)
            { button3.BackColor = Color.Silver; }
            else if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D)
            { button4.BackColor = Color.Silver; }
            else if (e.KeyCode == Keys.Down || e.KeyCode == Keys.S)
            { button5.BackColor = Color.Silver; }
            else if (e.KeyCode == Keys.NumPad0 || e.KeyCode == Keys.D0)
            { button6.BackColor = Color.Silver; }
            else if (e.KeyCode == Keys.NumPad1 || e.KeyCode == Keys.D1)
            { button7.BackColor = Color.Silver; }
            else if (e.KeyCode == Keys.NumPad2 || e.KeyCode == Keys.D2)
            { button8.BackColor = Color.Silver; }
            else if (e.KeyCode == Keys.NumPad3 || e.KeyCode == Keys.D3)
            { button9.BackColor = Color.Silver; }
            else if (e.KeyCode == Keys.NumPad4 || e.KeyCode == Keys.D4)
            { button10.BackColor = Color.Silver; }
            else if (e.KeyCode == Keys.NumPad5 || e.KeyCode == Keys.D5)
            { button11.BackColor = Color.Silver; }
            else if (e.KeyCode == Keys.NumPad6 || e.KeyCode == Keys.D6)
            { button12.BackColor = Color.Silver; }
            else if (e.KeyCode == Keys.NumPad7 || e.KeyCode == Keys.D7)
            { button13.BackColor = Color.Silver; }
            else if (e.KeyCode == Keys.NumPad8 || e.KeyCode == Keys.D8)
            { button14.BackColor = Color.Silver; }
            else if (e.KeyCode == Keys.NumPad9 || e.KeyCode == Keys.D9)
            { button15.BackColor = Color.Silver; }

        }
        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
        // MANUEL KONTROL İŞLEMLERİ BURADAN SONRA BAŞLAR ↓
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1.Enabled = false;
            checkBox2.Enabled = true;
            comboBox2.Enabled = true;
            numericUpDown1.Enabled = true;
            label15.Visible = true;
            comboBox2.Text = "İLERİ";
            comboBox3.Text = "İLERİ";
            comboBox4.Text = "İLERİ";
            comboBox5.Text = "İLERİ";
            comboBox6.Text = "İLERİ";
            comboBox7.Text = "İLERİ";
           
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            checkBox2.Enabled = false;
            checkBox3.Enabled = true;
            comboBox3.Enabled = true;
            numericUpDown2.Enabled = true;
            label16.Visible = true;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            checkBox3.Enabled = false;
            checkBox4.Enabled = true;
            comboBox4.Enabled = true;
            numericUpDown3.Enabled = true;
            label17.Visible = true;
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            checkBox4.Enabled = false;
            checkBox5.Enabled = true;
            comboBox5.Enabled = true;
            numericUpDown4.Enabled = true;
            label18.Visible = true;
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            checkBox5.Enabled = false;
            checkBox6.Enabled = true;
            comboBox6.Enabled = true;
            numericUpDown5.Enabled = true;
            label19.Visible = true;
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            checkBox6.Enabled = false;
            comboBox7.Enabled = true;
            numericUpDown6.Enabled = true;
            label20.Visible = true;
        }

        // SIFIRLAMAK
        private void button19_Click(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;

            checkBox1.Enabled = true;
            checkBox2.Enabled = false;
            checkBox3.Enabled = false;
            checkBox4.Enabled = false;
            checkBox5.Enabled = false;
            checkBox6.Enabled = false;


            label15.Visible = false;
            label16.Visible = false;
            label17.Visible = false;
            label18.Visible = false;
            label19.Visible = false;
            label20.Visible = false;

            
            comboBox2.Text = "İLERİ";
            comboBox3.Text = "İLERİ";
            comboBox4.Text = "İLERİ";
            comboBox5.Text = "İLERİ";
            comboBox6.Text = "İLERİ";
            comboBox7.Text = "İLERİ";

            numericUpDown1.Value = 1;
            numericUpDown2.Value = 1;
            numericUpDown3.Value = 1;
            numericUpDown4.Value = 1;
            numericUpDown5.Value = 1;
            numericUpDown6.Value = 1;

           
            comboBox2.Enabled = false;
            comboBox3.Enabled = false;
            comboBox4.Enabled = false;
            comboBox5.Enabled = false;
            comboBox6.Enabled = false;
            comboBox7.Enabled = false;

            numericUpDown1.Enabled = false;
            numericUpDown2.Enabled = false;
            numericUpDown3.Enabled = false;
            numericUpDown4.Enabled = false;
            numericUpDown5.Enabled = false;
            numericUpDown6.Enabled = false;

            

            timer1.Enabled = false;
            timer2.Enabled = false;
            timer2.Enabled = false;
            timer4.Enabled = false;
            timer5.Enabled = false;
            timer6.Enabled = false;

            sayac1 = 0;
            sayac2 = 0;
            sayac3 = 0;
            sayac4 = 0;
            sayac5 = 0;
            sayac6 = 0;

            button17.Text = "BAŞLAT";
            button18.Enabled = false;
            button17.Enabled = true;

        }
        
        private void button17_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                timer1.Enabled = true;
                button18.Enabled = true;  // durdurma butonu
                button17.Enabled = false;
            }
            else
            {
                MessageBox.Show("KUTUCUKLARI İŞARETLE");
            }
            checkBox2.Enabled = false;
            checkBox3.Enabled = false;
            checkBox4.Enabled = false;
            checkBox5.Enabled = false;
            checkBox6.Enabled = false;
                
        }
        private void button18_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            timer2.Enabled = false;
            timer3.Enabled = false;
            timer4.Enabled = false;
            timer5.Enabled = false;
            timer6.Enabled = false;
            button17.Text = "DEVAM ETTİR";
            button18.Enabled = false;
            button17.Enabled = true;
        }

        int sayac1, sayac2, sayac3, sayac4, sayac5, sayac6; // sayaçlar
        int cbx1, cbx2, cbx3, cbx4, cbx5, cbx6; // numericupdowndan alınan veriler
        private void timer1_Tick(object sender, EventArgs e)
        {
            // 1.KOMUT
            if (checkBox1.Checked == true)
            {
                cbx1 = Convert.ToInt32(numericUpDown1.Value.ToString());

                 if( sayac1 < cbx1 * 26 && comboBox2.Text == "SOL"  )
                {
                    sayac1++;
                    serialPort1.Write("L");
                    if (sayac1 == cbx1 * 26)
                    {
                        timer1.Enabled = false;
                        timer2.Enabled = true;
                    }
                }
                 else if (sayac1 < cbx1 * 26 && comboBox2.Text == "SAĞ")
                {
                    sayac1++;
                    serialPort1.Write("R");
                    if (sayac1 == cbx1 * 26)
                    {
                        timer1.Enabled = false;
                        timer2.Enabled = true;
                    }
                }
                else if (sayac1 < cbx1 * 60 && comboBox2.Text == "İLERİ")
                {
                    sayac1++;
                    serialPort1.Write("F");
                    if (sayac1 == cbx1 * 60)
                    {
                        timer1.Enabled = false;
                        timer2.Enabled = true;
                    }
                }
                 else if (sayac1 < cbx1 * 60 && comboBox2.Text == "GERİ")
                 {
                     sayac1++;
                     serialPort1.Write("B");
                     if (sayac1 == cbx1 * 60)
                     {
                         timer1.Enabled = false;
                         timer2.Enabled = true;
                     }
                 }
                 
            }

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            // 2.KOMUT
            if (checkBox2.Checked == true)
            {
                cbx2 = Convert.ToInt32(numericUpDown2.Value.ToString());

                if (sayac2 < cbx2 * 26 && comboBox3.Text == "SOL")
                {
                    sayac2++;
                    serialPort1.Write("L");
                    if (sayac2 == cbx2 * 26)
                    {
                        timer2.Enabled = false;
                        timer3.Enabled = true;
                    }
                }
                else if (sayac2 < cbx2 * 26 && comboBox3.Text == "SAĞ")
                {
                    sayac2++;
                    serialPort1.Write("R");
                    if (sayac2 == cbx2 * 26)
                    {
                        timer2.Enabled = false;
                        timer3.Enabled = true;
                    }
                }
                else if (sayac2 < cbx2 * 60 && comboBox3.Text == "İLERİ")
                {
                    sayac2++;
                    serialPort1.Write("F");
                    if (sayac2 == cbx2 * 60)
                    {
                        timer2.Enabled = false;
                        timer3.Enabled = true;
                    }
                }
                else if (sayac2 < cbx2 * 60 && comboBox3.Text == "GERİ")
                {
                    sayac2++;
                    serialPort1.Write("B");
                    if (sayac2 == cbx2 * 60)
                    {
                        timer2.Enabled = false;
                        timer3.Enabled = true;
                    }
                }
                 
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            // 3.KOMUT
            if (checkBox3.Checked == true)
            {
                cbx3 = Convert.ToInt32(numericUpDown3.Value.ToString());

                if (sayac3 < cbx3 * 26 && comboBox4.Text == "SOL")
                {
                    sayac3++;
                    serialPort1.Write("L");
                    if (sayac3 == cbx3 * 26)
                    {
                        timer3.Enabled = false;
                        timer4.Enabled = true;
                    }
                }
                else if (sayac3 < cbx3 * 26 && comboBox4.Text == "SAĞ")
                {
                    sayac3++;
                    serialPort1.Write("R");
                    if (sayac3 == cbx3 * 26)
                    {
                        timer3.Enabled = false;
                        timer4.Enabled = true;
                    }
                }
                else if (sayac3 < cbx3 * 60 && comboBox4.Text == "İLERİ")
                {
                    sayac3++;
                    serialPort1.Write("F");
                    if (sayac3 == cbx3 * 60)
                    {
                        timer3.Enabled = false;
                        timer4.Enabled = true;
                    }
                }
                else if (sayac3 < cbx3 * 60 && comboBox4.Text == "GERİ")
                {
                    sayac3++;
                    serialPort1.Write("B");
                    if (sayac3 == cbx3 * 60)
                    {
                        timer3.Enabled = false;
                        timer4.Enabled = true;
                    }
                }
                 
            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            // 4.KOMUT
            if (checkBox4.Checked == true)
            {
                cbx4 = Convert.ToInt32(numericUpDown4.Value.ToString());

                if (sayac4 < cbx4 * 26 && comboBox5.Text == "SOL")
                {
                    sayac4++;
                    serialPort1.Write("L");
                    if (sayac4 == cbx4 * 26)
                    {
                        timer5.Enabled = true;
                        timer4.Enabled = false;
                    }
                }
                else if (sayac4 < cbx4 * 26 && comboBox5.Text == "SAĞ")
                {
                    sayac4++;
                    serialPort1.Write("R");
                    if (sayac4 == cbx4 * 26)
                    {
                        timer5.Enabled = true;
                        timer4.Enabled = false;
                    }
                }
                else if (sayac4 < cbx4 * 60 && comboBox5.Text == "İLERİ")
                {
                    sayac4++;
                    serialPort1.Write("F");
                    if (sayac4 == cbx4 * 60)
                    {
                        timer5.Enabled = true;
                        timer4.Enabled = false;
                    }
                }
                else if (sayac4 < cbx4 * 60 && comboBox5.Text == "GERİ")
                {
                    sayac4++;
                    serialPort1.Write("B");
                    if (sayac4 == cbx4 * 60)
                    {
                        timer5.Enabled = true;
                        timer4.Enabled = false;

                    }
                }
                
            }
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            // 5.KOMUT
            if (checkBox5.Checked == true)
            {
                cbx5 = Convert.ToInt32(numericUpDown5.Value.ToString());

                if (sayac5 < cbx5 * 26 && comboBox6.Text == "SOL")
                {
                    sayac5++;
                    serialPort1.Write("L");
                    if (sayac5 == cbx5 * 26)
                    {
                        timer6.Enabled = true;
                        timer5.Enabled = false;
                    }
                }
                else if (sayac5 < cbx5 * 26 && comboBox6.Text == "SAĞ")
                {
                    sayac5++;
                    serialPort1.Write("R");
                    if (sayac5 == cbx5 * 26)
                    {
                        timer6.Enabled = true;
                        timer5.Enabled = false;
                    }
                }
                else if (sayac5 < cbx5 * 60 && comboBox6.Text == "İLERİ")
                {
                    sayac5++;
                    serialPort1.Write("F");
                    if (sayac5 == cbx5 * 60)
                    {
                        timer6.Enabled = true;
                        timer5.Enabled = false;
                    }
                }
                else if (sayac5 < cbx5 * 60 && comboBox6.Text == "GERİ")
                {
                    sayac5++;
                    serialPort1.Write("B");
                    if (sayac5 == cbx5 * 60)
                    {
                        timer6.Enabled = true;
                        timer5.Enabled = false;

                    }
                }
                 
            }
        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            // 6.KOMUT
            if (checkBox6.Checked == true)
            {
                cbx6 = Convert.ToInt32(numericUpDown6.Value.ToString());

                if (sayac6 < cbx6 * 26 && comboBox7.Text == "SOL")
                {
                    sayac6++;
                    serialPort1.Write("L");
                    if (sayac6 == cbx6 * 26)
                    {
                        // bitiş işlemleri buraya
                        button17.Text = "BAŞLAT";
                        timer6.Enabled = false;
                    }
                }
                else if (sayac6 < cbx6 * 26 && comboBox7.Text == "SAĞ")
                {
                    sayac6++;
                    serialPort1.Write("R");
                    if (sayac6 == cbx6 * 26)
                    {
                        // bitiş işlemleri buraya
                        button17.Text = "BAŞLAT";
                        timer6.Enabled = false;
                    }
                }
                else if (sayac6 < cbx6 * 60 && comboBox7.Text == "İLERİ")
                {
                    sayac6++;
                    serialPort1.Write("F");
                    if (sayac6 == cbx6 * 60)
                    {
                        // bitiş işlemleri buraya
                        button17.Text = "BAŞLAT";
                        timer6.Enabled = false;

                    }
                }
                else if (sayac6 < cbx6 * 60 && comboBox7.Text == "GERİ")
                {
                    sayac6++;
                    serialPort1.Write("B");
                    if (sayac6 == cbx6 * 60)
                    {
                        // bitiş işlemleri buraya
                        button17.Text = "BAŞLAT";
                        timer6.Enabled = false;
                    }
                }
                 
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = true;
            groupBox3.Visible = false;

        }

        private void button21_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = false;
            groupBox3.Visible = true;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = false;
            MessageBox.Show("MANUEL KUMANDA DEVRE DIŞI BIRAKILDI.");
            groupBox3.Visible = true;
        }

        private void button20_Click_1(object sender, EventArgs e)
        {
            groupBox2.Visible = true;
            groupBox3.Visible = false;
        }

       

       
    }
}
