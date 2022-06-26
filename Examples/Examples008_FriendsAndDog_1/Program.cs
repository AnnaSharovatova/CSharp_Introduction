Console.Clear();
Console.Write("Введите скорость первого: ");
var FirstFriendSpeed = Convert.ToSingle(Console.ReadLine());
Console.Write("Введите скорость второго: ");
var SecondFriendSpeed = Convert.ToSingle(Console.ReadLine());
Console.Write("Введите скорость собаки: ");
var DogSpeed = Convert.ToSingle(Console.ReadLine());
Console.Write("Введите расстояние между друзьями: ");
var distance = Convert.ToSingle(Console.ReadLine());

int distanceLimit = 10;
bool DogDirection = true;
int DogCounter = 0;
Single timeToMeet = 0;

while (distance > distanceLimit)
{
    if (DogDirection == true)
    {
        timeToMeet = distance / (FirstFriendSpeed + DogSpeed);
        DogDirection = false;
    }
    else
    {
        timeToMeet = distance / (SecondFriendSpeed + DogSpeed);
        DogDirection = true;  
    }
    distance = distance - timeToMeet * (FirstFriendSpeed + SecondFriendSpeed);
    DogCounter ++;
    Console.WriteLine(distance);
}
Console.WriteLine("Собака пробежала " + DogCounter + " раз (а)");