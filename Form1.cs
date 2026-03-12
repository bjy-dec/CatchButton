namespace CatchButton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void mybutton_MouseEnter(object sender, EventArgs e)
        {
            Random rd = new Random();

            int maxX = rd.Next(0, this.ClientSize.Width - mybutton.Width);
            int maxY = rd.Next(0, this.ClientSize.Height - mybutton.Height);

            int nextX = rd.Next(0, maxX);
            int nextY = rd.Next(0, maxY);

            mybutton.Location = new Point(nextX, nextY);

            this.Text = $"버튼 위치: ({nextX}, {nextY})";
        }
    }
}
