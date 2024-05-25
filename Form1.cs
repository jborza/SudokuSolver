namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private Grid grid;

        public Form1()
        {
            InitializeComponent();
            initialize();
        }

        private void initialize()
        {
            string numbers = textBox1.Text;
            int[,] sudoku = new int[9, 9]
        {
            {0,4,9,0,0,0,0,3,0 },
            {0,5,0,6,1,0,0,0,0 },
            {0,0,8,0,2,9,5,0,6 },
            {8,0,0,9,0,7,0,0,4 },
            {7,0,0,0,0,0,0,8,1 },
            {0,2,5,0,4,1,3,0,0 },
            {2,0,0,0,7,6,0,1,0 },
            {5,0,0,4,0,8,7,0,0 },
            {0,8,7,0,0,0,0,9,5 }
        };
            grid = new Grid(sudoku);
            pictureBox1.Image = grid.Draw();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            grid.AutoFill();
            pictureBox1.Image = grid.Draw();
        }
    }
}