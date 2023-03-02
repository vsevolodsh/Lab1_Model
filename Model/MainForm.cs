
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Model
{

    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

        }
        List<string> infixStringList = new List<string>(); // входная строка
        Dictionary<int, string> operatorDictionary = new Dictionary<int, string>() //Словарь операторов 
        {
            {1, "+"}, {2, "-"}, {3, "*"},
            {4, "/"}, {5, "^"}, {6, "("}, {7, ")"}
        };
        Dictionary<int, string> variableDictionary = new Dictionary<int, string>() //Словарь имен переменных 
        {
            {0, "a"}, {1, "b"}, {2, "c"},
            {3, "d"}, {4, "e"}, {5, "f"}
        };
        List<string> stack = new List<string>();
        int index = 1;
        List<bool> isElementActive = new List<bool>();
        int instruction = 0;
        bool exit = false;


        int[,] arrTable = {
            {4, 1, 1, 1, 1, 1, 1, 5, 1, 6},
            {2, 2, 2, 1, 1, 1, 1, 2, 1, 6 },
            {2, 2, 2, 1, 1, 1, 1, 2, 1, 6 },
            {2, 2, 2, 2, 2, 1, 1, 2, 1, 6 },
            {2, 2, 2, 2, 2, 1, 1, 2, 1, 6 },
            {2, 2, 2, 2, 2, 2, 1, 2, 1, 6 },
            {5, 1, 1, 1, 1, 1, 1, 3, 1, 6 },
            {2, 2, 2, 2, 2, 1, 1, 2, 2, 6 },
        }; // Таблица принятий решений в виде двумерного массива

        void buttonMasterFClick(object sender, EventArgs e) // Запуск мастера функций 
        {
            Master newForm = new Master();
            infixStringList.Clear(); //Перед запуском очистить все списки и строки
            stack.Clear();
            stack.Add(" ");
            isElementActive.Clear();
            isElementActive.Add(true);
            textBoxRealTime.Text = "";
            textBoxInfix.Text = "";
            textBoxPostfix.Text = "";
            exit = false;
            newForm.FormClosing += (sender1, e1) =>
            {
                infixStringList = newForm.stringList;
                textBoxInfix.Text = String.Join("", infixStringList.ToArray());
                textBoxRealTime.Text = textBoxInfix.Text;
            }; // Получение входной строки из мастера функций
            newForm.Show();

        }

        private async void buttonStart_Click(object sender, EventArgs e) //Обработчик события кнопки старт
        {
            if (radioButtonStep.Checked) // Если пошаговый режим
            {
                buttonTact.Enabled = true;
            }

            if (radioButtonAuto.Checked) //Если автоматический режми
            {

                while (stack.Count != 0 || infixStringList.Count != 0) //Пока не пустой стэк и входная строка
                {
                    if (exit) // Если ошибка скобочной структуры, остановить работу
                    {
                        return;
                    }
                    doOneStep();
                    await Task.Delay(trackBar1.Value * 1000); // задержка каждого шага в автоматическом режиме
                }

            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label110.Text = String.Format("Задержка: {0} секунд", trackBar1.Value);
        }


        private int getColumnOfInstruction() //Получаем номер столбца таблицы принятий решений  
        {
            int key = 0;
            if (infixStringList.Count == 0) //Если входная строка пустая, то возвращаем ноль (нулевой столбец)
            {
                key = 0;
            }
            else if (operatorDictionary.ContainsValue(infixStringList[0])) //Если текущий элемент входной строки оператор,
                                                                           //то возвращаем ключ по значения из словаря operatorDictionary
                                                                           //равный номеру столбца в таблице принятия решений
            {
                key = operatorDictionary.FirstOrDefault(x => x.Value == infixStringList[0]).Key;

            }
            else if (variableDictionary.ContainsValue(infixStringList[0])) //Если текущий элемент входной строки число, то возвращаем 9
            {
                key = 9;
            }
            else // Если текущий элемент входной строки функция, то возвращаем 8
            {
                key = 8;
            }
            return key;
        }

        private int getRowOfInstruction() //Получаем номер строки таблицы принятий решений  
        {
            int key = 0;
            if (index == 1)  //Если стэк пустой, то возвращаем ноль (нулевой столбец)
            {
                key = 0;
            }
            else if (operatorDictionary.ContainsValue(stack[index - 1])) //Если в вершине стэка оператор,
                                                                             //то возвращаем ключ по значения из словаря operatorDictionary, 
                                                                             //равный номеру строки в таблице принятия решений
            {
                // key = operatorDictionary.FirstOrDefault(x => x.Value == stack.Peek()).Key;
                key = operatorDictionary.FirstOrDefault(x => x.Value == stack[index - 1]).Key;

            }
            else // Если в вершине стэка функция, то возвращаем 8
            {
                key = 7;
            }
            return key;
        }

        private void buttonTact_Click(object sender, EventArgs e)
        {
            doOneStep();

        }

        private void doOneStep() // метод выполняющий один такт алгоритма перевода из инфиксной в постфиксную строку
        {

            instruction = arrTable[getRowOfInstruction(), getColumnOfInstruction()]; //По номеру строки и столбца таблицы принятия решения
                                                                                     // получаем номер действия 
            textBoxRealTime.Text = "";
            bool isSecondOperation = doInstruction(); // выполняем инструкцию и возвращаем true, если номер действия - второй
            if (infixStringList.Count != 0 && !isSecondOperation) //если входная строка не пустая и номер действия не второй
            {
                infixStringList.RemoveAt(0); //то удаляем текущий элемент входной строки
            }

            labelStack.Text = null;

            //Stack<string> printStack = new Stack<string>(stack);
            foreach (var item in stack)
            {
                labelStack.Text = "\n" + item + labelStack.Text; //Выводим содержимое стэка 
            }


            for (int i = 0; i < infixStringList.Count; i++)
            {
                textBoxRealTime.Text += infixStringList[i]; //Выводим содержимое входной строки на текущем этапе
            }
            indStack();


        }

        private void indStack() // метод для графического отображения указателя на вершину стэка
        {
            panelInd1.Visible = false;
            panelInd2.Visible = false;
            panelInd3.Visible = false;
            panelInd4.Visible = false;
            panelInd5.Visible = false;
            panelInd6.Visible = false;
            panelInd7.Visible = false;
            panelInd8.Visible = false;
            panelInd9.Visible = false;
            panelInd10.Visible = false;
            panelInd11.Visible = false;
            switch (index)
            {
                case 0:

                    break;
                case 1:
                    panelInd1.Visible = true;
                    break;
                case 2:
                    panelInd2.Visible = true;
                    break;
                case 3:
                    panelInd3.Visible = true;
                    break;
                case 4:
                    panelInd4.Visible = true;
                    break;
                case 5:
                    panelInd5.Visible = true;
                    break;
                case 6:
                    panelInd6.Visible = true;
                    break;
                case 7:
                    panelInd7.Visible = true;
                    break;
                case 8:
                    panelInd8.Visible = true;
                    break;
                case 9:
                    panelInd9.Visible = true;
                    break;
                case 10:
                    panelInd10.Visible = true;
                    break;
                case 11:
                    panelInd11.Visible = true;
                    break;
            }
        }



        private bool doInstruction() //метод выполняющий конкретное действие по его номеру
        {
            bool isSecondOperation = false;
            switch (instruction)
            {
                case 1: // номер действия = 1, тогда заносим символ из входной строки в стэк
                    stack.Add(infixStringList[0]);
                    isElementActive.Add(true);
                    index = stack.Count;
                    break;
                case 2: // номер действия = 2, тогда достаем вершину стэка и отправляем его в выходную строку
                    if (isElementActive[index - 1])
                    {
                        textBoxPostfix.Text += stack[index - 1] + " ";
                        isElementActive[index - 1] = false;
                        if (stack.Count == 1)
                        {
                            index = 1;
                            return true;
                        }
                        while (!isElementActive[index - 1] && index != 1)
                        {

                            index--;
                        }
                    }
                    isSecondOperation = true;
                    break;
                case 3:
                    // номер действия = 3, тогда удаляем вершину стэка
                    if (isElementActive[index-1])
                    {
                        isElementActive[index - 1] = false;
                        if (stack.Count == 1)
                        {
                            index = 1;
                            return false;
                        }
                        while (!isElementActive[index - 1])
                        {
                            index--;
                        }
                    }
                    break;
                case 4: //Успешное окончание преобразований
                    MessageBox.Show("Успешное окончание преобразований!");
                    exit = true;
                    break;
                case 5: // номер действия = 5, сообщаем об ошибке скобочной структуры и останавливаем работу
                    MessageBox.Show("Ошибка скобочной структуры!");
                    exit = true;
                    break;
                case 6: // номер действия = 6, пересылаем символ из входной строки в выходную
                    textBoxPostfix.Text += infixStringList[0] + " ";
                    break;
            }
            return isSecondOperation;
        }

    }
}
