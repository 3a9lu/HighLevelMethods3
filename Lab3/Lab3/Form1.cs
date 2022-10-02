namespace Lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;  // Вывод формы по центру экрана
            Clear();
        }

        public void Clear()
        {
            label7.Text = "";
            label8.Text = "";
            label11.Text = "";
            label12.Text = "";
            label17.Text = "";
            label18.Text = "";
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            int length = textBox1.Text.Length;
            if (length == 0 && ch == ',' && ch == '-')  // Исключаем запятую в начале и минус
            {
                e.Handled = true;
            }
            if (!Char.IsDigit(ch) && ch != 8 && (ch != ',' || textBox1.Text.Contains(",")) && ((ch != '-' || textBox1.Text.Contains("-")))) // Если число, BACKSPACE запятая или минус, то вводим
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            int length = textBox2.Text.Length;
            if (length == 0 && ch == ',' && ch == '-')  // Исключаем запятую в начале и минус
            {
                e.Handled = true;
            }
            if (!Char.IsDigit(ch) && ch != 8 && (ch != ',' || textBox2.Text.Contains(",")) && ((ch != '-' || textBox2.Text.Contains("-")))) // Если число, BACKSPACE запятая или минус, то вводим
            {
                e.Handled = true;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            int length = textBox3.Text.Length;
            if (length == 0 && ch == ',' && ch == '-')  // Исключаем запятую в начале и минус
            {
                e.Handled = true;
            }
            if (!Char.IsDigit(ch) && ch != 8 && (ch != ',' || textBox3.Text.Contains(",")) && ((ch != '-' || textBox3.Text.Contains("-")))) // Если число, BACKSPACE запятая или минус, то вводим
            {
                e.Handled = true;
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            int length = textBox4.Text.Length;
            if (length == 0 && ch == ',' && ch == '-')  // Исключаем запятую в начале и минус
            {
                e.Handled = true;
            }
            if (!Char.IsDigit(ch) && ch != 8 && (ch != ',' || textBox4.Text.Contains(",")) && ((ch != '-' || textBox4.Text.Contains("-")))) // Если число, BACKSPACE запятая или минус, то вводим
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Clear();
                Complex number1 = new Complex(); // Первое число
                Complex bumber2 = new Complex(); // Второе число

                if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")
                {
                    MessageBox.Show("Заполните все поля!", "Ошибка");
                    return;
                }

                try
                {
                    number1.r = Convert.ToDouble(textBox1.Text); // Целая часть первого числа
                    number1.i = Convert.ToDouble(textBox2.Text); // Мнимая часть первого числа

                    bumber2.r = Convert.ToDouble(textBox3.Text); // Целая часть второго числа
                    bumber2.i = Convert.ToDouble(textBox4.Text); // Мнимая часть второго числа
                }
                catch
                {
                    MessageBox.Show("Введите правильно числа во все поля!", "Ошибка");
                    return;
                }

                try
                {
                    label7.Text = string.Format("{0} + {1}i", (number1 + bumber2).r, (number1 + bumber2).i); // Сложение
                    label8.Text = string.Format("{0} + {1}i", (number1 - bumber2).r, (number1 - bumber2).i); // Вычитание
                    label11.Text = string.Format("{0} + {1}i", (number1 * bumber2).r, (number1 * bumber2).i); // Умножение
                    label12.Text = string.Format("{0} + {1}i", (number1 / bumber2).r, (number1 / bumber2).i); // Деление


                    if ((number1 == bumber2) && (number1 == bumber2))
                    {
                        label17.Text = Convert.ToString("Да.");
                    }
                    else
                    {
                        label17.Text = Convert.ToString("Нет.");
                    }

                    if ((number1 != bumber2) && (number1 != bumber2))
                    {
                        label18.Text = Convert.ToString("Да.");
                    }
                    else
                    {
                        label18.Text = Convert.ToString("Нет.");
                    }
                }
                catch
                {
                    MessageBox.Show("Проблема с какой-то операцией!", "Ошибка");
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }
    }
}