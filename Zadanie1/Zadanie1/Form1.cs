using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadanie1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            inputA.Text = "0";
            inputB.Text = "0";

            if (!EventLog.SourceExists("KalkulatorDzielenia"))
            {
                EventLog.CreateEventSource("KalkulatorDzielenia", "MyNewLog");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (inputA.Text == null || inputA.Text == string.Empty ||
                inputB.Text == null || inputB.Text == string.Empty)
            {
                EventLog eventLog = new EventLog();
                eventLog.Source = "KalkulatorDzielenia";
                eventLog.WriteEntry("Pola danych były puste", EventLogEntryType.Warning);
                MessageBox.Show("Uzupełnij pola wejściowe");
                return;
            }

            double a = 0.0;
            double b = 0.0;

            try
            {
                a = double.Parse(inputA.Text);
                b = double.Parse(inputB.Text);
            }
            catch
            {
                EventLog eventLog = new EventLog();
                eventLog.Source = "KalkulatorDzielenia";
                eventLog.WriteEntry("Nieprawidłowe dane wejściowe", EventLogEntryType.Error);
                MessageBox.Show("Jedna z danych wejściowych ma niepoprawny format");
                return;
            }

            if (b == 0.0)
            {
                EventLog eventLog = new EventLog();
                eventLog.Source = "KalkulatorDzielenia";
                eventLog.WriteEntry("Próba podzielenia przez 0", EventLogEntryType.Error);
                MessageBox.Show("Nie można dzielić przez 0!");
                return;
            }

            inputOutput.Text = (a / b).ToString();
        }

        private void inputA_TextChanged(object sender, EventArgs e)
        {
            string temp = ((TextBox)sender).Text;
            inputA.Text = new string(temp.Where(c => (c >= '0' && c <= '9') || c == ',').ToArray());
        }

        private void inputB_TextChanged(object sender, EventArgs e)
        {
            string temp = ((TextBox)sender).Text;
            inputB.Text = new string(temp.Where(c => (c >= '0' && c <= '9') || c == ',').ToArray());
        }
    }
}
