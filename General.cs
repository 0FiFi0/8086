namespace Procesor8086
{
    public partial class General : Form
    {
        static General _obj;
        public static General Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new General();

                }
                return _obj;
            }
        }
        public Panel PnlContainer
        {
            get { return panel1; }
            set { panel1 = value; }
        }

        public Button MOV_Button
        {
            get { return MOV_btn; }
            set { MOV_btn = value; }
        }

        public General()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            _obj = this;

            moV1.Hide();
            xchG1.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void MOV_Click(object sender, EventArgs e)
        {
            xchG1.Hide();
            moV1.Show();
        }

        private void XCHG_btn_Click(object sender, EventArgs e)
        {
            moV1.Hide();
            xchG1.Show();
        }

        private void xchGwind1_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}