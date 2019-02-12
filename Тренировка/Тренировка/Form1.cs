using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Тренировка
{
    public partial class Form1 : Form
    {
        OpenFileDialog fileDialog = new OpenFileDialog();
        Graphics Graph;
        Pen VerticalPen;
        EventHandler ea;
        Label lbl = new Label();
        Panel Pnl = new Panel();
        string[] TextMassive;
        public double[] ForX;
        public double[] ForY;
        public Form1()
        {
            InitializeComponent();
        }
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fileDialog.Filter = "CSV|*csv";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                //записываем в текстовую переменную путь к файлу:
                string Txt = fileDialog.FileName;
                //вызываем метод для записи данных из файла в текстовую переменную:
                StreamReader File_Reder = new StreamReader(Txt);
                string FileText = File_Reder.ReadToEnd();
                //MessageBox.Show(FileText);
                //заполняем текстовый массив значениями из текстовой переменной
                //разделенными по знакам ";", "пробел" и "табуляция"
                string[] TextMassive = FileText.Remove(0, 17).Split(new char[] { '\n', ';', ' ', '\r' }, StringSplitOptions.RemoveEmptyEntries);
                //инициализируем два числовых массива и заполняем их нужными для графика 
                //конвертированными значениями из текстового массива:
                ForX = new double[TextMassive.Length / 3];
                ForY = new double[TextMassive.Length / 3];
                int a = 0;
                for (int i = 0; i < TextMassive.Length; i++)
                {
                    double Dergatel;
                    Dergatel = Convert.ToDouble(TextMassive[i]);
                    i++;
                    ForY[a] = Convert.ToDouble(TextMassive[i]);
                    i++;
                    ForX[a] = Convert.ToDouble(TextMassive[i]);
                    a++;
                }
                //если массивы заполнены, то вызывается метод для построения графика в поле Chart:
                if (ForX != null & ForY != null)
                {
                    BuildGraph();
                }
                this.Controls.Add(lbl);
                chart1.Cursor = Cursors.UpArrow;
                VerticalPen = new Pen(Color.Violet, 3);
                Graph = chart1.CreateGraphics();
                chart1.Move += (obj, ea) =>
                 {
                    Pnl.Refresh();
                    lbl.Text = "Horizontal: " + ea;
                     Graph.DrawLine(VerticalPen, new Point(0, Convert.ToInt32(ea)), new Point(Pnl.ClientSize.Width, Convert.ToInt32(ea)));
                     //Graph.DrawLine.Show();
                 };
                Pnl.MouseLeave += (obj, ea) =>
                 {
                     lbl.Text = "";
                     Pnl.Refresh();
                 };
                this.Controls.Add(Pnl);
            }
            else
            {
                MessageBox.Show("File do non found", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
        }
        public void BuildGraph()
        {
            chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            for (int i = 0; i <= ForY.Length - 1; i++)
            {
                chart1.Series[0].Points.Add(ForX[i], ForY[i]);
            }
            //chart1.Series[0].ChartType = DataGridViewColumnDesignTimeVisibleAttribute.
        }
        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void chart1_Click(object sender, EventArgs e)
        {
            /*//chart1.Series[0].Points.Add(Convert.ToDouble(X), Convert.ToDouble(Y));
            chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            for (int i = 0; i <= ForY.Length-1; i++)
            {
                chart1.Series[0].Points.Add(ForX[i], ForY[i]);
            }*/
        }
    }
}
