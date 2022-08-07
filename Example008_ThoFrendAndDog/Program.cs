int count = 0;

System.Console.WriteLine("Введите дистанцию:");
int distance = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите cкорость первого друга:");
int firstFrendSpeed = Convert.ToInt32(Console.ReadLine());


System.Console.WriteLine("Введите cкорость второго друга:");
int secondFrendSpeed = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите cкорость собаки:");
int dogSpeed = Convert.ToInt32(Console.ReadLine());

int frend = 2;

while(distance > 10){
    int time;
    if(frend == 1){
        time = distance / (firstFrendSpeed + dogSpeed);
        frend = 2;
    }
    else{
        time = distance / (secondFrendSpeed + dogSpeed);
        frend = 1;
    }

    distance = distance - (firstFrendSpeed + secondFrendSpeed) * time;
    count += 1;
}

System.Console.WriteLine("Собака пробежит " + count + " раз");
