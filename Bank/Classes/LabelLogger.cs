using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank
{
    public class LabelLogger : ILogger
    {
        Label label;

        public LabelLogger(Label label)
        {
            this.label = label;
        }

        public void LogSuccess(string message)
        {
            label.Text = message;
        }

        public void LogError(string message)
        {
            label.Text = String.Format("Transaction failed: {0}", message);
        }
    }
}
