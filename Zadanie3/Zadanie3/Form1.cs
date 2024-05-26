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
using System.Threading;
using System.Timers;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Zadanie3
{
    public partial class Form1 : Form
    {
        private delegate void SafeCallDelegate(string text);

        PerformanceCounter cpuCounter;
        PerformanceCounter ramCounter;
        System.Timers.Timer timer;

        int _cpuUsage = 0;
        int cpuUsage { get; set; }
        public Form1()
        {
            InitializeComponent();

            cpuCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total");
            ramCounter = new PerformanceCounter("Memory", "Available MBytes");

            if (!EventLog.SourceExists("MonitorWydajnosci"))
            {
                EventLog.CreateEventSource("MonitorWydajnosci", "MyNewLog");
            }

            System.Timers.Timer timer = new System.Timers.Timer(500);

            timer.Elapsed += Update;
            timer.AutoReset = true;
            timer.Enabled = true;
        }

        private void Update(Object source, ElapsedEventArgs e)
        {
            float cpuUsage = cpuCounter.NextValue();
            float availableRAM = ramCounter.NextValue();

            UpdateCPUUsage("CPU Usage: " + cpuUsage + "%");
            UpdateRAMAvaiable("RAM Available: " + availableRAM + "MB");

            if (cpuUsage > 80)
            {
                LogToEventLog($"System is under huge stress", EventLogEntryType.Warning);
            }

            if (availableRAM < 1024)
            {
                LogToEventLog($"System is low on memory", EventLogEntryType.Warning);
            }
        }

        private void UpdateCPUUsage(string str)
        {
            if (labelCPUUsage.InvokeRequired)
            {
                var d = new SafeCallDelegate(UpdateCPUUsage);
                labelCPUUsage.Invoke(d, new object[] { str });
            }
            else
            {
                labelCPUUsage.Text = str;
            }
        }

        private void UpdateRAMAvaiable(string str)
        {
            if (labelRAMAvaiable.InvokeRequired)
            {
                var d = new SafeCallDelegate(UpdateRAMAvaiable);
                labelRAMAvaiable.Invoke(d, new object[] { str });
            }
            else
            {
                labelRAMAvaiable.Text = str;
            }
        }

        private void LogToEventLog(string msg, EventLogEntryType entryType)
        {
            EventLog eventLog = new EventLog();
            eventLog.Source = "MonitorWydajnosci";
            eventLog.WriteEntry(msg, entryType);
        }
    }
}
