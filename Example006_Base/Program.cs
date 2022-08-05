int max = 0;

System.Console.WriteLine("Сколько у вас гирик? ");
int countBols = Convert.ToInt32(Console.ReadLine());

int [] weightBols = new int [countBols];

int i = 0;
while(i < weightBols.Length){
    System.Console.WriteLine("Введите вес " + (i + 1) + "-ой гири");
    int wB = Convert.ToInt32(Console.ReadLine());
    weightBols[i] = wB;
    i++;
}

for(int j = 0; j < weightBols.Length; j++){
    if(weightBols[j] > max){
        max = weightBols[j];
    }
}
System.Console.WriteLine("Максимальный вес " + max);