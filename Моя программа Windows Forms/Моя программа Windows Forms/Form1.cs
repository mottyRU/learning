using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Моя_программа_Windows_Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void файлToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog NewFile = new OpenFileDialog();
            openFileDialog1.Filter = "Cursor Files|*.csv";
            openFileDialog1.Title = "Выберите ранее записанный график в формате .csv";

            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                System.IO.StreamReader sr = new
                System.IO.StreamReader(openFileDialog1.FileName);
                data1_read = sr.ReadLine();

                data_temp_in[i] = slist[0]; //на этом этапе выскакивает ошибка
                data_temp_out[i] = slist[1];
                data_oroshenie_status[i] = slist[2];
                data_temptriger_status[i] = slist[3];
                data_t_vpsrisk[i] = slist[4];
                i++;

                sr.Close();
            }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
