using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Model
{
    public partial class Master : Form
    {
        public Master()
        {
            InitializeComponent();
        }

        List<string> stringList = new List<string>(80);
        List<int> intList = new List<int>();

        #region Обработчики событий для кнопок

        void buttonCloseClick(object sender, EventArgs e)
        {
            Close();
        }
        private void button15_Click(object sender, EventArgs e)
        {
            textBoxMasterF.Clear();
            stringList.Clear();
        }
        private void button0_Click(object sender, EventArgs e)
        {
            printNewElement(0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            printNewElement(1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            printNewElement(2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            printNewElement(3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            printNewElement(4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            printNewElement(5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            printNewElement(6);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            printNewElement(7);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            printNewElement(8);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            printNewElement(9);
        }


        private void buttonPi_Click(object sender, EventArgs e)
        {
            printNewElement(3.14);
        }

        private void buttonPoint_Click(object sender, EventArgs e)
        {
            printNewElement('.');
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            printNewElement('+');
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            printNewElement('-');
        }

        private void buttonDivision_Click(object sender, EventArgs e)
        {
            printNewElement('/');
        }

        private void buttonMultipl_Click(object sender, EventArgs e)
        {
            printNewElement('*');
        }

        #endregion

        private void printNewElement<T>(T symbol)
        {
            if (stringList.Count < 80 && isNewElementCorrect(symbol))
            {
                textBoxMasterF.AppendText(symbol.ToString());
            }
        }

        private bool isNewElementCorrect<T>(T symbol)
        {
            if (int.TryParse(symbol.ToString(), out var intVariable))
            {
                //проверка будет здесь.


                intList.Add(intVariable);
                return true;
            }
            else if (symbol.Equals('.'))
            {
                //
                return true;
            }
            else
            {
                if (true) //проверка для символов
                {

                    stringList.Add(intListToString());
                    stringList.Add(symbol.ToString());
                }

                return true;
            }

        }

        //private void addNewElement<T>(T symbol)
        //{

        //}

        private string intListToString()
        {
            string intListString = "";
            foreach (var item in intList)
            {
                intListString += item.ToString();
            }
            intList.Clear();
            return intListString;
        }


    }
}

