using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace WinFormDelegates {
    public partial class ChildForm : Form {

        public delegate void onReadyDelegate(string message);

        private Timer timer;
        private int count = 0;
        private int hitCount = 0;
        private int max = 0;
        private onReadyDelegate onReady;

        public ChildForm(int maxCount, onReadyDelegate onReady) {
            InitializeComponent();
            this.onReady = onReady;

            max = maxCount;
            timer = new Timer();
            timer.Interval = 1000;
            timer.Start();
            timer.Tick += new EventHandler(timer_Tick);
        }

        private void timer_Tick(object sender, EventArgs e) {
            count++;

            if (count >= (max + 1)) {
                hitCount++;
                onReady.Invoke($"{hitCount}. time hit!");
                count = 0;
            }

            lblCounter.Text = Convert.ToString(count);
        }
    }
}
