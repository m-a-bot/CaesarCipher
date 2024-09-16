using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
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

namespace CaesarCipher
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    partial class MainWindow : Window
    {
        TypeAlphabet currentAlphabet;

        string rusAlphabet = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";

        string engAlphabet = "abcdefghijklmnopqrstuvwxyz";

        public MainWindow()
        {
            InitializeComponent();
        }

        private void cmboxAlphabet_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //changeAlphabet(cmboxAlphabet.SelectedIndex);
        }

        void changeAlphabet(int index)
        {
            string alphabet = "";

            if (index == 0)
            {
                currentAlphabet = TypeAlphabet.Rus;
                alphabet = rusAlphabet;
            }
            else if (index == 1)
            {
                currentAlphabet = TypeAlphabet.Eng;
                alphabet = engAlphabet;
            }
            _CaesarCipher.Alphabet = alphabet;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            changeAlphabet(cmboxAlphabet.SelectedIndex);
            string source = SourceText.Text;

            BigInteger key = BigInteger.Zero;

            try
            {
                key = BigInteger.Parse(EncryptionKey.Text);
            } catch 
            {
                MessageBox.Show("Неправильный ключ");
                return;
            }

            if (source == "")
            {
                MessageBox.Show("Введите текст!");
                return;
            }

            foreach (char c in source)
            {
                if (currentAlphabet == TypeAlphabet.Rus && engAlphabet.IndexOf(c) != -1)
                {
                    MessageBox.Show("Вводите текст только на русском языке");
                    return;
                }
                if (currentAlphabet == TypeAlphabet.Eng && rusAlphabet.IndexOf(c) != -1)
                {
                    MessageBox.Show("Вводите текст только на английском языке");
                    return;
                }
            }


            EncryptedText.Text = _CaesarCipher.Encrypt(source, key);

            
        }

        private void cmboxAlphabet1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //changeAlphabet(cmboxAlphabet1.SelectedIndex);

            //HackCaesarCipher.TypeAlphabet = currentAlphabet;

            //HackCaesarCipher.Alphabet = _CaesarCipher.Alphabet;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog= new OpenFileDialog();

            bool? openFile = openFileDialog.ShowDialog();

            if (openFile.Equals(true))
            {
                SourceText1.Text = File.ReadAllText(openFileDialog.FileName);
                MessageBox.Show("Текст загружен из файла");
            }
        }

        private void EncryptBtn_Click(object sender, RoutedEventArgs e)
        {

            changeAlphabet(cmboxAlphabet1.SelectedIndex);

            HackCaesarCipher.TypeAlphabet = currentAlphabet;

            HackCaesarCipher.Alphabet = _CaesarCipher.Alphabet;

            string source = SourceText1.Text;

            BigInteger key = BigInteger.Zero;

            try
            {
                key = BigInteger.Parse(EncryptionKey1.Text);
            }
            catch
            {
                MessageBox.Show("Неправильный ключ");
                return;
            }

            if (source == "")
            {
                MessageBox.Show("Введите текст!");
                return;
            }

            foreach (char c in source)
            {
                if (currentAlphabet == TypeAlphabet.Rus && engAlphabet.IndexOf(c) != -1)
                {
                    MessageBox.Show("Вводите текст только на русском языке");
                    return;
                }
                if (currentAlphabet == TypeAlphabet.Eng && rusAlphabet.IndexOf(c) != -1)
                {
                    MessageBox.Show("Вводите текст только на английском языке");
                    return;
                }
            }


            EncryptedText1.Text = _CaesarCipher.Encrypt(source, key);
        }

        private void HackBtn_Click(object sender, RoutedEventArgs e)
        {
            SelectedKey.Text = "";
            string encryptedText = EncryptedText1.Text;

            if (encryptedText == "")
            {
                MessageBox.Show("Нет текста!");
                return;
            }

            int key = HackCaesarCipher.Hack(encryptedText);

            MessageBox.Show("Подобран ключ");

            SelectedKey.Text = key.ToString();

            HackedText.Text = _CaesarCipher.Decrypt(encryptedText, key);
        }

        private void BtnOfSaveToFileEncryptedText_Click(object sender, RoutedEventArgs e)
        {
            string encryptedText = EncryptedText1.Text;

            if (encryptedText == "")
            {
                MessageBox.Show("Нет текста!");
                return;
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog();

            bool? saveFile = saveFileDialog.ShowDialog();

            if (saveFile.Equals(true))
            {
                File.WriteAllText(saveFileDialog.FileName, encryptedText);
                MessageBox.Show("Текст сохранен в файл");
            }
        }

        private void BtnOfSaveToFileHackedText_Click(object sender, RoutedEventArgs e)
        {
            string hackedText = HackedText.Text;

            if (hackedText == "")
            {
                MessageBox.Show("Нет текста!");
                return;
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog();

            bool? saveFile = saveFileDialog.ShowDialog();

            if (saveFile.Equals(true))
            {
                File.WriteAllText(saveFileDialog.FileName, hackedText);
                MessageBox.Show("Текст сохранен в файл");
            }
        }

        private void DecryptButton_Click(object sender, RoutedEventArgs e)
        {

            DecryptedText.Text = "";

            changeAlphabet(cmboxAlphabet.SelectedIndex);
            string source = EncryptedText.Text;

            BigInteger key = BigInteger.Zero;

            try
            {
                key = BigInteger.Parse(EncryptionKey.Text);
            }
            catch
            {
                MessageBox.Show("Неправильный ключ");
                return;
            }

            if (source == "")
            {
                MessageBox.Show("Введите текст!");
                return;
            }

            foreach (char c in source)
            {
                if (currentAlphabet == TypeAlphabet.Rus && engAlphabet.IndexOf(c) != -1)
                {
                    MessageBox.Show("Вводите текст только на русском языке");
                    return;
                }
                if (currentAlphabet == TypeAlphabet.Eng && rusAlphabet.IndexOf(c) != -1)
                {
                    MessageBox.Show("Вводите текст только на английском языке");
                    return;
                }
            }


            DecryptedText.Text = _CaesarCipher.Decrypt(source, key);
        }
    }
}
