using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ISMPrakt05ClassLibrary;

namespace ISMPrakt05WindowsFormsApp
{
    public partial class MainForm : Form
    {
        Methods method = new Methods();
        bool arrIsOk;
        long n;
        int[] arr;
        public MainForm()
        {
            InitializeComponent();
        }
        private void generateArrayBautton_Click(object sender, EventArgs e)
        {
            arrayTextBox.Text = null;
            try
            {
                n = long.Parse(colsElemetsText.Text);
                if (n <= 0)
                {
                    Error("Число элементов должно быть больше равно 0!");
                }
                
            }
            catch
            {
                Error("Число элементов должно быть больше равно 0!");
            }
            arr = method.FillArrayWhithRandVall(n);
            arrIsOk = true;
            for (long i = 0; i < arr.Length; i++)
            {
                arrayTextBox.Text += $"arr[{i}] = {arr[i]}" + Environment.NewLine;
            }
        }
        void Error(string message)
        {
            colsElemetsText = null;
            n = 0;
            MessageBox.Show(message);
        }

        private void operationComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (arrIsOk)
            {
                int num = operationComboBox.SelectedIndex + 1;
                resultLabel.Visible = true;
                switch (num)
                {
                    case 1:
                        {
                            long res = method.SumNegEls(arr);
                            resultLabel.Text = "Сумма отрицательных элементов массива: " + res + "\n";
                        }
                        break;
                    case 2:
                        {
                            long[] element = method.MaxOfPairEl(arr);
                            if (element[0] == -1) Console.Write("В массиве нету парных элементов!\n");
                            else resultLabel.Text = $"Максимальный среди парных элементов массива: arr[{element[0]}] = {element[1]}\n";
                        }
                        break;
                    case 3:
                        {
                            long res = method.DobElWhithPairIndex(arr);
                            resultLabel.Text = "Произведение элементов массива с парными индексами: " + res + "\n";
                        }
                        break;
                    case 4:
                        {
                            long res = method.IndexMaxEl(arr);
                            resultLabel.Text = "Индекс максимального элемента массива: " + res + "\n";
                        }
                        break;
                    case 5:
                        {
                            long[] element = method.MaxOfAbsEl(arr);
                            resultLabel.Text = $"Максимальный за модулем элемент массива: arr[{element[0]}] = {element[1]}\n";
                        }
                        break;
                    case 6:
                        {
                            long res = method.SumIndexPossEl(arr);
                            if (res == -1) resultLabel.Text = "Положительных элементов не найдено!\n";
                            else resultLabel.Text = "Сумма индексов положительных элемнтов: " + res + "\n";
                        }
                        break;
                    case 7:
                        {
                            long res = method.ColsAnPairEl(arr);
                            if (res == -1) resultLabel.Text = "Парных элементов не найдено!\n";
                            else resultLabel.Text = "Кл-во непарных элементов массива: " + res + "\n";
                        }
                        break;
                }
            }
            else
            {
                MessageBox.Show("Некорректные значения!");
            }
        }
    }
}
