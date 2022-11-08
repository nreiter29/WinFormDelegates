namespace WinFormDelegates {
    public partial class MainForm : Form {

        private ChildForm? child;

        public MainForm() {
            InitializeComponent();
        }

        private void writeToLbHitCount(string message) {
            lblHitCount.Text = message;
        }

        private void btnOpenChildForm_Click(object sender, EventArgs e) {
            child = new ChildForm(Convert.ToInt32(tbMaxCount.Text), writeToLbHitCount);
            child.Show();
        }
    }
}