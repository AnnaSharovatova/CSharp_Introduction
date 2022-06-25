int count = 0;
int distance = 10000;
int FFS = 1;
int SFS = 2;
int DS = 5;
int Friend = 2;
int time = 0;

while(distance > 10)
{
    if(Friend == 1)
    {
        time = distance / (FFS + DS);
        Friend = 2;
    }
    else
    {
        time = distance / (SFS + DS);
        Friend = 1;
    }
    distance = distance - (FFS + SFS) * time;
    count += 1;
}
Console.WriteLine("Собака бежит "); 
Console.WriteLine(count); 
Console.WriteLine("раз"); 
