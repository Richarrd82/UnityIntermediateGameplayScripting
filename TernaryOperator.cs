using UnityEngine;
using System.Collections;

public class TernaryOperator : MonoBehaviour
{
    //It is almost like a if else statement


	void Start ()
    {
        int health = 10;
        string message;

        message = health > 0 ? "Player is Alive" : "Player is dead";    
        //bool ? True expresion : False expresion;

	}
}
