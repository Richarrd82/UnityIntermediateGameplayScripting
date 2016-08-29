using UnityEngine;
using System.Collections;

public class Properties : MonoBehaviour
{
    //When needing to access a variable of a different class
    //One way to do this is to make the variables public - public int myInt;
    //Properties act like variables and encapsulate member variables which we call fields
}

public class Player
{
    private int experience; //Variable aka Field

    public int Experience   //AccessModifier Type nameOfProperty(Name the property same thing as the field except with a capital letter)
    {                       //Get and Set aka Accessors are functions 

        get
        {
            return experience;           //In Get accessor we return the Field that we are encapsulating
        }
        set
        {
            experience = value;         //In set accessor we allocate to the field using the key word value
        }

        //Stuff u can do with properties that u cant do with public variables:
        //Withou Get accessor u cannot read the field
        //Without Set accessor u cannot write to it
    }
}

public class Game
{
    Player myPlayer = new Player();

    myPlayer.Experience = 5;

    int x = myPlayer.Experience;
}