double distance = 10000,
        time = 0;
byte firstFriendSpeed = 1,
    secondFriendSpeed = 2,
    dogSpeed = 5, 
    friend = 2,
    quantiti = 0,
    meet = 10;
while(distance > meet)
{
    if(friend == 1)
    {
        time = distance / (firstFriendSpeed + dogSpeed);
        friend = 2;
    }
    else
    {
        time = distance / (secondFriendSpeed + dogSpeed);
        friend = 1;
    }
    distance = distance - (firstFriendSpeed + secondFriendSpeed) * time;
quantiti++;
}
Console.WriteLine("Собака пробежала " + quantiti + " раз.");