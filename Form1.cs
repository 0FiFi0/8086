namespace Projekt8086
{
    public partial class Form1 : Form
    {
        static Form1 _obj;
        public static Form1 Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new Form1();

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

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

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

        private void XCHG_btn_Click(object sender, EventArgs e)
        {
            moV1.Hide();
            xchG1.Show();
        }

        private void xchGwind1_Load(object sender, EventArgs e)
        {

        }
    }
}