
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
        bool error = false;
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
            infixStringList.Clear();
            stack.Clear();
            textBoxRealTime.Text = "";
            textBoxInfix.Text = "";
            textBoxPostfix.Text = "";
            error = false;
            newForm.FormClosing += (sender1, e1) =>
            {
                infixStringList = newForm.stringList;
                textBoxInfix.Text = String.Join("", infixStringList.ToArray());
                textBoxRealTime.Text = textBoxInfix.Text;
            };
            newForm.Show();

        }

        void GroupBox1Enter(object sender, EventArgs e)
        {

        }

        private async void buttonStart_Click(object sender, EventArgs e)
        {
            if (radioButtonStep.Checked)
            {
                buttonTact.Enabled = true;
            }

            if (radioButtonAuto.Checked)
            {

                while (stack.Count != 0 || infixStringList.Count != 0)
                {
                    if (error)
                    {
                        return;    
                    }
                    doOneStep();
                    await Task.Delay(trackBar1.Value * 1000);
                }

            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label110.Text = String.Format("Задержка: {0} секунд", trackBar1.Value);
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
            doOneStep();

        }

        private void doOneStep()
        {

            instruction = arrTable[getColumnOfInstruction(), getRowOfInstruction()];
            textBoxRealTime.Text = "";
            bool isSecondOperation = doInstruction();
            if (infixStringList.Count != 0 && !isSecondOperation)
            {
                infixStringList.RemoveAt(0);
            }

            labelStack.Text = null;

            Stack<string> printStack = new Stack<string>(stack);
            for (int i = 0; i < stack.Count; i++)
            {
                /*if (printStack.Count == 1)
                {
                    labelStack.Text = printStack.Pop() + "  <--" + labelStack.Text;
                }
                else*/
                {
                    labelStack.Text = "\n" + printStack.Pop() + labelStack.Text;
                }
            }

            for (int i = 0; i < infixStringList.Count; i++)
            {
                textBoxRealTime.Text += infixStringList[i];
            }
            indStack();


        }

        private void indStack()
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
            switch (stack.Count)
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
                    //textBoxPostfix.Text += " успешное окончание преобразования;";
                    break;
                case 5:
                    MessageBox.Show("Ошибка скобочной структуры;");
                    error = true;
                    break;
                case 6:
                    textBoxPostfix.Text += infixStringList[0] + " ";
                    break;
            }
            return isSecondOperation;
        }

    }
}
