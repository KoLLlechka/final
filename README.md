# ООП. Лабораторная работа №3. Перегрузка операций. Вариант 9
## Постановка задачи
Задание 1. Реализовать определение класса (поля, свойства,
конструкторы, перегрузка метода ToString() для вывода полей, заданный
метод согласно варианту). Протестировать все методы, включая
конструкторы, не забывайте проверять вводимые пользователем данные
на корректность!

Задание 2. Добавить к реализованному в первом задании классу
указанные в варианте перегруженные операции. Протестировать все
методы

## Класс Point
## Поля
Класс содержит поля:
```c#
private double x, y;
```

## Конструкторы
Конструктор **по умолчанию** инициализирует рандомные значения для x и y:

```c#
public Point() //конструктор по умолчанию
{
    Random random = new Random();
    x = random.Next(-1000, 1000) / Math.Pow(10, random.Next(3));
    y = random.Next(-1000, 1000) / Math.Pow(10, random.Next(3));
}
```

Конструктор **с параметрами** инициализирует точку с переданными значениями:

```c#
public Point(double x, double y)
{ 
    this.x = x;
    this.y = y;
}
```

**Конструктор копирования**:

```c#
public Point(Point n) //конструктор копирования
{
    x = n.x;
    y = n.y;
}
```

## Методы

Ниже преставлены реализованные **методы** класса **Point**:

```c#
//перегруженный ToString(), возвращает координаты точки
public override string ToString() {...};

//вычисляет расстояние от точки до начала координат
public double Distance() {...};

//перегрузка унарных операторов

//уменьшение координат x и y на 1
public static Point operator --(Point n) {...};
//меняет координаты х и у местами
public static Point operator -(Point n) {...};

//перегрузка оператора вычитания

//вычитает целое число из координаты x(левосторонняя операция)
public static Point operator -(Point n, int z) {...};
//вычитает целое число из координаты y(правосторонняя операция)
public static Point operator -(int z, Point n) {...};
//вычисляет расстояние от точки p1 до точки p, возвращает вещественное число
public static double operator -(Point z, Point n) {...};

//int (неявная) – результатом является целая часть координаты х
public static implicit operator int(Point n) {...};
//double (явная) – результатом является координата y 
public static explicit operator double(Point n) {...};

//геттеры
public double X {...};
public double Y {...};
```
## Класс MainWindow
## Поля
Класс содержит поле:

```c#
string textTask;
```

## Конструкторы
## Конструктор по умолчанию:

```c#
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
```

## Методы

```c#
private void ValueText(string v1, string v2, string v3)
private void VisibleValue(Visibility v1, Visibility v2, Visibility v3)
private void ChangedTask()
public string InputIsCorrect(Func<bool> isCorrect, Func<string> resultFunc)
 private void outputButton_Click(object sender, RoutedEventArgs e)
private string ForPoint()
```

## Тесты

# Если пользователь успешно ввел значения x и y

*Вывод:*

![image](https://github.com/user-attachments/assets/4d6c9493-ccb0-49c0-a8a4-a737118a431b)

# Если пользователь ввел некорректные значения x и y

*Вывод:*

![image](https://github.com/user-attachments/assets/d6a3a881-ec52-4cfd-8a41-1dc18aee1ae9)
