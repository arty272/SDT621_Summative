namespace SectionCQuestion1
{
    public partial class Form1 : Form
    {
        // In-memory temporary storage for mobile phone records (no SQL database)
        private readonly Dictionary<string, MobilePhone> _store = new();

        private record MobilePhone(string MobileCode, string Make, int Quantity);

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object? sender, EventArgs e)
        {
            var code = txtCode.Text.Trim();
            var make = txtMake.Text.Trim();
            if (!int.TryParse(txtQuantity.Text.Trim(), out var qty)) qty = 0;

            if (string.IsNullOrEmpty(code))
            {
                lblOutput.Text = "MobileCode required";
                return;
            }

            // Insert or update in temporary store
            _store[code] = new MobilePhone(code, make, qty);
            lblOutput.Text = "Record Added";
        }

        private void btnDelete_Click(object? sender, EventArgs e)
        {
            var code = txtCode.Text.Trim();
            if (string.IsNullOrEmpty(code))
            {
                lblOutput.Text = "MobileCode required";
                return;
            }

            var removed = _store.Remove(code);
            if (removed)
            {
                // Changed out to record deleted not found
                lblOutput.Text = "Record Deleted";
            }
            else
            {
                lblOutput.Text = "Record NOT Found";
            }
        }

        private void btnFind_Click(object? sender, EventArgs e)
        {
            var code = txtCode.Text.Trim();
            if (string.IsNullOrEmpty(code))
            {
                lblOutput.Text = "MobileCode required";
                return;
            }

            if (_store.TryGetValue(code, out var phone))
            {
                // Changed out to record found
                lblOutput.Text = "Record Found";
                //populate fields with found data
                txtMake.Text = phone.Make;
                txtQuantity.Text = phone.Quantity.ToString();
            }
            else
            {
                lblOutput.Text = "Record NOT Found";
            }
        }
    }
}
