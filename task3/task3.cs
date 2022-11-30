// Указываем номер четверти
// Показывает диапозон возможных координат точек в этой четверти

Console.WriteLine("Enter the number of quarter: ");
int data = Convert.ToInt32(Console.ReadLine());
int quarter = data;

string spacedot = ", ";
string space = " ";

int[] q1x = {1,2,3};
q1x[0] = 1;
q1x[1] = 2;
q1x[2] = 3;

int[] q1y = {1,2,3};
q1y[0] = 1;
q1y[1] = 2;
q1y[2] = 3;

int[] q2xm = {-1,-2,-3};
q2xm[0] = -1;
q2xm[1] = -2;
q2xm[2] = -3;

int[] q2ym = {-1,-2,-3};
q2ym[0] = -1;
q2ym[1] = -2;
q2ym[2] = -3;

if (quarter == 1)
{
    Console.WriteLine("The range of values along the X axis:"+ space + q1x[0] + spacedot + q1x[1] + spacedot + q1x[2]);
    Console.Write("The range of values along the Y axis:"+ space + q1y[0] + spacedot + q1y[1] + spacedot + q1y[2]);
}

if (quarter == 2)
{
    Console.WriteLine("The range of values along the X axis:"+ space + q2xm[0] + spacedot + q2xm[1] + spacedot + q2xm[2]);
    Console.Write("The range of values along the Y axis:"+ space + q1y[0] + spacedot + q1y[1] + spacedot + q1y[2]);
}

if(quarter == 3)
{
    Console.WriteLine("The range of values along the X axis:"+ space + q2xm[0] + spacedot + q2xm[1] + spacedot + q2xm[2]);
    Console.Write("The range of values along the Y axis:"+ space + q2ym[0] + spacedot + q2ym[1] + spacedot + q2ym[2]);
}

if (quarter == 4)
{
    Console.WriteLine("The range of values along the X axis:"+ space + q1x[0] + spacedot + q1x[1] + spacedot + q1x[2]);
    Console.Write("The range of values along the Y axis:"+ space + q2ym[0] + spacedot + q2ym[1] + spacedot + q2ym[2]);
}