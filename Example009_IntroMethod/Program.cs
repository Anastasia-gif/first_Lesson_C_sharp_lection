int Max(int arg1, int arg2, int arg3){
    int result = arg1;
    if(arg2 > result) result = arg2;
    if(arg3 > result) result = arg3;
    return result;
}

int a = 25;
int b = 45;
int c = 35;
int d = 25;
int i = 15;
int f = 75;
int g = 30;
int s = 19;
int z = 18;

int max1 = Max(a,b,z);
int max2 = Max(d,f,g);
int max3 = Max(s,i,c);

int maxFinal = Max(
    Max(a,b,z),
    Max(d,f,g),
    Max(s,i,c)
);
System.Console.WriteLine(maxFinal);