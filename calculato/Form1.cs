using System.Numerics;

namespace calculato
{

    public partial class Form1 : Form
    {
        decimal var = 0;
        decimal output = 0;
        decimal Ans = 0;
        List<char> actions = new List<char>();
        Queue<decimal> variables = new Queue<decimal>();
        List<char> display = new List<char>();
        string show;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            display.Add('1');
            show = string.Join("", display);
            textBox1.Text = show;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            display.Add('2');
            show = string.Join("", display);
            textBox1.Text = show;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            display.Add('3');
            show = string.Join("", display);
            textBox1.Text = show;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            display.Add('4');
            show = string.Join("", display);
            textBox1.Text = show;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            display.Add('5');
            show = string.Join("", display);
            textBox1.Text = show;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            display.Add('6');
            show = string.Join("", display);
            textBox1.Text = show;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            display.Add('7');
            show = string.Join("", display);
            textBox1.Text = show;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            display.Add('8');
            show = string.Join("", display);
            textBox1.Text = show;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            display.Add('9');
            show = string.Join("", display);
            textBox1.Text = show;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            display.Add('0');
            show = string.Join("", display);
            textBox1.Text = show;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
        }

        private void button19_Click(object sender, EventArgs e)
        {
            display.Add('+');
            show = string.Join("", display);
            textBox1.Text = show;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            display.Add('-');
            show = string.Join("", display);
            textBox1.Text = show;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            int digit = 0;
            var = 0;
            for (int i = 0; i < display.Count; i++)
            {

                switch (display[i])
                {
                    case '+':
                        actions.Add('+');
                        variables.Enqueue(var);
                        var = 0;
                        digit = 0;
                        break;
                    case '-':
                        actions.Add('-');
                        variables.Enqueue(var);
                        var = 0;
                        digit = 0;
                        break;
                    case 'x':
                        actions.Add('x');
                        variables.Enqueue(var);
                        var = 0;
                        digit = 0;
                        break;
                    case '÷':
                        actions.Add('÷');
                        variables.Enqueue(var);
                        var = 0;
                        digit = 0;
                        break;
                    case '^':
                        actions.Add('^');
                        variables.Enqueue(var);
                        var = 0;
                        digit = 0;
                        break;
                    case '(':
                        var = 0;
                        break;
                    case '.':
                        actions.Add('.');
                        variables.Enqueue(var);
                        var = 0;
                        digit = 0;
                        break;
                    default:
                        for (int j = 0; j < digit; j++)
                        {
                            var *= 10;
                        }
                        var += display[i] - 48;
                        digit++;
                        break;
                }
            }
            variables.Enqueue(var);
            var = variables.Dequeue();
            if (actions.Count > 0)
            {
                for (int i = 0; i < actions.Count; i++)
                {
                    switch (actions[i])
                    {
                        case '+':
                            var += variables.Dequeue();
                            break;
                        case '-':
                            var -= variables.Dequeue();
                            break;
                        case 'x':
                            var *= variables.Dequeue();
                            break;
                        case '÷':
                            var /= variables.Dequeue();
                            break;
                        case '.':
                            string temp = variables.Dequeue().ToString();
                            decimal frac = (decimal)0.1;
                            for (int j = 0; j < temp.Length; j++)
                            {
                                var += (temp[j] - 48) * frac;
                                frac /= 10;
                            }
                            break;
                        case '^':
                            int power = (int)variables.Dequeue();
                            decimal pownum = var;
                            for (int j = 1; j < power; j++)
                            {
                                var *= pownum;
                            }
                            break;
                        case '(':
                            var = 0;
                            break;
                        default:
                            break;
                    }
                }
            }
            output = var;
            Ans = output;
            textBox2.Text = output.ToString();
            variables.Clear();
            actions.Clear();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            display.Add('÷');
            show = string.Join("", display);
            textBox1.Text = show;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            display.Add('x');
            show = string.Join("", display);
            textBox1.Text = show;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (display.Count > 0)
            {
                display.RemoveAt((display.Count - 1));
            }
            show = string.Join("", display);
            textBox1.Text = show;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            display.Add('.');
            show = string.Join("", display);
            textBox1.Text = show;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            display.Add('^');
            show = string.Join("", display);
            textBox1.Text = show;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            display.Clear();
            show = string.Join("", display);
            textBox1.Text = show;
            textBox2.Text = show;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            display.Clear();
            string again = Ans.ToString();
            for(int i =0;i<again.Length;i++) 
            {
                display.Add(again[i]);
            }
            show = string.Join("", display);
            textBox1.Text = show;
            textBox2.Text = show;
        }
    }
    class Action
    {
        public int Num;
        public char Thisis;
        public Action(int num, char thisis = '0')
        {
            Num = num;
            Thisis = thisis;
        }

    }
}
