using System.Dynamic;
using static System.Net.Mime.MediaTypeNames;
using System.Runtime.InteropServices;
using System.Configuration;
using System;


namespace OOP_Kurbala205TN_CW
{

    // Клас для головної форми програми, та для роботи з текстовим файлом
    public partial class MainForm : Form
    {
        private
        string path = "D:\\Study\\ООП\\Курсова\\Текст.txt";
        string savepath = "D:\\Study\\ООП\\Курсова\\Сортований Текст.txt";
        int PageNumber = 0;
        int lines = 10;
        int columns = 3;
        string[] Pages = new string[255];

        [DllImport("kernel32.dll")]
        static extern bool AllocConsole();
        public string getPath()
        {
            return path;
        }
        public string getSavePath()
        {
            return savepath;
        }
        public int getLines()
        {
            return lines;
        }
        public int getColumns()
        {
            return columns;
        }
        public void setparameters(int lines, int columns, string path, string savepath)
        {
            this.lines = lines;
            this.columns = columns;
            this.path = path;
            this.savepath = savepath;
            Pages = Readfile();
            TextBox.Text = Read(PageNumber);


        }
        public MainForm()
        {

            InitializeComponent();
            MessageBox.Show("У налаштуваннях введіть шлях до Файлу.");
            SettingForm settingForm = new SettingForm(this);
            settingForm.Show();
            settingForm.SetDesktopLocation(1000,600);
            

        }
        private string Read(int pageNumber)
        {
            try
            {
                return Pages[pageNumber];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не вдалося зчитати текст. Налаштуйте шлях до файлу.");
                return "";
            }
        }
        private string[] Readfile()
        {

            try
            {

                int go = 0;
                bool ended = false;
                int s = 0;
                int l = 0;
                int i = 0;
                int p = 0;


                string[] page = new string[100];
                string readedtext = File.ReadAllText(path);
                string[] words = readedtext.Split(new[] { ' ', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
                string[] spesial = readedtext.Split(new[] { '{' }, StringSplitOptions.RemoveEmptyEntries);
                string[] term = new string[spesial.Length];
                string[] oneterm = new string[spesial.Length];
                while (go < spesial.Length)
                {
                    if (spesial[go].IndexOf('}') == -1) { go++; continue; }
                    term[go] = spesial[go].Substring(0, spesial[go].IndexOf('}')) + " - ";
                    go++;
                }

                go = 0;
                i = 0;

                oneterm[0] = term[0];
                while (go < term.Length)
                {
                    if (oneterm.Contains(term[go]))
                    {
                        go++;
                        continue;
                    }
                    oneterm[i] = term[go];
                    i++;
                    go++;
                }
                Console.WriteLine(words[3]);
                Console.WriteLine(oneterm[0].Substring(0, oneterm[0].IndexOf(' ')));
                Console.WriteLine(words[3].Contains(oneterm[0].Substring(0, oneterm[0].IndexOf(' '))));

                while (!ended)
                {


                    while (p < lines)
                    {
                        if (i >= words.Length)
                        {
                            ended = true;
                            break;
                        }
                        if (words[i].Contains('{') || words[i].Contains('}'))
                        {
                            for (int num = 0; num < oneterm.Length; num++)
                            {
                                if (oneterm[num] == null)
                                {
                                    break;
                                }
                                if (words[i].Contains(oneterm[num].Substring(0, oneterm[num].IndexOf(' '))))
                                {
                                    oneterm[num] += s + 1 + ", ";
                                    break;
                                }

                            }
                            i++;
                            continue;
                        }

                        page[s] += words[i] + " ";
                        l++;
                        i++;
                        if (l == columns)
                        {
                            page[s] += Environment.NewLine;
                            l = 0;
                            p++;
                        }
                    }
                    s++;
                    p = 0;
                }
                foreach (string str in oneterm)
                {

                    page[s] += str + Environment.NewLine;
                }

                return page;
            }

            catch (Exception ex)
            {
                
                return new string[0];
            }

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void NextPage_Click(object sender, EventArgs e)
        {   
            if (Pages[PageNumber + 1] == null)
            {
                return;
            }
            PageNumber++;
            TextBox.Text = string.Empty;
            TextBox.Text = Read(PageNumber);
            Page.Text = "Сторінка " + (PageNumber + 1).ToString();


        }

        private void PreviousPage_Click(object sender, EventArgs e)
        {
            if (PageNumber <= 0)
            {
                return;
            }
            PageNumber--;
            TextBox.Text = string.Empty;
            TextBox.Text = Read(PageNumber);
            Page.Text = "Сторінка " + (PageNumber + 1).ToString();

        }

        private void SettingButton_Click(object sender, EventArgs e)
        {
            SettingForm settingForm = new SettingForm(this);
            settingForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {   File.WriteAllText(savepath, string.Empty); 
            for (int i = 0; i < Pages.Length; i++)
            {
                if (Pages[i] == null) { break; }
                File.AppendAllText(savepath, "\nСторінка: " + (i + 1)+" - \n");
                File.AppendAllText(savepath, Pages[i]);
            }
        }
    }
}
