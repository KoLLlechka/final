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

namespace FinalProject
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string textTask;

        public MainWindow()
        {
            InitializeComponent();
            task.Content = "Задание 1. Реализовать определение класса (поля, свойства,\r\n" +
                "конструкторы, перегрузка метода ToString() для вывода полей,\r\n" +
                "заданный метод согласно варианту). Протестировать все методы,\r\n" +
                "включая конструкторы, не забывайте проверять вводимые пользователем\r\n" +
                "данные на корректность!\r\n\r\n" +
                "Задание 2. Добавить к реализованному в первом задании классу\r\n" +
                "указанные в варианте перегруженные операции. Протестировать все\r\n" +
                "методы";
            ValueText("x =", "y =", "");
            answer.Content = "";
            VisibleValue(Visibility.Visible, Visibility.Visible, Visibility.Collapsed);
            ChangedTask();
            answer.Visibility = Visibility.Visible;
        }

        private void ValueText(string v1, string v2, string v3)
        {
            value1.Text = "";
            value2.Text = "";
            value3.Text = "";
            valueText1.Content = v1;
            valueText2.Content = v2;
            valueText3.Content = v3;
        }

        private void VisibleValue(Visibility v1, Visibility v2, Visibility v3)
        {
            value1.Visibility = v1;
            value2.Visibility = v2;
            value3.Visibility = v3;
            valueText1.Visibility = v1;
            valueText2.Visibility = v2;
            valueText3.Visibility = v3;
        }

        private void ChangedTask()
        {
            input.Visibility = Visibility.Visible;
            outputButton.Visibility = Visibility.Visible;
        }

        public string InputIsCorrect(Func<bool> isCorrect, Func<string> resultFunc)
        {
            if (isCorrect())
            {
                return resultFunc();
            }
            else
            {
                return "Ввод не корректен";
            }
        }

        private void outputButton_Click(object sender, RoutedEventArgs e)
        {
            answer.Content = InputIsCorrect(
                       () => InputCheck.IsStringToDouble(value1.Text) && 
                       InputCheck.IsStringToDouble(value2.Text),
                       () => ForPoint());
        }

        private string ForPoint()
        {
            Random random = new Random();
            int z = random.Next(100);
            Point coordinates = new Point(double.Parse(value1.Text), double.Parse(value2.Text));
            Point p1 = new Point();
            int meow = coordinates;
            return "Расстояние от точки до начала координат: " + coordinates.Distance().ToString() +
                "\n\nУменьшенные на 1 координаты: " + (--coordinates).ToString() +
                "\n\nПоменянные координаты х и у местами: " + (-coordinates).ToString() +
                "\n\nint (неявная) – результатом является целая часть\r\nкоординаты х(вводимой): " + meow +
                "\n\ndouble (явная) – результатом является координата y: " + (double)coordinates +
                $"\n\nЦелое число: {z}" +
                "\n\nPoint p - целое число (левосторонняя операция,\nуменьшается координата х): " + (coordinates - z).ToString() +
                "\n\nЦелое число - Point p (правосторонняя операция,\nуменьшается координата y): " + (z - coordinates).ToString() +
                "\n\nКоординаты точки p1: " + p1.ToString() +
                "\n\nPoint p – Point p1 вычисляется расстояние до точки p,\nрезультатом должно быть вещественное число: " + (coordinates - p1);
        }
    }
}
