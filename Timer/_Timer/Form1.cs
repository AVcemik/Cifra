namespace _Timer
{
    public partial class Form1 : Form
    {
        int m, s;
        string strM, strS;

        private void timer1_Tick(object sender, EventArgs e)
        {
            string res = string.Empty;
            s--;
            if (s == 0)
            {
                m--;
                s = 59;
            }
            if (m == 0 & s==0)
            {
                timer1.Stop();
                btStart.Enabled = true;
                btStart.Text = "Пуск";
                btSetup.Enabled = true;
            }


            lbTimer.Text = m +":" + s;
        }
        private void tbMinutes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 0 && e.KeyChar <= 9) return;
            if (Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Enter) tbSecundes.Focus();
                return;

            }
            e.Handled = true;
        }
        private void tbSeconds_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 0 && e.KeyChar <= 9) return;
            if (Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Enter) btSetup.Focus();
                return;

            }
            e.Handled = true;
        }

        private void btSetup_Click(object sender, EventArgs e)
        {
            if (tbMinutes.Text == "Минуты" || tbMinutes.Text == "") m = 0;
            else m = int.Parse(tbMinutes.Text);

            if (tbSecundes.Text == "Секунды" || tbSecundes.Text == "") s = 0;
            else s = int.Parse(tbSecundes.Text)
;
            lbTimer.Text = $"{m}:{s}";
        }

        private void btStart_Click(object sender, EventArgs e)
        {
            
            if (timer1.Enabled)
            {
                timer1.Enabled = false;
                btStart.Text = "Пауза";
                btSetup.Enabled = false;
            }
            else
            {
                timer1.Enabled = true;
                btStart.Text = "Старт";
                btSetup.Enabled = true;
            }
        }

        public Form1()
        {
            InitializeComponent();
            m = s = 0;
            strM = "00";
            strS = "00";
            lbTimer.Text = "00:00";
            timer1.Interval = 300;
        }
    }
}