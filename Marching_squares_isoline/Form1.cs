using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Forms.DataVisualization.Charting.ChartTypes;

namespace Marching_squares_isoline
{
    public partial class Form1 : Form
    {
        double[,] Grid = null;
        double[,] NGrid = null;
        double h1 = 0, h2 = 0, StartX = 0, StartY = 0, EndX = 0, EndY = 0;
        const int DelX = 60, DelY = 60;
        double Mx, My, Mx_Axes, My_Axes,m_axes, n_axes, alphax, alphay, cx, cy, Hx = 0, Hy = 0;

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        string path;

        public Form1()
        {
            InitializeComponent();
        }

        public void ClearCanv(Chart chart1)
        {
            Graphics g;

            g = chart1.CreateGraphics();
            g.Clear(Color.White);
        }
        public void DrawXYGrid(double sx, double sy, double EndX, double EndY, double Hx, double Hy, Chart chart1, double Delta)
        {
            Graphics G;
            Point pnt1, pnt2;

            G = chart1.CreateGraphics();
            G.DrawRectangle(new Pen(Color.Black, 1), new Rectangle(DelX, DelY, chart1.Width - 2 * DelX, chart1.Height - 2 * DelY));

            for (double x = 0; x < EndX; x += Hx)
            {
                pnt1 = new Point(Convert.ToInt32(sx * x) + DelX, DelY);
                pnt2 = new Point(Convert.ToInt32(sx * x) + DelX, chart1.Height - DelY);
                /*pnt1 = new Point(Convert.ToInt32(sx * x) + DelX, chart1.Height - DelY);
                pnt2 = new Point(Convert.ToInt32(sx * x) + DelX, (chart1.Height - DelY) - 10);*/
                G.DrawLine(new Pen(Color.Black, 1), pnt1, pnt2);
                G.DrawString((Delta * Math.Abs((x * h1 + StartX))).ToString(), new Font("Times New Roman", 16, FontStyle.Bold), new SolidBrush(Color.Black), new RectangleF(Convert.ToSingle((sx * x + DelX) - 10), (chart1.Height - DelY) + 10, 35, 30));
            }

            for (double y = 0; y < EndY; y += Hy)
            {
                pnt1 = new Point(DelX ,chart1.Height - (Convert.ToInt32(sy * y) + DelY));
                pnt2 = new Point(chart1.Width - DelX, chart1.Height - (Convert.ToInt32(sy * y) + DelY));
                /*pnt1 = new Point(DelX, chart1.Height - (Convert.ToInt32(sy * y) + DelY));
                pnt2 = new Point(DelX + 10, chart1.Height - (Convert.ToInt32(sy * y) + DelY));*/
                G.DrawLine(new Pen(Color.Black, 1), pnt1, pnt2);
                G.DrawString((Delta * Math.Abs((y * h2 + StartY))).ToString(), new Font("Times New Roman", 16, FontStyle.Bold), new SolidBrush(Color.Black), new RectangleF(DelX - 45, chart1.Height - Convert.ToSingle((sy * y + DelY) + 5), 50, 30));
            }

            G.DrawString("Z (км)", new Font("Times New Roman", 16, FontStyle.Bold), new SolidBrush(Color.Black), new PointF(DelX, DelY - 25));
            G.DrawString("R (км)", new Font("Times New Roman", 16, FontStyle.Bold), new SolidBrush(Color.Black), new PointF(chart1.Width - DelX, chart1.Height - DelY));

        }


