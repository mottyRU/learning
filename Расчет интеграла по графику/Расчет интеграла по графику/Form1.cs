using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using System.IO;
using System.Windows.Forms;

namespace Расчет_интеграла_по_графику
{
    public partial class Form1 : Form
    {
        OpenFileDialog A = new OpenFileDialog();
        public static string Z;
        //public int[] Numbers = new int[Z.Length];
        public Form1()
        {
            InitializeComponent();
        }
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog A = new OpenFileDialog();
            A.InitialDirectory = "D:\\Aldan";
            A.Filter = "CSV files|*.csv";
            A.Title = "Выберите файл";
            //A.ShowDialog();
            //MessageBox.Show(A.FileName);    
            if (A.ShowDialog() == DialogResult.OK)
            {
                //читаем данные из файла:
                var CSVread = new StreamReader(A.FileName);
                string Txt = CSVread.ReadToEnd();
                MessageBox.Show(Txt);
                string[] Dergatel = Txt.Split(new char[] { ',', '\r' }, StringSplitOptions.RemoveEmptyEntries);
                for (int i = 0; i < Dergatel.Length; i++)
                {
                    MessageBox.Show(Dergatel[i]);
                }
                //создаем два массива, в которые записываем значения из текстового массива
                string Numbers_X = Dergatel[0];
                string Numbers_Y = Dergatel[1];
                //MessageBox.Show(Numbers_X);
                //MessageBox.Show(Numbers_Y);
                /*double[] Numbers_X = new double[Dergatel.Length/2];
                double[] Numbers_Y = new double[Dergatel.Length/2];

                for (int i = 0; i < Dergatel.Length;)
                {
                    i++;
                    Numbers_X[i] = Convert.ToDouble(Dergatel[i]);
                }                
                //отображение содержимого массива:
                for (int i = 0; i < Numbers_X.Length; i++)
                {
                    MessageBox.Show(Numbers_X[i].ToString());
                }*/
            }
            else
            {
                MessageBox.Show("File is not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        //метод для разбора файла в формате CSV:
        public void CSVinMassive()
        {
            
        }
    }
}
