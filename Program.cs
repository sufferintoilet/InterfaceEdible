internal class Program
{
    private static void Main(string[] args)
    {
        Animal[] animals = new Animal[2];
        animals[0] = new Tiger();
        animals[1] = new Chickens();
        foreach (var item in animals)
        {
            if(item is Tiger)
            {

            }
        }
        Fruit[] fruits = new Fruit[2];
        fruits[0] = new Apple();
        fruits[1] = new Orange();
        foreach (var item in fruits)
        {
            if(item is Apple)
            {

            }
        }
    }
}
public abstract class Animal
{
    public abstract string MakeSound();
}
public interface Edible
{
    public string HowToEat();
}
public abstract class Fruit: Edible
{
    public abstract string HowToEat();
    
}
public class Chikens : Animal, Edible
{
    public string HowToEat()
    {
        return "Cound something";
    }
    public override string MakeSound()
    {
        return "Chickens: Cluck Cluck";
    }
    public class Tiger: Animal
    {
        public override string MakeSound()
        {
            return "Tiger: Grower";
        }
    }
}
public abstract class Apple: Fruit
{
    public string HowToEat();
}
public abstract class Orange: Fruit
{

}

//virtual --> co the co override van chay
//abstrac --> phai co override
//1 lop chi co the ke thua 1 lop
//1 lop co the ke thua tu nhieu interface
// neu 1 lop truoc co ke thu tu interface, thi lop dan xuat khong thuc hien intelment
