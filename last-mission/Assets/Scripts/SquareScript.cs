using UnityEngine;

// Inheritance
public class SquareScript : ShapeScript
{
    void Start()
    {
        Message = "Hello i am a square be square i move";
    }

    //polymorphism
    protected override void doStuff()
    {
        transform.Translate(0,1,0);
    }
}
