/*Console.WriteLine("Введите первое число: ");
string a1 = Console.ReadLine();
int a = Convert.ToInt32(a1);
Console.WriteLine("Введите второе число: ");
string b1 = Console.ReadLine();
int b = Convert.ToInt32(b1);

if (a > b){
    int max = a;
    int min = b;
    Console.WriteLine("max: " + max + "; min: " + min);
} else if (a < b) {
    int max = b;
    int min = a;
    Console.WriteLine("max: " + max + "; min: " + min);
} else if (a == b) {
    Console.WriteLine("Числа равны");
}*/

/*Console.WriteLine("Введите первое число: ");
string a1 = Console.ReadLine();
int a = Convert.ToInt32(a1);
Console.WriteLine("Введите второе число: ");
string b1 = Console.ReadLine();
int b = Convert.ToInt32(b1);
Console.WriteLine("Введите третье число: ");
string c1 = Console.ReadLine();
int c = Convert.ToInt32(c1);

if (a > b){
    int max = a;
    if (max > c){
        max = max;
        Console.WriteLine("Максимальное: " + max);
    } else {
        max = c;
        Console.WriteLine("Максимальное: " + max);
    }
} else {
    int max = b;
    if (max > c){
        max = max;
        Console.WriteLine("Максимальное: " + max);
    } else {
        max = c;
        Console.WriteLine("Максимальное: " + max);
    }
}*/

/*Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

if (a % 10 == 0){
    Console.WriteLine("Число является чётным");
} else {
    Console.WriteLine("Число не является чётным");
}*/


/*Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());
int b = 1;
while(b <= a){
    if (b % 2 == 0){
        Console.WriteLine(b);
    }
    b += 1;
}*/





/* int GetRandomNumber(int Left, int Right){
    Random rnd = new Random();
    int number = rnd.Next(Left, Right + 1);
    return number;
}

int GetMaxDigitOfNumber(int number){
    int firstDigit = number / 10;
    int secondDigit = number % 10;
    
    if(firstDigit > secondDigit)
        return firstDigit;
    else
        return secondDigit;
}

int number = GetRandomNumber(10, 99);

Console.WriteLine($"Сгенерированное число: {number}");

int maxDigit = GetMaxDigitOfNumber(number);

Console.WriteLine($"Наибольшая цифра числа: {maxDigit}");
*/


/*int GetRandomNumber (){
    return new Random().Next(100, 1000);
}


void ShowRandomNumber2 (int number){
    Console.WriteLine($"Сгенерированное рандомное число: {number}");
    int num = ((number / 100) * 10) + (number % 10);
    Console.WriteLine(num);
}

ShowRandomNumber2(GetRandomNumber());
*/


/*void Number (int a){
    if ((a % 23 == 0) && (a % 7 == 0)) Console.WriteLine($"Число {a} кратно одновременно 7 и 23");
    else Console.WriteLine($"Число {a} одновременно не кратно 7 и 23");
}

Number(11);
*/

/*void sqr(int first, int second){
    double sq = Math.Pow(first, 2);
    double sq1 = Math.Pow(second, 2);
    if (sq == second){
        Console.WriteLine($"Число {first} является квадратом {second}");
    }
    else if (sq1 == first){
        Console.WriteLine($"Число {second} является квадратом {first}");
    }
    else {
        Console.WriteLine("Числа не являются квадратами друг друга");
    }

}

sqr(7, 6);
*/

//Задача 1 из домашки на 02.12.22
/*void GetRandomNumber(int a){

    int number = ((a % 100) / 10);
    Console.WriteLine(number);

}

GetRandomNumber(134);
*/

// Задача 2 из домашки на 02.12.22

/*void GetNumber(int num){
    
    if ((num >= 100) && (num <= 999)){
        int LastNum = (num % 10);
        Console.WriteLine(LastNum);
    } else if ((num > 999)){
        int len = num.ToString().Length;
        int pow = (int)Math.Pow(10, len - 3); 
        double ThirdN = ((num / pow) % 10);
        Console.WriteLine(ThirdN);
    } else {
        Console.WriteLine("Число не трёхзначное");
    }
    
}

GetNumber(12345);
*/

// Задача 3 из домашки на 02.12.22
/*
void GetNumber(int num){
    if (num < 6 && num > 0){
        Console.WriteLine("Нет");
    } else if (num > 5 && num < 8){
        Console.WriteLine("Да");
    }
}

int num = Convert.ToInt32(Console.ReadLine());
GetNumber(num);
*/