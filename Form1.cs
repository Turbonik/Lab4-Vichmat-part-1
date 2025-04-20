using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4VichMatka
{
    public partial class Form1 : Form
    {
        private const string format = "0.00000000";
       

        public Form1()
        {
            InitializeComponent();
        }

        private void CalculateDerivativeButton_Click(object sender, EventArgs e)
        {
            double[] xPoints = { 0.01, 0.1, 1, 10, 100 };
            double[] steps = { 0.1, 0.01, 0.001, 0.0001, 0.00001, 0.000001, 0.0000001, 0.00000001 };
            double derivative;
            double analyticalDerivative;
            double best_step = double.NaN;
            double last_difference = double.MaxValue;
            double difference = 0;

            StringBuilder resultsBuilder = new StringBuilder();
            StringBuilder best_stepBuilder = new StringBuilder();

            foreach (double x in xPoints)
            {
                resultsBuilder.AppendLine($"Точка: x = {x}");
                best_step = double.NaN; 
                last_difference = double.MaxValue;
                difference = 0;

           
                foreach (double h in steps)
                {
          
                    derivative = Derivative.CalculateDerivative(x, h);

                    analyticalDerivative = 8 * x;

                    difference = Math.Abs(derivative - analyticalDerivative);

                    if (difference < last_difference)
                    {
                   
                        last_difference = difference;
                        best_step = h;
                    }
                    resultsBuilder.AppendLine($"  Шаг h = {h}, Производная = {derivative.ToString(format)}, Аналитическая = {analyticalDerivative.ToString(format)}, Отклонение = {difference.ToString(format)}");

                }
         
                best_stepBuilder.AppendLine($"Для точки x = {x} оптимальный шаг = {best_step} ");
                resultsBuilder.AppendLine();
                OutputLabel.Text = resultsBuilder.ToString();
                BestStep.Text = best_stepBuilder.ToString();
            }
        }

        private void CalculateDerivativeFloatButton_Click(object sender, EventArgs e)
        {
            float[] xPoints = { 0.01f, 0.1f, 1f, 10f, 100f };
            float[] steps = { 0.1f, 0.01f, 0.001f, 0.0001f, 0.00001f, 0.000001f, 0.0000001f, 0.00000001f };
            float derivative;
            float analyticalDerivative;
            float best_step = float.NaN;
            float last_difference = float.MaxValue;
            float difference = 0;

            StringBuilder resultsBuilder = new StringBuilder();
            StringBuilder best_stepBuilder = new StringBuilder();

            foreach (float x in xPoints)
            {
                resultsBuilder.AppendLine($"Точка: x = {x}");
                best_step = float.NaN;
                last_difference = float.MaxValue;
                difference = 0;


                foreach (float h in steps)
                {
                    derivative = Derivative.CalculateDerivative(x, h);
                    analyticalDerivative = 8 * x;

                    difference = Math.Abs(derivative - analyticalDerivative);

                    if (difference < last_difference)
                    {
                        last_difference = difference;
                        best_step = h;
                    }
                    resultsBuilder.AppendLine($"  Шаг h = {h}, Производная = {derivative.ToString(format)}, Аналитическая = {analyticalDerivative.ToString(format)}, Отклонение = {difference.ToString(format)}");

                }

                best_stepBuilder.AppendLine($"Для точки x = {x} оптимальный шаг = {best_step} ");
                resultsBuilder.AppendLine();
                OutputLabel.Text = resultsBuilder.ToString();
                BestStep.Text = best_stepBuilder.ToString();
            }
        }

        private void CalculateDerivativeDecimalButton_Click(object sender, EventArgs e)
        {
            decimal[] xPoints = { 0.01M, 0.1M, 1M, 10M, 100M };
            decimal[] steps = { 0.1M, 0.01M, 0.001M, 0.0001M, 0.00001M, 0.000001M, 0.0000001M, 0.00000001M };
            decimal derivative;
            decimal analyticalDerivative;
            decimal best_step = decimal.MaxValue;
            decimal last_difference = decimal.MaxValue;
            decimal difference = 0;

            StringBuilder resultsBuilder = new StringBuilder();
            StringBuilder best_stepBuilder = new StringBuilder();

            foreach (decimal x in xPoints)
            {
                resultsBuilder.AppendLine($"Point: x = {x.ToString(format)}");
                best_step = decimal.MaxValue; 
                last_difference = decimal.MaxValue;
                difference = 0;

                foreach (decimal h in steps)
                {
                    derivative = Derivative.CalculateDerivative(x, h);

                    analyticalDerivative = 8 * x;
                    difference = Math.Abs(derivative - analyticalDerivative);

                 
                    if (difference < last_difference)
                    {
                   
                        last_difference = difference;
                        best_step = h;
                    }
                    resultsBuilder.AppendLine($"  Шаг h = {h}, Производная = {derivative.ToString(format)}, Аналитическая = {analyticalDerivative.ToString(format)}, Отклонение = {difference.ToString(format)}");

                }
              
                best_stepBuilder.AppendLine($"Для точки x = {x} оптимальный шаг = {best_step.ToString(format)} ");
                resultsBuilder.AppendLine();
                OutputLabel.Text = resultsBuilder.ToString();
                BestStep.Text = best_stepBuilder.ToString();
            }
        }
    }
}