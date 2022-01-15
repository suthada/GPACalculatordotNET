namespace GPACalculator
{
    public partial class MainForm : Form
    {
        internal gpaCal gpaCal = new gpaCal();
        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            textNameMax.Clear();
            textNameMin.Clear();
            textScoreMax.Clear();
            textScoreMin.Clear();

            string name = textName.Text;
            double score = Convert.ToDouble(textScore.Text);
            gpaCal.getScore(name, score);
            
            string gpa = Convert.ToString(gpaCal.getGpa());
            textGPA.Text = gpa;

            string nameMax = gpaCal.getMaxName();
            string nameMin = gpaCal.getMinName();
            string scoreMax = Convert.ToString(gpaCal.getMaxScore());
            string scoreMin = Convert.ToString(gpaCal.getMinScore());

            textNameMax.Text = nameMax;
            textNameMin.Text = nameMin;
            textScoreMax.Text = scoreMax;
            textScoreMin.Text = scoreMin;

            string showSC = name + " " + score + "\r\n";
            textShowscore.AppendText(showSC);
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textShowscore.Clear();
        }
    }
}