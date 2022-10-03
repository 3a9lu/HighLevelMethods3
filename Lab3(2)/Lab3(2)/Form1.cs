namespace Lab3_2_
{
    public partial class Form1 : Form
    {
        private int numerator1;
        private int denominator1;
        private int numerator2;
        private int denominator2;
        public Form1()
        {
            InitializeComponent(); 
            StartPosition = FormStartPosition.CenterScreen;  // ����� ����� �� ������ ������
            Clear();
        }

        public void Clear()
        {
            label7.Text = "";
            label8.Text = "";
            label9.Text = "";
            label10.Text = "";
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            int length = textBox1.Text.Length;
            if (length == 0 && ch == ',' && ch == '-')  // ��������� ������� � ������ � �����
            {
                e.Handled = true;
            }
            if (!Char.IsDigit(ch) && ch != 8 && (ch != ',' || textBox1.Text.Contains(",")) && ((ch != '-' || textBox1.Text.Contains("-")))) // ���� �����, BACKSPACE ������� ��� �����, �� ������
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            int length = textBox2.Text.Length;
            if (length == 0 && ch == ',' && ch == '-')  // ��������� ������� � ������ � �����
            {
                e.Handled = true;
            }
            if (!Char.IsDigit(ch) && ch != 8 && (ch != ',' || textBox2.Text.Contains(",")) && ((ch != '-' || textBox2.Text.Contains("-")))) // ���� �����, BACKSPACE ������� ��� �����, �� ������
            {
                e.Handled = true;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            int length = textBox3.Text.Length;
            if (length == 0 && ch == ',' && ch == '-')  // ��������� ������� � ������ � �����
            {
                e.Handled = true;
            }
            if (!Char.IsDigit(ch) && ch != 8 && (ch != ',' || textBox3.Text.Contains(",")) && ((ch != '-' || textBox3.Text.Contains("-")))) // ���� �����, BACKSPACE ������� ��� �����, �� ������
            {
                e.Handled = true;
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            int length = textBox4.Text.Length;
            if (length == 0 && ch == ',' && ch == '-')  // ��������� ������� � ������ � �����
            {
                e.Handled = true;
            }
            if (!Char.IsDigit(ch) && ch != 8 && (ch != ',' || textBox4.Text.Contains(",")) && ((ch != '-' || textBox4.Text.Contains("-")))) // ���� �����, BACKSPACE ������� ��� �����, �� ������
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Clear();

                try
                {
                    numerator1 = Convert.ToInt32(textBox1.Text);
                    denominator1 = Convert.ToInt32(textBox2.Text);

                    numerator2 = Convert.ToInt32(textBox3.Text);
                    denominator2 = Convert.ToInt32(textBox4.Text);
                }

                catch
                {
                    MessageBox.Show("������� ��������� ����� �� ��� ����!", "������");
                    return;
                }

                try
                {
                    Fraction a = new Fraction(numerator1, denominator1); // �������� ������� (������ �����) ������ Fraction
                    Fraction b = new Fraction(numerator2, denominator2); // �������� ������� (������ �����) ������ Fraction
                    label7.Text = (a + b).ToString();
                    label8.Text = (a - b).ToString();
                    label9.Text = (a * b).ToString();
                    label10.Text = (a / b).ToString();


                    if (a == b)
                    {
                        label13.Text = Convert.ToString("��.");
                    }
                    else
                    {
                        label13.Text = Convert.ToString("���.");
                    }

                    if (a != b)
                    {
                        label14.Text = Convert.ToString("��.");
                    }
                    else
                    {
                        label14.Text = Convert.ToString("���.");
                    }
                }

                catch
                {
                    MessageBox.Show("�������� � �����-�� ���������!", "������");
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