        public void CenterXY(double[,] Grid, double s, double sx, double sy, ref double Cx, ref double Cy)
        {
            int k, j;
            int y1, x2, y3, x4;
            double x1, y2, x3, y4;
            byte flag;//переменная, показывающая количество пересечений с ребрами данной клетки
            double MaxX = 0, MinX = 0, MaxY = 0, MinY = 0;

            for (k = 0; k < Grid.GetLength(0) - 1; k++)
                for (j = 0; j < Grid.GetLength(1) - 1; j++)
                {
                    flag = 0;
                    if (((Grid[k, j] - s) * (Grid[k + 1, j] - s)) <= 0)//если пересекает левую грань
                    {
                        flag++;
                        x1 = interp(Grid[k, j], Grid[k + 1, j], s, k, k + 1);
                        y1 = j;
                        if (x1 < MinX) MinX = x1;
                        if (x1 > MaxX) MaxX = x1;
                        if (y1 < MinY) MinY = y1;
                        if (y1 > MaxY) MaxY = y1;
                    }

                    if (((Grid[k, j] - s) * (Grid[k, j + 1] - s)) <= 0)//если пересекает верхнюю грань
                    {
                        flag++;
                        x2 = k;
                        y2 = interp(Grid[k, j], Grid[k, j + 1], s, j, j + 1);
                        if (x2 < MinX) MinX = x2;
                        if (x2 > MaxX) MaxX = x2;
                        if (y2 < MinY) MinY = y2;
                        if (y2 > MaxY) MaxY = y2;

                    }

                    if (((Grid[k, j + 1] - s) * (Grid[k + 1, j + 1] - s)) <= 0)//если пересекает правую грань
                    {
                        flag++;
                        x3 = interp(Grid[k, j + 1], Grid[k + 1, j + 1], s, k, k + 1);
                        y3 = (j + 1);
                        if (x3 < MinX) MinX = x3;
                        if (x3 > MaxX) MaxX = x3;
                        if (y3 < MinY) MinY = y3;
                        if (y3 > MaxY) MaxY = y3;

                    }

                    if (((Grid[k + 1, j] - s) * (Grid[k + 1, j + 1] - s)) <= 0)//если пересекает нижнюю грань
                    {
                        flag++;
                        x4 = (k + 1);
                        y4 = interp(Grid[k + 1, j], Grid[k + 1, j + 1], s, j, j + 1);
                        if (x4 < MinX) MinX = x4;
                        if (x4 > MaxX) MaxX = x4;
                        if (y4 < MinY) MinY = y4;
                        if (y4 > MaxY) MaxY = y4;
                    }

                }
            Cx = MaxX - (MaxX - MinX) / 2;
            Cy = MaxY - (MaxY - MinY) / 2;
        }

