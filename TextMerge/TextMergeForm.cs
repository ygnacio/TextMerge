using System;
using System.Windows.Forms;

namespace TextMerge
{
    public partial class TextMergeForm : Form
    {
        public TextMergeForm()
        {
            InitializeComponent();
        }

        private void MergeBtn_Click(object sender, EventArgs e)
        {
            string[] arrayText1 = textBox.Lines;
            string[] arrayText2 = AdditionalText.Lines;

            ResultText.Text = "";
            for (int i = 0; i < arrayText1.Length; i++)
            {
                ResultText.Text += prefix.Text;
                ResultText.Text += arrayText1[i];
                ResultText.Text += delimiter.Text;
                if (i < arrayText2.Length)
                {
                    ResultText.Text += arrayText2[i];
                }

                ResultText.Text += Environment.NewLine;
            }

            if (arrayText2.Length > arrayText1.Length)
            {
                for (int i = arrayText1.Length; i < arrayText2.Length; i++)
                {
                    ResultText.Text += delimiter.Text;
                    ResultText.Text += arrayText2[i];
                }
            }
        }

        private void CopyBtn_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(ResultText.Text);
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            prefix.Text = "";
            textBox.Text = "";
            delimiter.Text = "";
            AdditionalText.Text = "";
        }
    }
}