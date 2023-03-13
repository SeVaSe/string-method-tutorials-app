using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace pr3_string
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        //выход
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult Result = MessageBox.Show("Вы точно хотите выйти ?", "Выход" ,MessageBoxButton.YesNo);
            if (Result == MessageBoxResult.Yes)
            {
                Close();
            }
            else { }
        }

        //contains
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string str1, str2;
            int count = 0;

            str1 = TxtBox1_Contains.Text;
            str2 = TxtBox2_Contains.Text;
            

            string[] TextMass = str1.Split(' '); 

            foreach (string s in TextMass)
            {
                if (s.Contains(str2))
                {
                    count++;
                }
            }

            if (count != 0) 
            {
                TxtBl_otvet.Text = $"В исходном тексте, строка ({str2}) присутствует {count} раз";
            }
            else
            {
                TxtBl_otvet.Text = "Такой строки в тексте не обнаружено";
            }
        }

        //concat
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            string str1 = TxtBox1_Concat.Text;
            string str2 = TxtBox2_Concat.Text;

            TxtBl_otvet2.Text = string.Concat(str1, str2);
        }

        //endwith
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            string str1 = TxtBox1_EndWith.Text;
            string str2 = TxtBox2_EndWith.Text;

            if (str1.EndsWith(str2))
            {
                TxtBl_otvet3.Text = $"Строка ({str1}) заканчивается на вторую введенную строку ({str2})";
            }
            else
            {
                TxtBl_otvet3.Text = $"Строка ({str1}) не заканчивается на вторую введенную строку ({str2})";
            }
        }

        //indexOf
        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            string str1 = TxtBox1_Index.Text;  
            string str2 = TxtBox2_Index.Text;
            int indOf = str1.IndexOf(str2);
            if (indOf != -1)
            {
                TxtBl_otvet4.Text = $"Найден индекс символа или подстроки первого вхождения: {indOf}";
            }
            else
            {
                TxtBl_otvet4.Text = $"Символ или подстрока не найдены";
            }

        }

        //lastindexOf
        private void Button_Click_4_4(object sender, RoutedEventArgs e)
        {
            string str1 = TxtBox1_Index.Text;
            string str2 = TxtBox2_Index.Text;
            int indLastOf = str1.LastIndexOf(str2);

            if (indLastOf != -1) 
            {
                TxtBl_otvet4.Text = $"Найден индекс символа или подстроки последнего вхождения: {indLastOf}";
            }
            else
            {
                TxtBl_otvet4.Text = $"Символ или подстрока не найдены";
            }
        }

        //insert
        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            try
            {
                string str1 = TxtBox1_Insert.Text;
                string str2 = TxtBox2_Insert.Text;
                int ind = int.Parse(TxtBox3_Insert.Text);

                TxtBl_otvet5.Text = str1.Insert(ind, str2);
            }
            catch (Exception)
            {
                if (TxtBox1_Insert.Text == "" || TxtBox2_Insert.Text == "" || TxtBox3_Insert.Text == "")
                {
                    MessageBox.Show("Одно из полей пусто, заполните все значения", "Ошибка пустого значения");
                }
                else
                {
                    MessageBox.Show("Не правильно заполненное поле", "Ошибка не првильного значения");
                }
            }
        }

        //join
        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            string str1 = TxtBox1_Join.Text;
            string str2 = TxtBox2_Join.Text;
            string[] str1Mass = str1.Split(' ');

            TxtBl_otvet6.Text = string.Join(str2, str1Mass);
        }

        //replace
        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            try
            {
                string str1 = TxtBox1_Replace.Text;
                string str2FoundWord = TxtBox2_Replace.Text;
                string str3NewWord = TxtBox3_Replace.Text;

                TxtBl_otvet7.Text = str1.Replace(str2FoundWord, str3NewWord);
            }
            catch (Exception)
            {
                if (TxtBox1_Replace.Text == "" || TxtBox2_Replace.Text == "" || TxtBox3_Replace.Text == "")
                {
                    MessageBox.Show("Одно из полей пусто, заполните все значения", "Ошибка пустого значения");
                }
                else
                {
                    MessageBox.Show("Не правильно заполненное поле", "Ошибка не првильного значения");
                }
            }
        }

        //split
        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            try
            {
                string str1 = TxtBox1_Split.Text;
                char str2 = Convert.ToChar(TxtBox2_Split.Text);
                char[] del = { str2 };

                string[] words = str1.Split(del);

                foreach (string c in words)
                {
                    TxtBl_otvet8.Text += $"\n{c}";
                }
            }
            catch (Exception)
            {
                if (TxtBox1_Split.Text == "" || TxtBox2_Split.Text == "")
                {
                    MessageBox.Show("Одно из полей пусто, заполните все значения", "Ошибка пустого значения");
                }
                else
                {
                    MessageBox.Show("Не правильно заполненное поле", "Ошибка не првильного значения");
                }
            }
        }

        //substring
        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            try
            {
                string str1 = TxtBox1_Subs.Text;
                int ind = int.Parse(TxtBox2_Subs.Text);
                int indCount = int.Parse(TxtBox3_Subs.Text);

                TxtBl_otvet9.Text = str1.Substring(ind, indCount);
            }
            catch (Exception)
            {
                if (TxtBox1_Subs.Text == "" || TxtBox2_Subs.Text == "" || TxtBox3_Subs.Text == "")
                {
                    MessageBox.Show("Одно из полей пусто, заполните все значения", "Ошибка пустого значения");
                }
                else
                {
                    MessageBox.Show("Не правильно заполненное поле", "Ошибка не првильного значения");
                }
            }
        }

        //ToUpper/ToLower
        //Lower
        private void Button_Click_10_1(object sender, RoutedEventArgs e)
        {
            string str1 = TxtBox1_ToUpLow.Text;
            TxtBl_otvet10.Text = str1.ToLower();
        }
        //Upper
        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            string str1 = TxtBox1_ToUpLow.Text;
            TxtBl_otvet10.Text = str1.ToUpper();
        }

        //Trim
        //all
        private void Button_Click_11(object sender, RoutedEventArgs e)
        {
            try
            {
                string str1 = TxtBox1_Trim.Text;
                char ch = Char.Parse(TxtBox2_Trim.Text);

                TxtBl_otvet11.Text = str1.Trim(ch);
            }
            catch (Exception)
            {
                if (TxtBox1_Trim.Text == "" || TxtBox2_Trim.Text == "")
                {
                    MessageBox.Show("Одно из полей пусто, заполните все значения", "Ошибка пустого значения");
                }
                else
                {
                    MessageBox.Show("Не правильно заполненное поле", "Ошибка не првильного значения");
                }
            }
        }
        //start
        private void Button_Click_11_1(object sender, RoutedEventArgs e)
        {
            try
            {
                string str1 = TxtBox1_Trim.Text;
                char ch = Char.Parse(TxtBox2_Trim.Text);

                TxtBl_otvet11.Text = str1.TrimStart(ch);
            }
            catch (Exception)
            {
                if (TxtBox1_Trim.Text == "" || TxtBox2_Trim.Text == "")
                {
                    MessageBox.Show("Одно из полей пусто, заполните все значения", "Ошибка пустого значения");
                }
                else
                {
                    MessageBox.Show("Не правильно заполненное поле", "Ошибка не првильного значения");
                }
            }
        }
        //end
        private void Button_Click_11_2(object sender, RoutedEventArgs e)
        {
            try
            {
                string str1 = TxtBox1_Trim.Text;
                char ch = Char.Parse(TxtBox2_Trim.Text);

                TxtBl_otvet11.Text = str1.TrimEnd(ch);
            }
            catch (Exception)
            {
                if (TxtBox1_Trim.Text == "" || TxtBox2_Trim.Text == "")
                {
                    MessageBox.Show("Одно из полей пусто, заполните все значения", "Ошибка пустого значения");
                }
                else
                {
                    MessageBox.Show("Не правильно заполненное поле", "Ошибка не првильного значения");
                }
            }
        }
    }
}