        public void DrawIzo(double[,] Grid, double s, double sx, double sy, Chart chart1, Color Clr, double alpha,double alphay, double z, double zy)//рисование изолиний
        {
            int k, j, kk = 0, jj = 0;
            int y1, x2, y3, x4;
            double x1, y2, x3, y4;
            byte flag;//переменная, показывающая количество пересечений с ребрами данной клетки
            bool B;
            Graphics g;
            Pen blackPen = new Pen(Clr, 2);
            Point point1 = new Point(0,0);
            Point point2 = new Point(0,0);

            g = chart1.CreateGraphics();
            B = false;
            for (k = 0; k < Grid.GetLength(0) - 1; k++)
                for (j = 0; j < Grid.GetLength(1) - 1; j++)
                {
                    flag = 0;
                    if (((Grid[k, j] - s) * (Grid[k + 1, j] - s)) <= 0)//если пересекает левую грань
                    {
                        flag++;
                        x1 = interp(Grid[k, j], Grid[k + 1, j], s, k, k + 1);
                        y1 = j;
                        point1 = new Point(Convert.ToInt32(sx * (alpha * x1 + z)) + DelX, chart1.Height - Convert.ToInt32(sy * (alphay * y1 + zy)) - DelY);
                        if (B == false) { B = true; kk = k; jj = j; }
                    }

                    if (((Grid[k, j] - s) * (Grid[k, j + 1] - s)) <= 0)//если пересекает верхнюю грань
                    {
                        flag++;
                        x2 = k;
                        y2 = interp(Grid[k, j], Grid[k, j + 1], s, j, j + 1);
                        if (flag == 1) point1 = new Point(Convert.ToInt32(sx * (alpha * x2 + z)) + DelX, chart1.Height - Convert.ToInt32(sy * (alphay * y2 + zy)) - DelY);
                        if (flag == 2)
                        {
                            point2 = new Point(Convert.ToInt32(sx * (alpha * x2 + z)) + DelX, chart1.Height - Convert.ToInt32(sy * (alphay * y2 + zy)) - DelY);
                            g.DrawLine(blackPen, point1, point2);
                        }
                        if (B == false) { B = true; kk = k; jj = j; }

                    }

                    if (((Grid[k, j + 1] - s) * (Grid[k + 1, j + 1] - s)) <= 0)//если пересекает правую грань
                    {
                        flag++;
                        x3 = interp(Grid[k, j + 1], Grid[k + 1, j + 1], s, k, k + 1);
                        y3 = (j + 1);
                        if (flag == 1) point1 = new Point(Convert.ToInt32(sx * (alpha * x3 +  z)) + DelX, chart1.Height - Convert.ToInt32(sy * (alphay * y3 + zy)) - DelY);
                        if ((flag == 2) || (flag == 3))
                        {
                            point2 = new Point(Convert.ToInt32(sx * (alpha * x3 + z)) + DelX, chart1.Height - Convert.ToInt32(sy * (alphay * y3 + zy)) - DelY);
                            g.DrawLine(blackPen, point1, point2);
                        }
                        if (B == false) { B = true; kk = k; jj = j; }

                    }

                    if (((Grid[k + 1, j] - s) * (Grid[k + 1, j + 1] - s)) <= 0)//если пересекает нижнюю грань
                    {
                        flag++;
                        x4 = (k + 1);
                        y4 = interp(Grid[k + 1, j], Grid[k + 1, j + 1], s, j, j + 1);
                        if (flag == 1) point1 = new Point(Convert.ToInt32(sx * (alpha * x4 + z)) + DelX, chart1.Height - Convert.ToInt32(sy * (alphay * y4 + zy)) - DelY);
                        if ((flag == 2) || (flag == 3) || (flag == 4))
                        {
                            point2 = new Point(Convert.ToInt32(sx * (alpha * x4 + z)) + DelX, chart1.Height - Convert.ToInt32(sy * (alphay*y4 + zy)) - DelY);
                            g.DrawLine(blackPen, point1, point2);
                        }
                        if (B == false) { B = true; kk = k; jj = j; }
                    }

                }

            if (B == true)
            {
                //g.DrawString((Math.Round(s, 2)).ToString(), new Font("Times New Roman", 10, FontStyle.Bold), new SolidBrush(Color.Black), new RectangleF(Convert.ToSingle((sx*(alpha*kk + z)) + DelX), Convert.ToSingle((chart1.Height -  (sy*jj)) - DelY), 40, 35));
            }
        }

        public double interp(double a1, double a2, double a, int x1, int x2)//интерполяция точки между узлами
        {
            if (Math.Round(a) == Math.Round(a1)) return x1;
            if (Math.Round(a) == Math.Round(a2)) return x2;
            else
            {
                if (a1 < a2) return ((x1 + Math.Abs((a - a1) / (a - a2)) * x2) / (1 + Math.Abs((a - a1) / (a - a2))));
                if (a1 > a2) return ((x2 + Math.Abs((a - a1) / (a - a2)) * x1) / (1 + Math.Abs((a - a1) / (a - a2))));
            }
            return 0;
        }

        public void MaxMin(double[,] Grid, int NumIso, ref double Max, ref double Min, ref double Step)
        {
            Max = Grid[0, 0];
            Min = Grid[0, 0];
            for(int i = 0; i < Grid.GetLength(0); i++)
                for (int j = 0; j < Grid.GetLength(1); j++)
                {
                    if (Max < Grid[i, j]) Max = Grid[i, j];
                    if (Min > Grid[i, j]) Min = Grid[i, j];
                }
            Step = (Max - Min) / NumIso;
        }

