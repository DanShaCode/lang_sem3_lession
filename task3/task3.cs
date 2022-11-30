// Указываем номер четверти
// Показывает диапозон возможных координат точек в этой четверти

Console.WriteLine("Введите номер четверти:");
int data = Convert.ToInt32(Console.ReadLine());
int quarter = data;

int[] q1x = {1,2,3};
q1x[0] = 1;
q1x[1] = 2;
q1x[2] = 3;

int[] q1y = {1,2,3};
q1y[0] = 1;
q1y[1] = 2;
q1y[2] = 3;

if (quarter == 1)
{
    Console.Write(q1x[0]);
    Console.Write(q1x[1]);
    Console.Write(q1y[0]);
}
