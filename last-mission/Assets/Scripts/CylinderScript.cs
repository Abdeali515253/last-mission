using UnityEngine;

// Inheritance
public class CylinderScript : ShapeScript
{

    void Start()
    {
        Message = "Hello i am a cylinder i dont have a special message :( i rotate";
    }

    //polymorphism
    protected override void doStuff()
    {
        transform.Rotate(5, 5, 5);
    }
}
