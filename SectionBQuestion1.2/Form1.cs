namespace SectionBQuestion1._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void greetButton_Click(object? sender, EventArgs e)
        {
            var name = nameTextBox.Text?.Trim();
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Please enter your name.", "Greeting", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            MessageBox.Show($"Hello {name}!", "Greeting", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
