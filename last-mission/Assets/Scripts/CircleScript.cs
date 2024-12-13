using UnityEngine;

// Inheritance
public class CircleScript : ShapeScript
{
    //polymorphism
    void Start()
    {
        Message = "Hello i am a circle do you like pi also i grow big";
    }

    protected override void doStuff()
    {
        transform.localScale *= 1.1f;
    }
}