        public void NewGrid(double[,] OldGrid, ref double[,] NGrid)
        {
            NGrid = new double[2 * OldGrid.GetLength(0), OldGrid.GetLength(1)];

            for(int i = 0; i < OldGrid.GetLength(0); i++)
                for (int j = 0; j < OldGrid.GetLength(1); j++)
                {
                    NGrid[i, j] = OldGrid[(OldGrid.GetLength(0) - 1) - i, j];
                }

            for(int i = OldGrid.GetLength(0); i < NGrid.GetLength(0); i++)
                for (int j = 0; j < NGrid.GetLength(1); j++)
                {
                    NGrid[i, j] = Grid[i - OldGrid.GetLength(0), j];
                }
        }


        public void DrawValue(string Param, double st, Color Clr, PictureBox pick, ref int YLast)
        {
            Graphics G;
            G = pick.CreateGraphics();

            if (YLast == 0)
            {
                G.FillRectangle(new SolidBrush(Clr), new Rectangle(20, 20, 50, 20));
                G.DrawString(Param + (st).ToString("000.000"), new Font("Times New Roman", 14, FontStyle.Bold), new SolidBrush(Color.Black), new PointF(90, 20));
            }
            else
            {
                G.FillRectangle(new SolidBrush(Clr), new Rectangle(20, YLast + 20, 50, 20));
                G.DrawString(Param + (st).ToString("000.000"), new Font("Times New Roman", 14, FontStyle.Bold), new SolidBrush(Color.Black), new PointF(90, Convert.ToSingle(YLast + 20)));
            }
            YLast += 30;
        }

        public void RoRazm(ref double[,] Ro)
        {
            for (int i = 0; i < Ro.GetLength(0); i++)
                for (int j = 0; j < Ro.GetLength(1); j++)
                    Ro[i, j] *= 0.0236 * Math.Exp(-(j * h2 + StartY));
        }

