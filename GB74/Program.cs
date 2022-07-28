
Console.Clear();

int friends = Input("Сколько друзей идут по барам: ");
int maxBars = Input("Сколько пабов планируют посетить: ");
double countPint = InputD("Сколько пинт выпьют в каждом баре: ");
int minTimeDistance = Input("Сколько минимум времени идти до каждого бара: ");
int maxTimeDistance = Input("Сколько максимум времени идти до каждого бара: ");
int drinkTime = Input($"За сколько минут каждый друг выпивает пинту пенного: ");;

double[] maxDrank = new double [friends];
for(int i=0; i<friends; i++ )
{
    maxDrank[i] = InputD($"Сколько максимум литров может выпить {i+1}-й друг: ");
}

double[] countDrink = new double[friends];
double pinta = 0.568;
double drinksInMinute = pinta/drinkTime;

int[] countBar = new int[friends];
int[] countDrinkTime = new int[friends];

int friend = 0;
for(friend = 0; friend<friends; friend++)
{
    while(countDrink[friend] <= maxDrank[friend] && countBar[friend] < maxBars)
    {
        for(int i = 0; i<countPint*drinkTime; i++)
        {
            countDrink[friend]+= drinksInMinute;
            countDrinkTime[friend]++;
            if(countDrink[friend] > maxDrank[friend] )
            {
                break;
            }
        }
        countBar[friend]++;
    }

    string barEnd = "бара";
    if(countBar[friend]>4)
    {
        barEnd = "баров";
    }

    Console.Write($"\n{friend+1}-й друг пройдёт {countBar[friend]} {barEnd}. На выпивку он потратит {countDrinkTime[friend]} минут. ");

    int minFullTime = countDrinkTime[friend] + minTimeDistance*(countBar[friend]-1);
    int maxFullTime = countDrinkTime[friend] + maxTimeDistance*(countBar[friend]-1);
    Console.WriteLine($"На хождение по барам и выпивку {friend+1}-й друг потратит от {minFullTime} до {maxFullTime} минут.");
}


int Input(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}

double InputD(string output)
{
    Console.Write(output);
    return Convert.ToDouble(Console.ReadLine());
}
