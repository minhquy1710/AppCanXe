using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tramcan2.form
{
    public partial class fCOM : Form
    {
        public fCOM()
        {
            InitializeComponent();
        }

        private void fCOM_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            comboBox_COM.DataSource = ports;
        }

        private void comboBox_COM_SelectedIndexChanged(object sender, EventArgs e)
        {
            serialPort1.PortName = comboBox_COM.Text;
        }

        private void btn_connect_Click(object sender, EventArgs e)
        {
            if (comboBox_COM.Text == " ")
            {
                MessageBox.Show("select COM Port.", "warring", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                try
                {
                    if (serialPort1.IsOpen)  // isopen laf cổng đã dc sử dụng
                    {
                        MessageBox.Show(" COM Port is connected and ready for use.", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        serialPort1.Open();
                        MessageBox.Show("secessfull connection", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        textBox1.BackColor = Color.DarkOrange;
                        textBox1.Text = "Connection";
                        comboBox_COM.Enabled = false;

                    }
                }
                catch (Exception)
                {
                    MessageBox.Show(" COM Port has been used.", "Errol", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_disconnect_Click(object sender, EventArgs e)
        {
            try
            {
                if (serialPort1.IsOpen)  // isopen laf cổng đã dc sử dụng
                {
                    serialPort1.Close();
                    textBox1.BackColor = Color.Blue;
                    textBox1.Text = "Disconnection";
                    comboBox_COM.Enabled = true;
                }
                else
                {
                    MessageBox.Show(" COM Port is disconnected .", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {
                MessageBox.Show(" COM Port has been used.", "Errol", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    
}
