
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Model
{

    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        List<string> infixStringList = new List<string>();
        Dictionary<int, string> operatorDictionary = new Dictionary<int, string>()
        {
            {1, "+"}, {2, "-"}, {3, "*"},
            {4, "/"}, {5, "^"}, {6, "("}, {7, ")"}
        };
        Dictionary<int, string> funcDictionary = new Dictionary<int, string>()
        {
            {1, "cos"}, {2, "sin"}, {3, "ln"}
        };
        Stack<string> stack = new Stack<string>();
        int instruction = 0;

        // !!!! Словарь перевода цифр в символы

        int[,] arrTable = {
            {4, 1, 1, 1, 1, 1, 1, 5, 1, 6},
            {2, 2, 2, 1, 1, 1, 1, 2, 1, 6 },
            {2, 2, 2, 1, 1, 1, 1, 2, 1, 6 },
            {2, 2, 2, 2, 2, 1, 1, 2, 1, 6 },
            {2, 2, 2, 2, 2, 1, 1, 2, 1, 6 },
            {2, 2, 2, 2, 2, 2, 1, 2, 1, 6 },
            {5, 1, 1, 1, 1, 1, 1, 3, 1, 6 },
            {2, 2, 2, 2, 2, 1, 1, 7, 7, 6 },
        };

        void buttonMasterFClick(object sender, EventArgs e)
        {
            Master newForm = new Master();
            newForm.FormClosing += (sender1, e1) =>
            {
                infixStringList = newForm.stringList;
                textBoxInfix.Text = String.Join("", infixStringList.ToArray());
            };
            newForm.Show();

        }

        void GroupBox1Enter(object sender, EventArgs e)
        {

        }

        private void buttonStart_Click(object sender, EventArgs e)
        {

        }

        private int getRowOfInstruction()
        {
            int key = 0;
            if (infixStringList.Count == 0)
            {
                key = 0;
            }
            else if (operatorDictionary.ContainsValue(infixStringList[0]))
            {
                key = operatorDictionary.FirstOrDefault(x => x.Value == infixStringList[0]).Key;

            }
            else if (int.TryParse(infixStringList[0], out int Variable))
            {
                key = 9;
            }
            else
            {
                key = 8;
            }
            return key;
        }

        private int getColumnOfInstruction()
        {
            int key = 0;
            if (stack.Count == 0)
            {
                key = 0;
            }
            else if (operatorDictionary.ContainsValue(stack.Peek()))
            {
                key = operatorDictionary.FirstOrDefault(x => x.Value == stack.Peek()).Key;

            }
            else
            {
                key = 7;
            }
            return key;
        }

        private void buttonTact_Click(object sender, EventArgs e)
        {
            instruction = arrTable[getColumnOfInstruction(), getRowOfInstruction()];
            bool isSecondOperation = doInstruction();
            if (infixStringList.Count != 0 && !isSecondOperation)
            {
                infixStringList.RemoveAt(0);
            }

        }

        private bool doInstruction()
        {
            bool isSecondOperation = false;
            switch (instruction)
            {
                case 1:
                    stack.Push(infixStringList[0]);
                    break;
                case 2:
                    textBoxPostfix.Text += stack.Pop() + " ";
                    isSecondOperation = true;   
                    break;
                case 3:
                    stack.Pop();
                    break;
                case 4:
                    textBoxPostfix.Text += " успешное окончание преобразования;";
                    break;
                case 5:
                    textBoxPostfix.Text += " ошибка скобочной структуры;";
                    break;
                case 6:
                    textBoxPostfix.Text += infixStringList[0] + " ";
                    break;
            }
            return isSecondOperation;
        }
    }
}