        private void button1_Click(object sender, EventArgs e)
        {


            ClearCanv(chart1);
            Graphics c = pictureBox1.CreateGraphics();
            c.Clear(Color.White);
            int NumIsolines, R, G, B;
            double Min = 0, Max = 0;
            double StepIso = 0;
            double st = 0;
            int signx = 1;
            string S;
            Color Clr = Color.Black;

            double Haracter = Convert.ToDouble(textBox17.Text);

            Mx = Convert.ToDouble(textBox2.Text);
            My = Convert.ToDouble(textBox3.Text);
            /*Mx_Axes = (Convert.ToDouble(textBox11.Text) - StartX) / (EndX - StartX);
            My_Axes = (Convert.ToDouble(textBox12.Text) - StartY) / (EndY - StartY);*/
            //alphax = Convert.ToDouble(textBox6.Text);
            //z = Convert.ToDouble(textBox7.Text);
            //alphax = (EndX - StartX) / (Convert.ToDouble(textBox11.Text) - Convert.ToDouble(textBox8.Text));
            //textBox6.Text = alphax.ToString();
            //if (alphax > 1) signx = -1; else signx = 1;
            StartX = Convert.ToDouble(textBox8.Text);
            StartY = Convert.ToDouble(textBox13.Text);

            EndX = Convert.ToDouble(textBox11.Text);
            EndY = Convert.ToDouble(textBox12.Text);

            S = textBox10.Text;
            Hx = Convert.ToDouble(textBox9.Text);
            Hy = Convert.ToDouble(textBox14.Text);

            //RoRazm(ref Grid);
            NumIsolines = Convert.ToInt32(textBox1.Text);
            MaxMin(NGrid, NumIsolines, ref Max, ref Min, ref StepIso);
            double m, n;
            m = (chart1.Width - 2 * DelX) / (Mx * NGrid.GetLength(0));
            n = (chart1.Height - 2 * DelY) / (My * NGrid.GetLength(1));

            m_axes = (chart1.Width - 2 * DelX) / (0.99 * Mx_Axes * (EndX - StartX));
            n_axes = (chart1.Height - 2 * DelY) / (0.99 * My_Axes * (EndY - StartY));
            double Delta = Convert.ToDouble(textBox4.Text);
            DrawXYGrid(m_axes, n_axes, Mx_Axes * (EndX - StartX), My_Axes * (EndY - StartY), Convert.ToInt32(Hx / h1), Convert.ToInt32(Hy / h2), chart1, Delta);
            double MaxDrw = 8.0;
            double MinDrw = 0.2;
            int YLast = 0;
            R = Math.Abs(Convert.ToInt32(((Min + StepIso / 2 - Min) / (Max - Min)) * 255));
            G = Math.Abs(Convert.ToInt32((((Max - (Min + StepIso / 2)) * (Min + StepIso / 2 - Min)) / (0.25 * Math.Pow(Max - Min, 2))) * 255));
            B = Math.Abs(Convert.ToInt32(((Max - (Min + StepIso / 2)) / (Max - Min)) * 255));
            /*R = Math.Abs(Convert.ToInt32(((Min + StepIso / 2 - MinDrw) / (MaxDrw - MinDrw)) * 255));
            G = Math.Abs(Convert.ToInt32((((MaxDrw - (Min + StepIso / 2)) * (Min + StepIso / 2 - MinDrw)) / (0.25 * Math.Pow(MaxDrw - MinDrw, 2))) * 255));
            B = Math.Abs(Convert.ToInt32(((MaxDrw - (Min + StepIso / 2)) / (MaxDrw - MinDrw)) * 255));*/
            Clr = Color.FromArgb(R, G, B);
            //if (Math.Abs(1 - alphax) >= 1E-5) CenterXY(NGrid, Min + StepIso / 2, m, n, ref cx, ref cy); else cx = 0;
            alphax = Convert.ToDouble(textBox16.Text);
            cx = Convert.ToDouble(textBox15.Text);
            alphay = Convert.ToDouble(textBox6.Text);
            cy = Convert.ToDouble(textBox7.Text);
            //textBox7.Text = cx.ToString();
            DrawIzo(NGrid, Min + StepIso / 2, m, n, chart1, Clr, alphax, alphay, cx, cy);
            DrawValue(S + " = ", Haracter*(Min + StepIso / 2), Clr, pictureBox1, ref YLast);
            for (st = Min + 2 * StepIso; st < Max; st += StepIso)
            {
                R = Math.Abs(Convert.ToInt32(((st - Min) / (Max - Min)) * 255));
                G = Math.Abs(Convert.ToInt32((((Max - st) * (st - Min)) / (0.25 * Math.Pow(Max - Min, 2))) * 255));
                B = Math.Abs(Convert.ToInt32(((Max - st) / (Max - Min)) * 255));
                /*R = Math.Abs(Convert.ToInt32(((st - MinDrw) / (MaxDrw - MinDrw)) * 255));
                G = Math.Abs(Convert.ToInt32((((MaxDrw - st) * (st - MinDrw)) / (0.25 * Math.Pow(MaxDrw - MinDrw, 2))) * 255));
                B = Math.Abs(Convert.ToInt32(((MaxDrw - st) / (MaxDrw - MinDrw)) * 255));*/
                Clr = Color.FromArgb(R, G, B);
                DrawIzo(NGrid, st, m, n, chart1, Clr, alphax, alphay, cx, cy);
                //DrawValue(S + " = ", Haracter*st, Clr, pictureBox1, ref YLast);
            }
           // double coef = (NumIsolines - 2) / 18;
            //StepIso *= coef;
            for (st = Min + 2 * StepIso; st < Max; st += StepIso)
            {
                R = Math.Abs(Convert.ToInt32(((st - Min) / (Max - Min)) * 255));
                G = Math.Abs(Convert.ToInt32((((Max - st) * (st - Min)) / (0.25 * Math.Pow(Max - Min, 2))) * 255));
                B = Math.Abs(Convert.ToInt32(((Max - st) / (Max - Min)) * 255));
                /*R = Math.Abs(Convert.ToInt32(((st - MinDrw) / (MaxDrw - MinDrw)) * 255));
                G = Math.Abs(Convert.ToInt32((((MaxDrw - st) * (st - MinDrw)) / (0.25 * Math.Pow(MaxDrw - MinDrw, 2))) * 255));
                B = Math.Abs(Convert.ToInt32(((MaxDrw - st) / (MaxDrw - MinDrw)) * 255));*/
                Clr = Color.FromArgb(R, G, B);
                DrawValue(S + " = ", Haracter * st, Clr, pictureBox1, ref YLast);
            }
            R = Math.Abs(Convert.ToInt32(((Max - StepIso / 2 - Min) / (Max - Min)) * 255));
            G = Math.Abs(Convert.ToInt32((((Max - (Max - StepIso / 2)) * (Max - StepIso / 2 - Min)) / (0.25 * Math.Pow(Max - Min, 2))) * 255));
            B = Math.Abs(Convert.ToInt32(((Max - (Max - StepIso / 2)) / (Max - Min)) * 255));
            /*R = Math.Abs(Convert.ToInt32(((Max - StepIso / 2 - MinDrw) / (MaxDrw - MinDrw)) * 255));
            G = Math.Abs(Convert.ToInt32((((MaxDrw - (Max - StepIso / 2)) * (Max - StepIso / 2 - MinDrw)) / (0.25 * Math.Pow(MaxDrw - MinDrw, 2))) * 255));
            B = Math.Abs(Convert.ToInt32(((MaxDrw - (Max - StepIso / 2)) / (MaxDrw - MinDrw)) * 255));*/
            Clr = Color.FromArgb(R, G, B);
            //if (Math.Abs(1 - alphax) >= 1E-5) CenterXY(NGrid, Min + StepIso / 2, m, n, ref cx, ref cy); else cx = 0;
            DrawIzo(NGrid, Max - StepIso / 2, m, n, chart1, Clr, alphax, alphay, cx, cy);
            DrawValue(S + " = ", Haracter*(Max - StepIso / 2), Clr, pictureBox1, ref YLast);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                path = openFileDialog1.FileName;
                ReadWriteFunction.ReadGridFromFile(openFileDialog1.FileName, ref Grid, ref h1, ref h2, ref StartX, ref StartY);
                StartX -= Grid.GetLength(0) * h1;
                NewGrid(Grid, ref NGrid);
                EndX = StartX + NGrid.GetLength(0) * h1;
                EndY = StartY + NGrid.GetLength(1) * h2;
                Hx = (EndX - StartX) / 24;
                Hy = (EndY - StartY) / 16;
                Mx_Axes = NGrid.GetLength(0) / (EndX - StartX);
                My_Axes = NGrid.GetLength(1) / (EndY - StartY);
                m_axes = (chart1.Width - 2 * DelX) / (0.99*NGrid.GetLength(0));
                n_axes = (chart1.Height - 2 * DelY) / (0.99*NGrid.GetLength(1));


                DrawXYGrid(m_axes, n_axes, NGrid.GetLength(0), NGrid.GetLength(1), Convert.ToInt32(Hx / h1), Convert.ToInt32(Hy / h2), chart1,1);
                textBox8.Text = StartX.ToString();
                textBox11.Text = (StartX + NGrid.GetLength(0) * h1).ToString();
                textBox9.Text = Hx.ToString("000.00");
                textBox13.Text = StartY.ToString();
                textBox12.Text = (StartY + NGrid.GetLength(1) * h2).ToString();
                textBox14.Text = Hy.ToString("000.00");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //chart1.SaveImage(path, ChartImageFormat.Jpeg);
        }
    }
}
