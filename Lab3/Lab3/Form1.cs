namespace Lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;  // Вывод формы по центру экрана
            label7.Text = "";
            label8.Text = "";
            label11.Text = "";
            label12.Text = "";
            label17.Text = "";
            label18.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Complex c1 = new Complex(); // Первое число
            Complex c2 = new Complex(); // Второе число
            try
            {
                c1.r = Convert.ToDouble(textBox1.Text); // Целая часть первого числа
                c1.i = Convert.ToDouble(textBox2.Text); // Мнимая часть первого числа

                c2.r = Convert.ToDouble(textBox3.Text); // Целая часть второго числа
                c2.i = Convert.ToDouble(textBox4.Text); // Мнимая часть второго числа
            }
            catch (Exception ex)
            {
                MessageBox.Show("Проверьте введённость чисел.");
            }

            label7.Text = string.Format("{0} + {1}i", (c1 + c2).r, (c1 + c2).i); // Сложение
            label8.Text = string.Format("{0} + {1}i", (c1 - c2).r, (c1 - c2).i); // Вычитание
            label11.Text = string.Format("{0} + {1}i", (c1 * c2).r, (c1 * c2).i); // Умножение
            label12.Text = string.Format("{0} + {1}i", (c1 / c2).r, (c1 / c2).i); // Деление


            if ((c1.r == c2.r) && (c1.i == c2.i))
            {
                label17.Text = Convert.ToString("Да.");
            }
            else
            {
                label17.Text = Convert.ToString("Нет.");
            }
        }
    }
}