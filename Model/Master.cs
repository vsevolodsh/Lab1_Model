using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        List<string> stringListBuff = new List<string>();
        int index = 0;
        bool checkPoint = false;
        Dictionary<int, string> operatorDictionary = new Dictionary<int, string>()
        {
            {0, "+"}, {1, "-"}, {2, "*"},
            {3, "/"}, {4, "^"}, {5, "("},
            {6, ")"}
        };
        Dictionary<int, string> funcDictionary = new Dictionary<int, string>()
        {
            {0, "sin"}, {1, "cos"}, {2, "ln"},
        };


        #region Обработчики событий для кнопок

        void buttonCloseClick(object sender, EventArgs e)
        {
            Close();
        }
        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxMasterF.Clear();
            stringList.Clear();
            index = 0;
            labelError.Text = "";
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

        private void buttonSin_Click(object sender, EventArgs e)
        {
            printNewElement('s');
            printNewElement('i');
            printNewElement('n');
        }

        private void buttonCos_Click(object sender, EventArgs e)
        {
            printNewElement('c');
            printNewElement('o');
            printNewElement('s');
        }

        private void buttonBackSp_Click(object sender, EventArgs e)
        {
            if (index > 0)
            {
                string temp = textBoxMasterF.Text;
                string start, finish = "";
                if (index < temp.Length)
                {
                    finish = temp.Substring(index, textBoxMasterF.Text.Length - index);
                }
                if (index > 2 && (temp.Substring(index - 3, 3).Equals("sin") || temp.Substring(index - 3, 3).Equals("cos")))
                {
                    start = temp.Substring(0, index - 3);
                    index -= 2;
                }
                else
                {
                    start = temp.Substring(0, index - 1);
                }

                textBoxMasterF.Clear();
                textBoxMasterF.AppendText(start);
                textBoxMasterF.AppendText(finish);
                index--;
            }
            textBoxMasterF.SelectionStart = index;
            textBoxMasterF.Focus();
        }

        #endregion

        private void printNewElement<T>(T symbol)
        {
            if (stringList.Count < 80 && isNewElementCorrect(symbol))
            {
                //textBoxMasterF.AppendText(symbol.ToString());
                string temp = textBoxMasterF.Text;
                string start = temp.Substring(0, index);
                string finish = "";
                if (index < temp.Length)
                {
                    finish = temp.Substring(index, textBoxMasterF.Text.Length - index);
                }
                textBoxMasterF.Clear();
                textBoxMasterF.AppendText(start);
                textBoxMasterF.AppendText(symbol.ToString());
                textBoxMasterF.AppendText(finish);
                index++;
                textBoxMasterF.SelectionStart = index;
                textBoxMasterF.Focus();
            }
        }

        private bool isNewElementCorrect<T>(T symbol)
        {
            if (int.TryParse(symbol.ToString(), out int intVariable))
            {
                //проверка будет здесь.


                stringListBuff.Add(intVariable.ToString());
                return true;
            }
            else if (symbol.Equals('.'))
            {
                if (textBoxMasterF.Text.Length == 0 || !int.TryParse(textBoxMasterF.Text.Substring(textBoxMasterF.Text.Length - 1), out intVariable))
                {
                    labelError.Text = "Перед точкой должна стоять цифра!";
                }
                else if (checkPoint)
                {
                    labelError.Text = "В одном числе не может быть несколько точек!";
                }
                else
                {
                    labelError.Text = "";
                    checkPoint = true;
                    stringListBuff.Add(symbol.ToString());
                    return true;
                }
                //сообщение об ошибки
                return false;
            }
            else
            {
                if (true) //проверка для символов
                {

                    stringList.Add(stringListToString());
                    stringList.Add(symbol.ToString());
                    checkPoint = false;
                }

                return true;
            }

        }

        //private void addNewElement<T>(T symbol)
        //{

        //}

        private string stringListToString()
        {
            string stringListString = "";
            foreach (var item in stringListBuff)
            {
                stringListString += item;
            }
            stringListBuff.Clear();
            return stringListString;
        }

        #region Перенос курсора

        // Перенос курсора на 1 символ влево
        private void buttonLeft_Click(object sender, EventArgs e)
        {
            if (index > 0)
            {
                string temp = textBoxMasterF.Text;
                if (index > 2 && (temp.Substring(index - 3, 3).Equals("sin") || temp.Substring(index - 3, 3).Equals("cos")))
                {
                    index -= 3;
                    textBoxMasterF.SelectionStart = index;
                    textBoxMasterF.Focus();
                }
                else
                {
                    index--;
                    textBoxMasterF.SelectionStart = index;
                    textBoxMasterF.Focus();
                }
            }
            else
            {
                textBoxMasterF.Focus();
            }
        }

        // Перенос курсора на 1 символ вправо
        private void buttonRight_Click(object sender, EventArgs e)
        {
            if (index < textBoxMasterF.Text.Length)
            {
                string temp = textBoxMasterF.Text;
                if (index < textBoxMasterF.Text.Length - 2 && (temp.Substring(index, 3).Equals("sin") || temp.Substring(index, 3).Equals("cos")))
                {
                    index += 3;
                    textBoxMasterF.SelectionStart = index;
                    textBoxMasterF.Focus();
                }
                else
                {
                    index++;
                    textBoxMasterF.SelectionStart = index;
                    textBoxMasterF.Focus();
                }
            }
            else
            {
                textBoxMasterF.Focus();
            }
        }

        // Перенос курсора в начало строки
        private void buttonFullLeft_Click(object sender, EventArgs e)
        {
            textBoxMasterF.SelectionStart = 0;
            textBoxMasterF.Focus();
            index = 0;
        }

        // Перенос курсора в конец строки
        private void buttonFullRight_Click(object sender, EventArgs e)
        {
            index = textBoxMasterF.Text.Length;
            textBoxMasterF.SelectionStart = index;
            textBoxMasterF.Focus();
        }

        #endregion


    }
}

