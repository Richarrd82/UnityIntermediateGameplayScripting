using UnityEngine;
using System.Collections;

public class Statics : MonoBehaviour
{
    //Static members such as variables and methods are members that are shared across all instance of a class
    //Static members can be accessed directly from a class without instantiating an object of the class first

    //Normally member vairables are unique to each object of a class
    //While every object of a class has the same variables they each have their own values
    //with static variables however each object of the class is the same variable with the same value there for
    //changing the value of static variable in one place will result in a change of value in all of the others 

    //U cannot use non static class member variables inside of static methods
    //Static method belongs to the class while non static variables belong to the instances of a class

    //U can make a whole class static the result will be that u cannot create an instance of this class
    //This is useful when u want to create a class completely made up of static member variables and methods like the Input class
}

public class Enemy
{
    public static int enemyCount = 0;

    public Enemy()
    {
        enemyCount++;
    }
}

public class Game1
{
    public void Start()
    {
        Enemy enemy1 = new Enemy();
        Enemy enemy2 = new Enemy();
        Enemy enemy3 = new Enemy();

        int x = Enemy.enemyCount;
    }
}
