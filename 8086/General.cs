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


        private void General_Load(object sender, EventArgs e)
        {

            _obj = this;

            moV1.Hide();
            xchG1.Hide();
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
    }
}