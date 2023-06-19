namespace _Timer
{
    public partial class Form1 : Form
    {
        int m, s;
        string strM, strS;
        bool check = false;

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (check == true)
            {
                if (s < 10) strS = "0" + s;
                else strS = "" + s;
                if (m < 10) strM = "0" + m;
                else strM = "" + m;

                if (s == 0)
                {
                    if (m == 0 & s==0)
                    {
                        timer1.Enabled = false;
                        btStart.Enabled = true;
                        btStart.Text = "Старт";
                        btSetup.Enabled = true;
                    }
                    else
                    {
                        m--;
                        s = 59;
                    }
                }
            }
            if (check == false)
            {
                timer1.Enabled = false;
                btStart.Enabled = true;
                btStart.Text = "Старт";
                btSetup.Enabled = true;
            }
            s--;
            lbTimer.Text = strM +":" + strS;
        }
        private void tbMinutes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9') return;
            if (Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Enter) tbSecundes.Focus();
                return;

            }
            e.Handled = true;
        }
        private void tbSeconds_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9') return;
            if (Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Enter) btSetup.Focus();
                return;

            }
            e.Handled = true;
        }

        private void btSetup_Click(object sender, EventArgs e)
        {
            if (tbMinutes.Text == "Минуты" || tbMinutes.Text == "")
            {
                m = 0;
                strM = "0" + m;
            }
            else
            {
                try
                {
                    m = int.Parse(tbMinutes.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Неверный формат минут");
                }
                if (m < 10) strM = "0" + m;
                else strM = "" + m;
            }

            if (tbSecundes.Text == "Секунды" || tbSecundes.Text == "")
            {
                s = 0;
                strS = "0" + s;
            }
            else
            {
                try
                {
                    s = int.Parse(tbSecundes.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Неверный формат секунд");
                }
                if (s < 10) strM = "0" + s;
                else strS = "" + s;
            }
            check = true;

            if (m == 0 && s == 0) check = false;
            lbTimer.Text = $"{strM}:{strS}";
        }

        private void btStart_Click(object sender, EventArgs e)
        {

            if (timer1.Enabled == false)
            {
                timer1.Enabled = true;
                btStart.Text = "Пауза";
                btSetup.Enabled = false;
            }
            else
            {
                timer1.Enabled = false;
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
            timer1.Interval = 1000;
        }
    }
}