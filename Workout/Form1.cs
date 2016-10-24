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

namespace Workout
{
    public partial class MainWindow : Form
    {
        int currentMonth;
        int currentDay;
        int currentYear;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void HelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
           //do nothing - title menu opener
        }

        private void helpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            String fileName = "docs/help.txt";
            Process.Start("notepad.exe", fileName);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About abt = new About();
            abt.ShowDialog();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InformationEnter Info = new InformationEnter();
            Info.ShowDialog();
            if (Info.ok) {                  //only show calendar if Ok button selected on info screen
            monthCalendar1.Visible = true;
            }
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            DateTime[] dates = new DateTime[30];                //how many???

            dates[0] = monthCalendar1.SelectionRange.Start;
            DayView Current = new DayView();
            Current.Text = dates[0].ToString();
            Current.Show();
        }
    }

}
