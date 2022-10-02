namespace Lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;  // ����� ����� �� ������ ������
            label7.Text = "";
            label8.Text = "";
            label11.Text = "";
            label12.Text = "";
            label17.Text = "";
            label18.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Complex c1 = new Complex(); // ������ �����
            Complex c2 = new Complex(); // ������ �����
            try
            {
                c1.r = Convert.ToDouble(textBox1.Text); // ����� ����� ������� �����
                c1.i = Convert.ToDouble(textBox2.Text); // ������ ����� ������� �����

                c2.r = Convert.ToDouble(textBox3.Text); // ����� ����� ������� �����
                c2.i = Convert.ToDouble(textBox4.Text); // ������ ����� ������� �����
            }
            catch (Exception ex)
            {
                MessageBox.Show("��������� ���������� �����.");
            }

            label7.Text = string.Format("{0} + {1}i", (c1 + c2).r, (c1 + c2).i); // ��������
            label8.Text = string.Format("{0} + {1}i", (c1 - c2).r, (c1 - c2).i); // ���������
            label11.Text = string.Format("{0} + {1}i", (c1 * c2).r, (c1 * c2).i); // ���������
            label12.Text = string.Format("{0} + {1}i", (c1 / c2).r, (c1 / c2).i); // �������


            if ((c1.r == c2.r) && (c1.i == c2.i))
            {
                label17.Text = Convert.ToString("��.");
            }
            else
            {
                label17.Text = Convert.ToString("���.");
            }
        }
    }
}