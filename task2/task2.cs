// Принимает на вход координаты точки X и Y
// X != 0 && Y != 0;
// Выдаем четверть плоскости, в которой находится эта точка

Console.WriteLine("Введите X:");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите Y:");
int y = Convert.ToInt32(Console.ReadLine());

if (x == 0 | y == 0)
{
    Console.WriteLine("Ошибка ввода: X или Y не может быть равен 0");
}
else
{
    if (x > 0 | y > 0)
{
    Console.WriteLine("Координата находится в ПЕРВОЙ четверти");
}

if (x < 0 && y > 0)
{
    Console.WriteLine("Координата находится во ВТОРОЙ четверти");
}

if (x < 0 && y < 0)
{
    Console.WriteLine("Коориданата находится в ТРЕТЬЕЙ четверти");
}

if (x > 0 && y < 0)
{
    Console.WriteLine("Координата находится в ЧЕТВЕРТОЙ четверти");
}
}