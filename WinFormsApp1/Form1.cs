namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public static LinkedList<Button> _lista = new LinkedList<Button>();
        public static int j = 0;
        int k = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (_lista.Count() > 0)
            {
                _lista.Remove(_lista.ElementAt(0));
                panelCalc.Controls.RemoveAt(0);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (j == 0)
            {
                for (int i = 0; i < 10; i++)
                {

                    var b = new Button();
                    b.Text = i.ToString();

                    b.Location = new Point(i * 75, 0);
                    panelCalc.Controls.Add(b);

                    _lista.AddLast(b);

                }
                j++;

            }
            else if (j == 1)
            {

                for (int i = 0; i < 10; i++)
                {

                    var b = new Button();
                    b.Text = i.ToString();

                    b.Location = new Point(i * 75, 20);
                    panelCalc.Controls.Add(b);

                    _lista.AddLast(b);

                }
                j++;
            }
            else if (j == 2)
            {
                for (int i = 0; i < 10; i++)
                {

                    var b = new Button();
                    b.Text = i.ToString();

                    b.Location = new Point(i * 75, 40);
                    panelCalc.Controls.Add(b);

                    _lista.AddLast(b);

                }
                j++;
            }
            else if (j == 3)
            {
                for (int i = 0; i < 10; i++)
                {

                    var b = new Button();
                    b.Text = i.ToString();

                    b.Location = new Point(i * 75, 60);
                    panelCalc.Controls.Add(b);

                    _lista.AddLast(b);

                }
            }




        }
        
    }
}