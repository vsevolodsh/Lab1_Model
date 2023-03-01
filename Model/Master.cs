using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Model
{
    public partial class Master : Form
    {
        public Master()
        {
            InitializeComponent();
        }
        public List<string> stringList = new List<string>(80); // входная строка
        Dictionary<int, string> variableDictionary = new Dictionary<int, string>() //Словарь имен переменных 
        {
            {0, "a"}, {1, "b"}, {2, "c"},
            {3, "d"}, {4, "e"}, {5, "f"}
        };
        Dictionary<int, string> operatorDictionary = new Dictionary<int, string>() //Словарь операторов 
        {
            {0, "+"}, {1, "-"}, {2, "*"},
            {3, "/"}, {4, "^"},
        };
        Dictionary<int, string> funcDictionary = new Dictionary<int, string>() //Словарь функций
        {
            {0, "sin"}, {1, "cos"}, {2, "ln"},
            {3, "arcsin"}, {4, "arccos"},
        };

        void buttonCloseClick(object sender, EventArgs e) //Обработчик события нажатия кнопки Close
        {
            textBoxMasterF.Clear();
            stringList.Clear();
            Close();
        }

        private void buttonOk_Click(object sender, EventArgs e) //Обработчик события нажатия кнопки Ok
        {
            if (stringList.Count <= 1)
            {
                labelError.Text = "Выражение должно содержать хотя бы 1 элемент";
            }
            else if (variableDictionary.ContainsValue(stringList[stringList.Count - 1]) || stringList[stringList.Count - 1].Equals(")"))
            //если выражение заканчивается переменной или символом )
            {
                Close();
            }
            else
            {
                labelError.Text = "Выражение должно заканчиваться переменной или закрывающей скобкой";
            }
        }

        private void buttonClear_Click(object sender, EventArgs e) //Обработчик события нажатия кнопки Clear
        {
            textBoxMasterF.Clear();
            stringList.Clear();
            labelError.Text = "";
        }

        #region Обработчики событий для кнопок символов

        private void buttonVarA_Click(object sender, EventArgs e) => printNewElement("a");
        private void buttonVarB_Click(object sender, EventArgs e) => printNewElement("b");
        private void buttonVarC_Click(object sender, EventArgs e) => printNewElement("c");
        private void buttonVarD_Click(object sender, EventArgs e) => printNewElement("d");
        private void buttonVarE_Click(object sender, EventArgs e) => printNewElement("e");
        private void buttonVarF_Click(object sender, EventArgs e) => printNewElement("f");

        private void buttonParenthesesOpened_Click(object sender, EventArgs e) => printNewElement("(");
        private void buttonParenthesesClosed_Click(object sender, EventArgs e) => printNewElement(")");
        private void buttonPlus_Click(object sender, EventArgs e) => printNewElement("+");
        private void buttonMinus_Click(object sender, EventArgs e) => printNewElement("-");
        private void buttonDivision_Click(object sender, EventArgs e) => printNewElement("/");
        private void buttonMultipl_Click(object sender, EventArgs e) => printNewElement("*");
        private void buttonStepen_Click(object sender, EventArgs e) => printNewElement("^");
        private void buttonLn_Click(object sender, EventArgs e)
        {
            printNewElement("ln");
            printNewElement("(");
        }
        private void buttonSin_Click(object sender, EventArgs e)
        {
            printNewElement("sin");
            printNewElement("(");
        }

        private void buttonCos_Click(object sender, EventArgs e)
        {
            printNewElement("cos");
            printNewElement("(");

        }

        private void buttonArcsin_Click(object sender, EventArgs e)
        {
            printNewElement("arcsin");
            printNewElement("(");
        }

        private void buttonArccos_Click(object sender, EventArgs e)
        {
            printNewElement("arccos");
            printNewElement("(");
        }
        #endregion

        private void buttonBackSp_Click(object sender, EventArgs e) // Обработчик события нажатие кнопки BackSp
        {
            string temp = textBoxMasterF.Text, str; // присваиваем переменной типа string значение текст из текстового поля textBoxMasterF
            if (stringList.Count > 0) // если есть элементы в буфферном списке для цифр или в списке всех элементов выражения
            {
                str = stringList[stringList.Count - 1]; // присвоение элементу типа string значение последнего элемента списка всех элементов выражения
                stringList.RemoveAt(stringList.Count - 1); // удаляем последний элемент в списке всех элементов выражения
            }
            temp = temp.Substring(0, temp.Length - 1); // обрезаем строку с начала до предпоследнего элемента
            textBoxMasterF.Clear();                    // очищаем текстовое поле textBoxMasterF
            textBoxMasterF.AppendText(temp);           // добавляем текст к концу строки в текстовом поле textBoxMasterF
            textBoxMasterF.Focus();                    // показываем курсор
        }

        private void printNewElement(string symbol)
        {
            if (stringList.Count < 80 && isNewElementCorrect(symbol))
            {
                textBoxMasterF.AppendText(symbol);
                textBoxMasterF.Focus();
            }
        }

        private bool isNewElementCorrect(string symbol) //Проверка на верное написание символа
        {
            if (variableDictionary.ContainsValue(symbol))
            {
                if (stringList.Count!= 0 && variableDictionary.ContainsValue(stringList[stringList.Count - 1]))
                {
                    labelError.Text = "Перед переменной должен стоять символ операции!";
                    return false;
                }
                else
                {
                    labelError.Text = "";
                    stringList.Add(symbol);
                    return true;
                }
                
            }
            else if (symbol.Equals("(")) // Проверка для (
            {
                if (stringList.Count == 0)
                {
                    labelError.Text = "";
                    stringList.Add(symbol);
                    return true;
                }
                else if (!operatorDictionary.ContainsValue(stringList[stringList.Count - 1])
                    && !funcDictionary.ContainsValue(stringList[stringList.Count - 1]) && variableDictionary.ContainsValue(stringList[stringList.Count - 1])
                    && !stringList[stringList.Count - 1].Equals("("))
                {
                    labelError.Text = "Перед скобкой должен стоять символ операции!";
                    return false;
                }
                else
                {
                    labelError.Text = "";
                    stringList.Add(symbol);
                    return true;
                }

            }
            else if (symbol.Equals(")"))// Проверка для )
            {
                if (stringList[stringList.Count - 1].Equals("("))
                {
                    labelError.Text = "Скобки не могут быть пустыми!";
                    return false;
                }
                else if (!variableDictionary.ContainsValue(stringList[stringList.Count - 1])
                    && !stringList[stringList.Count - 1].Equals(")"))
                {
                    labelError.Text = "Слева от закрывающей скобки должнв стоять какая-то переменная!";
                    return false;
                }
                else
                {
                    labelError.Text = "";
                    stringList.Add(symbol);
                    return true;
                }
            }
            else if (operatorDictionary.ContainsValue(symbol)) //проверка для символов
            {
                if (stringList.Count == 0)
                {
                    labelError.Text = "Напишите переменную!";
                    return false;
                }
                else if (!stringList[stringList.Count - 1].Equals(")") && !variableDictionary.ContainsValue(stringList[stringList.Count - 1])
                    || operatorDictionary.ContainsValue(stringList[stringList.Count - 1])
                    || stringList[stringList.Count - 1].Equals("("))
                {
                    labelError.Text = "Напишите число!";
                    return false;
                }
                else
                {
                    stringList.Add(symbol);
                    return true;
                }
            }
            else // Проверка для функций
            {
                if (stringList.Count == 0)
                {
                    labelError.Text = "";
                    stringList.Add(symbol);
                    return true;
                }
                if (variableDictionary.ContainsValue(stringList[stringList.Count - 1]))
                {
                    labelError.Text = "Перед функцией должен стоять знак!";
                    return false;
                }
                if (!operatorDictionary.ContainsValue(stringList[stringList.Count - 1]) && !stringList[stringList.Count - 1].Equals("("))
                {
                    labelError.Text = "";
                    return false;
                }
                else
                {
                    stringList.Add(symbol);
                    return true;
                }
            }
        }
    }
}