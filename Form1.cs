using System;
using System.Drawing;
using System.Windows.Forms;
//сторонние
using delRendererFunction = Plot3D.Graph3D.delRendererFunction;
using eRaster = Plot3D.Graph3D.eRaster;
using eNormalize = Plot3D.Graph3D.eNormalize;
using eSchema = Plot3D.ColorSchema.eSchema;

namespace _3D_Chart_Graph
{
    public partial class Form1 : Form
    {
        double a = 0;
        double b = 1;
        double ep = 0.0001;
        public Form1()
        {
            InitializeComponent();
        }
        #region Блок с вычислением
        double Func(double x, double y)
        {
            return (Math.Exp(x) + y) / (1 + x);
        }
        static double fi1(double x)
        {
            return Math.Log(1 + x);
        }
        static double fi2(double x)
        {
            return 1 + 2 * Math.Log(1 + x);
        }
        public double X(double u)
        {
            return a + u * (b - a);
        }
        double Y(double u, double v)
        {
            return fi1(X(u)) + v * (fi2(X(u)) - fi1(X(u)));
        }
        double Jacob(double Xn)
        {
            return (fi2(X(Xn)) - fi1(X(Xn)))* (b - a);
        }

        double IntegralFinder(int nX, int nY)
        {
            double Yn, Xn, sum = 0, hx = 1 / nX, hy = 1 / nY, finiteCell = hx * hy;

            for (double u = 0; u < 1; u += hx)
            {
                for (double v = 0; v < 1; v += hy)
                {
                    Xn = u + hx / 2;
                    Yn = v + hy / 2;
                    double Jacobian = Math.Abs(Jacob(Xn));
                    sum += Func(Xn, Yn) * Jacobian;
                }
            }
            return sum * finiteCell;
        }
        public double RungeRule(int nx, int ny)
        {
            double Integral1, Integral2;
            do
            {
                Integral1 = IntegralFinder(nx, ny);
                nx *= 2;
                ny *= 2;
                Integral2 = IntegralFinder(nx, ny);
            } while (Math.Abs((Integral2 - Integral1) / 3) > ep);
            return Integral2 + (Integral2 - Integral1) / 3;
        }
        #endregion


        private void show_all_Click(object sender, EventArgs e)
        {
            new Plot3D.Graph3DMainForm().ShowDialog();
        }
 

        private void formula_Click(object sender, EventArgs e)
        {
            SetFormula("(exp(x) + y) / (1 + x)");
            graph3D1.Raster = (eRaster)1;
            Color[] c_Colors = Plot3D.ColorSchema.GetSchema((eSchema)1);
            graph3D1.SetColorScheme(c_Colors, 3);
        }
        private void SetFormula(string s_Formula)
        {
            try
            {
                delRendererFunction f_Function = Plot3D.FunctionCompiler.Compile(s_Formula);

                // IMPORTANT: Normalize maintainig the relation between X,Y,Z values otherwise the function will be distorted.
                int nx = int.Parse(textBox1.Text);
                int ny = nx;

                for (int i = 0; i < nx; i++)
                {
                    for (int j = 0; j < ny; j++)
                    {
                        double x = X((double)i / nx);
                        double y = Y((double)i / nx, (double)j / ny);
                        double z = Func(x, y);
                        //nx = 20 .. 100
                        // Добавляем точку на график
                        graph3D1.SetFunction(f_Function, new PointF(-5, -5), new PointF(5, 5), z, eNormalize.MaintainXYZ);
                    }
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }   
    }
}