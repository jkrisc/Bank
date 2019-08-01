using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank
{
    public class TextBoxLogger : ILogger
    {
        TextBox textBox;

        public TextBoxLogger(TextBox textBox)
        {
            this.textBox = textBox;
        }

        public void LogSuccess(string message)
        {
            textBox.AppendText(message + Environment.NewLine);
        }

        public void LogError(string message)
        {
            textBox.AppendText(String.Format("Transaction failed: {0}", message + Environment.NewLine));
        }
    }
}
