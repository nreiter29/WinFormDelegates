namespace WinFormDelegates {
    public partial class MainForm : Form {

        private ChildForm? child;

        public MainForm() {
            InitializeComponent();
        }


        private void btnOpenChildForm_Click(object sender, EventArgs e) {
            child = new ChildForm(Convert.ToInt32(tbMaxCount.Text), writeToLbHitCount, writeValueToProgressBar);
            child.Show();
        }
        private void writeToLbHitCount(string message) {
            lblHitCount.Text = message;
        }
        
        private void writeValueToProgressBar(int value, int maxValue) {
            pbMain.Value = value;
            pbMain.Maximum = maxValue;
        }
    }
}