using static System.Net.Mime.MediaTypeNames;

namespace CatchButton
{
    public partial class Form1 : Form
    {
        int score = 0;
        Random rd = new Random();
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
            int maxX = rd.Next(0, this.ClientSize.Width - mybutton.Width);
            int maxY = rd.Next(0, this.ClientSize.Height - mybutton.Height);

            int nextX = rd.Next(0, maxX);
            int nextY = rd.Next(0, maxY);

            mybutton.Location = new Point(nextX, nextY);

            score -= 10;

            this.Text = $"점수: {score} | 버튼 위치: ({nextX}, {nextY})";
        }

        private void mybutton_MouseClick(object sender, MouseEventArgs e)
        {
            int btnX = mybutton.Location.X;
            int btnY = mybutton.Location.Y;

            MessageBox.Show("축하합니다~!");

            score += 100;

            this.Text = $"점수: {score} | 버튼 위치: ({btnX}, {btnY})";

            mybutton.Width = (int)(mybutton.Width * 0.95);
            mybutton.Height = (int)(mybutton.Height * 0.95);
            ;

        }
    }
}
