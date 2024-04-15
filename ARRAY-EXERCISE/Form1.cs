using System.Xml.Linq;

namespace ARRAY_EXERCISE
{
    public partial class Form1 : Form
    {


        string[] Names;
        int index;

        int[,] Grades;
        int rowindex;
        int columnindex;


        string[,,] Career;
        int index1;
        int index2;
        int index3;
        public Form1()
        {
            InitializeComponent();
            Names = new string[10];
            index = 0;

            Grades = new int[2, 5];
            rowindex = 0;
            columnindex = 0;

            Career = new string[2, 3, 2];
            index1 = 0;
            index2 = 0;
            index3 = 0;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSaveName_Click(object sender, EventArgs e)
        {
            string data = "";
            if (index == Names.Length)
            {
                for (int i = 0; i < Names.Length; i++)
                {
                    data += Names[i];
                }

                MessageBox.Show("Vector is full:" + data);
                Names = new string[10];
                index = 0;
                return;
            }


            try
            {
                Names[index++] = txtName.Text;
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Incorrect format, a string is required ");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " ");
            }
        }

        private void btnSaveGrades_Click(object sender, EventArgs e)
        {
            string data2 = "";
            if (rowindex == Grades.GetLength(0) && columnindex == Grades.GetLength(1))
            {
                for (int i = 0; i < Grades.GetLength(0); i++)
                {
                    for (int j = 0; j < Grades.GetLength(1); j++)
                    {
                        data2 += Grades[i, j];
                    }
                }


            }
            try
            {
                Grades[rowindex, columnindex++] = Int32.Parse(txtGrades.Text);
                if (columnindex == Grades.GetLength(1))
                {
                    rowindex++;
                    columnindex = 0;
                }
            }
            catch (System.IndexOutOfRangeException)
            {
                MessageBox.Show("Matrix is full:");
                Grades = new int[2, 5];
                rowindex = 0;
                columnindex = 0;
                return;
            }
            catch (FormatException exe)
            {
                MessageBox.Show("Incorrect format, an integer is required. ");
            }
            catch (Exception exe)
            {
                MessageBox.Show(exe.Message + " ");
            }
        }

        private void btnSaveCareer_Click(object sender, EventArgs e)
        {
            string data = "";
            if (index1 == Grades.GetLength(0) && index2 == Career.GetLength(1) && index3 == Career.GetLength(2))
            {
                for (int i = 0; i < Career.GetLength(0); i++)
                {
                    for (int j = 0; j < Career.GetLength(1); j++)
                    {
                        for (int k = 0; k < Career.GetLength(2); k++)
                        {
                            data += Career[i, j, k];
                        }
                    }
                }
            }

            try
            {
                Career[index1, index2, index3++] = txtCareer.Text;
                if (index3 == Career.GetLength(2))
                {
                    index2++;
                    index3 = 0;
                }
                if (index2 == Career.GetLength(1))
                {
                    index1++;
                    index2 = 0;
                    index3 = 0;
                }
            }

            catch (System.IndexOutOfRangeException)
            {
                MessageBox.Show("Array is full:");
                Career = new string[2, 3, 2];
                index2 = 0;
                index3 = 0;
                return;
            }
            catch (FormatException exe)
            {
                MessageBox.Show("Incorrect format, an integer is required. ");
            }
            catch (Exception exe)
            {
                MessageBox.Show(exe.Message + " ");
            }
        }

    }
}
