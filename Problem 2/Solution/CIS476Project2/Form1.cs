using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CIS476Project2
{
    public partial class MainForm : Form
    {
        private Handler mileHandler = new MileHandler();
        private Handler yardHandler = new YardHandler();
        private Handler footHandler = new FootHandler();

        public MainForm()
        {
            mileHandler.SetSuccessor(yardHandler);
            yardHandler.SetSuccessor(footHandler);

            InitializeComponent();
        }

        private void ConvertInput()
        {
            try
            {
                var length = mileHandler.HandleRequest(UnitComboBox.Text, InputTextBox.Text);
                length = new RoundDecorator(length);
                length = new ExpDecorator(length);
                length = new ValutaDecorator(length);
                OutputTextBox.Text = length.GetOutput();
            }
            catch (FormatException ex)
            {
                OutputTextBox.Text = "Error";
                MessageBox.Show(ex.Message, "Error");
            }
            catch (Exception ex)
            {
                OutputTextBox.Text = "Error";
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            UnitComboBox.SelectedItem = UnitComboBox.Items[0];
        }

        private void ConvertButton_Click(object sender, EventArgs e)
        {
            ConvertInput();
        }

        private void InputTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter))
            {
                ConvertInput();
            }
        }
    }
}
