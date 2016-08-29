using UnityEngine;
using System.Collections;

public class MethodOverloading : MonoBehaviour
{
    //The first Add method has a signature of
    //"Add(int, int)". This signature must be unique.
    public int Add(int num1, int num2)
    {
        return num1 + num2;
    }

    //The second Add method has a signature of
    //"Add(string, string)". Again, this must be unique.
    public string Add(string str1, string str2)
    {
        return str1 + str2;
    }
}

public class SomeOtherClass
{
    MethodOverloading myClass = new MethodOverloading();

    void Start()
    {
        myClass.Add(1, 2);    //If i pass in numbers the first method will run
        myClass.Add(1, 2);    //If i pass in string the second method will run
    }
}
