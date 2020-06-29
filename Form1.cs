using KGEU.CourseWork.JSONHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KGEU.CourseWork
{
    public partial class Form1 : Form
    {
        private List<TaskTraining> _tasks = new List<TaskTraining>();
        private int _numTask;
        TaskTraining task = new TaskTraining();
        string[] arrayAnswers = new string[4];
        public Form1()
        {
            InitializeComponent();          
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void buttonToAnswer_Click(object sender, EventArgs e)
        {
            if (CheckCurrentAnswer() && _numTask < _tasks.Count - 1)
            {
                _numTask++;
                FillUpOrUpdateForm();
            } else if(_numTask == _tasks.Count-1)
            {
                MessageBox.Show("Вы прошли обучение по языку C#");
            }
        }
        private void buttonBack_Click(object sender, EventArgs e)
        {
            if (_numTask > 0)
            {
                _numTask--;

                FillUpOrUpdateForm();
            }
        }

        private void LoadData(string fileName = "user.json")
        {
            _numTask = 0;
            JSONReader reader = new JSONReader();
            _tasks.AddRange(reader.GetDeserializeJSON(fileName));
            FillUpOrUpdateForm();
        }

        private void FillUpOrUpdateForm()
        {
            AllItemsVisibleFalse();
            if (_numTask < _tasks.Count)
            {
                task = _tasks[_numTask];
                arrayAnswers[0] = _tasks[_numTask].firstAnswer;
                arrayAnswers[1] = _tasks[_numTask].secondAnswer;
                arrayAnswers[2] = _tasks[_numTask].thirdthAnswer;
                arrayAnswers[3] = _tasks[_numTask].fourth;

                arrayAnswers = СhangePlacesArray(arrayAnswers);              
            }
            taskDescription.Text = task.taskDescription;

            if (_tasks[_numTask].typeTask == 0)
            {
                //taskDescription.Height = 350;
                taskDescription.Dock = DockStyle.Fill;
            }
            else if (_tasks[_numTask].typeTask == 1)
            {
                //taskDescription.Height = 185;
                taskDescription.Dock = DockStyle.None;
                LoadFormWithMargins();
            }
            else if (_tasks[_numTask].typeTask == 2)
            {
                //taskDescription.Height = 185;
                taskDescription.Dock = DockStyle.None;
                LoadFormWithRadioButton();
            }
        }

        private void AllItemsVisibleFalse()
        {
            textBoxFirstAnswer.Visible = false;
            textBoxSecondAnswer.Visible = false;
            textBoxThirdAnswer.Visible = false;
            richTextBoxExample.Visible = false;
            radioButton1.Visible = false;
            radioButton2.Visible = false;
            radioButton3.Visible = false;
            radioButton4.Visible = false;
        }
        private void LoadFormWithRadioButton()
        {
            radioButton1.Visible = true;
            radioButton2.Visible = true;
            radioButton3.Visible = true;
            radioButton4.Visible = true;

            radioButton1.Text = arrayAnswers[0];
            radioButton2.Text = arrayAnswers[1];
            radioButton3.Text = arrayAnswers[2];
            radioButton4.Text = arrayAnswers[3];
        }
        private void LoadFormWithMargins()
        {

            richTextBoxExample.Visible = true;
            textBoxFirstAnswer.Visible = true;
            if (_tasks[_numTask].thirdthAnswer != "")
            {
                textBoxSecondAnswer.Visible = true;
            }
            if (_tasks[_numTask].fourth != "")
            {
                textBoxThirdAnswer.Visible = true;
            }

            richTextBoxExample.Text = task.firstAnswer;
        }
        private string[] СhangePlacesArray(string[] arr)
        {
            Random random = new Random();
            for (int i = arr.Length - 1; i >= 1; i--)
            {
                int j = random.Next(i + 1);
                var temp = arr[j];
                arr[j] = arr[i];
                arr[i] = temp;
            }
            return arr;
        }
        private bool CheckCurrentAnswer()
        {
            if (task.typeTask == 0)
            {
                return true;
            }
            else if (task.typeTask == 1)
            {
                //return CheckMargins();
                return true;
            }
            else if (task.typeTask == 2)
            {
                //return CheckRadioButton();
                return true;
            }
            return false;
        }
        private bool CheckRadioButton()
        {
            if (!radioButton1.Checked & !radioButton2.Checked & !radioButton3.Checked & !radioButton4.Checked)
            {
                MessageBadResult("Выберете вариант ответа.");
                return false;
            }
            if (radioButton1.Checked)
            {
                radioButton1.Checked = false;
                if (radioButton1.Text.Equals(task.firstAnswer))
                    return true;
            }
            else if (radioButton2.Checked)
            {
                radioButton2.Checked = false;
                if (radioButton2.Text.Equals(task.firstAnswer))
                    return true;
            }
            else if (radioButton3.Checked)
            {
                radioButton3.Checked = false;
                if (radioButton3.Text.Equals(task.firstAnswer))
                    return true;
            }
            else if (radioButton4.Checked)
            {
                radioButton4.Checked = false;
                if (radioButton4.Text.Equals(task.firstAnswer))
                    return true;
            }
            MessageBadResult("Не верно");
            return false;
        }

        private bool CheckMargins()
        {
            if (!task.secondAnswer.Equals(textBoxFirstAnswer.Text) || 
                !task.thirdthAnswer.Equals(textBoxSecondAnswer.Text) || 
                !task.fourth.Equals(textBoxThirdAnswer.Text))
            {
                MessageBadResult("Не верно");
                return false;
            }
            return true;
        }
        private void MessageBadResult(string value)
        {
            MessageBox.Show(value);
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "Json files (*.json)|*.json";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    LoadData(openFileDialog.FileName);
                }
            }
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
