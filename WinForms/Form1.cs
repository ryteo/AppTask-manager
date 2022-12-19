using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using IWshRuntimeLibrary;

namespace WinForms
{
    public partial class Form1 : Form
    {
        string Path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        string[] str = {
            "notepad",
            "calc",
            "mspaint",
            "desk.cpl",
            "regedit",
            "cmd",
            "write",
            "control",
            "sndvol",
            "msinfo32",
            "mmsys.cpl",
            "inetcpl.cpl",
            "timedate.cpl"};
        char point = '.';
        public Form1()
        {
            InitializeComponent();
            ShowProcess();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            textBoxName.Text = "Введите имя";
            textBoxPath.Text = "Введите путь";
            ShowProcess();
            listBox1__Fill();
        }
        private void listBox1__Fill()
        {
            string Path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            DirectoryInfo dr = new DirectoryInfo(Path);
            foreach (var d in dr.GetDirectories())
            {
                listBox1.Items.Add(d.Name);
            }
            foreach (var d in dr.GetFiles())
            {
                listBox1.Items.Add(d.Name);
            }
            listBox1.Items.AddRange(str);
        }
        private void textBoxName_Leave(object sender, EventArgs e)
        {
            if (textBoxName.Text == "")
                textBoxName.Text = "Введите имя";
        }
        private void textBoxName_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text == "Введите имя")
                textBoxName.Clear();
        }
        private void textBoxID_Leave(object sender, EventArgs e)
        {
            if (textBoxPath.Text == "")
                textBoxPath.Text = "Введите путь";
        }
        private void textBoxID_Click(object sender, EventArgs e)
        {
            if (textBoxPath.Text == "Введите путь")
                textBoxPath.Clear();
        }
        void ShowProcess()
        {
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            var allProcess = from pr in Process.GetProcesses(".")
                             orderby pr.Id
                             select pr;
            foreach (var proc in allProcess)
            {
                string[] arr = { "" + proc.Id, "" + proc.ProcessName, "" + proc.WorkingSet64 };
                dataGridView1.Rows.Add(arr);
            }
        }
        private void btnDelName_Click(object sender, EventArgs e)
        {
            var allProcess = from pr in Process.GetProcesses(".")
                             orderby pr.Id
                             select pr;
            foreach (var proc in allProcess)
            {
                if (proc.ProcessName == textBoxDelName.Text)
                {
                    proc.Kill();
                }
            }
            dataGridView1.Rows.Clear();
            ShowProcess();
        }

        private void btnDelID_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                string value1 = row.Cells[0].Value.ToString();
                Process.GetProcessById(Convert.ToInt32(value1)).Kill();
            }
            dataGridView1.Rows.Clear();
            ShowProcess();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            bool flag = false;
            try
            {
                if (listBox1.SelectedItems.Count == 0)
                {
                    MessageBox.Show(
                    "Вы не выбрали файл!",
                    "Сообщение",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1);
                }
                else
                {
                    string Path2 = listBox1.SelectedItem.ToString();
                    for (int i = 0; i < str.Length; i++)
                    {
                        if (str[i] == Path2)
                        {
                            flag = true;
                        }
                    }

                    if (flag)
                    {
                        Process.Start(Path2);
                    }
                    else
                    {
                        Process.Start($@"{Path}/{Path2}");
                    }
                }
            }
            catch
            {
                MessageBox.Show(
                    "Вы не выбрали файл!",
                    "Сообщение",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1);
            }
        }

        private void btnDelLabel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listBox1.SelectedItems.Count == 0)
                {
                    MessageBox.Show(
                    "Вы не выбрали файл!",
                    "Сообщение",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1);
                }
                else
                {
                    DialogResult result = MessageBox.Show(
                        "Вы точно хотите удалить?",
                        "Сообщение",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Information,
                        MessageBoxDefaultButton.Button1);

                    if (result == DialogResult.Yes)
                    {
                        string Path2 = listBox1.SelectedItem.ToString();
                        string str = $@"{Path}\{Path2}";

                        if (Path2.Contains(point))
                        {
                            System.IO.File.Delete(str);
                        }
                        else
                        {
                            Directory.Delete(str);
                        }
                        listBox1.Items.Clear();
                        listBox1__Fill();
                        listBox1.ClearSelected();
                    }
                }

            }
            catch
            {
                MessageBox.Show(
                    "Удалить файл невозможно!",
                    "Сообщение",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1__Fill();
        }
        private void btnAddLabel_Click(object sender, EventArgs e)
        {
            if ((textBoxName.Text == "" || textBoxName.Text == "Введите имя") || (textBoxPath.Text == "" || textBoxPath.Text == "Введите путь"))
            {

            }
            else
            {
                WshShell shell = new WshShell();

                //путь к ярлыку
                string shortcutPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + $@"\{textBoxName.Text}.lnk";

                //создаем объект ярлыка
                IWshShortcut shortcut = (IWshShortcut)shell.CreateShortcut(shortcutPath);

                //задаем свойства для ярлыка
                //описание ярлыка в всплывающей подсказке
                shortcut.Description = "Ярлык для текстового редактора";
                //путь к самой программе
                shortcut.TargetPath = textBoxPath.Text;

                //Создаем ярлык
                shortcut.Save();
            }
        }

        private void TooltextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
