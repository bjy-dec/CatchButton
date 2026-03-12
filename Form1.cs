using static System.Net.Mime.MediaTypeNames;

namespace CatchButton
{
    public partial class Form1 : Form
    {
        int score = 0;
        int miss = 0;
        const int MAX_MISS = 20;
        Random rd = new Random();

        int initialButtonWidth;
        int initialButtonHeight;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            initialButtonWidth = mybutton.Width;
            initialButtonHeight = mybutton.Height;
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
            miss++;

            this.Text = $"점수: {score} | 버튼 위치: ({nextX}, {nextY})";

            if (miss >= MAX_MISS)
            {
                MessageBox.Show("Game Over");
                mybutton.Enabled = false;
            }
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

        private void rebutton_Click(object sender, EventArgs e)
        {

        }

        private void rebutton_MouseClick(object sender, MouseEventArgs e)
        {
            score = 0;
            miss = 0;

            mybutton.Enabled = true;
            

            mybutton.Width = initialButtonWidth;
            mybutton.Height = initialButtonHeight;

            int centerX = (this.ClientSize.Width - mybutton.Width) / 2;
            int centerY = (this.ClientSize.Height - mybutton.Height) / 2;
            mybutton.Location = new Point(centerX, centerY);

            this.Text = $"점수: {score} | 버튼 위치: ({mybutton.Location.X}, {mybutton.Location.Y}) | 놓친 횟수: {miss}";
        }
    }
}
