using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2019_Lesson13A_Part3.Views
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            if(MainTabControl.SelectedIndex != 0)
            {
                MainTabControl.SelectedIndex--;
            }
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            if (MainTabControl.SelectedIndex < MainTabControl.TabPages.Count-1)
            {
                MainTabControl.SelectedIndex++;
            }
        }

        private void SourceTextBox_MouseDown(object sender, MouseEventArgs e)
        {
            SourceTextBox.DoDragDrop(SourceTextBox.Text, DragDropEffects.Move);
            SourceTextBox.Clear();
        }

        private void TargetTextBox_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;

        }

        private void TargetTextBox_DragDrop(object sender, DragEventArgs e)
        {
            TargetTextBox.Text = e.Data.GetData(DataFormats.Text).ToString();
        }
    }
}
