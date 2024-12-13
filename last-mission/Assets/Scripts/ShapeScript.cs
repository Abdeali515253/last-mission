using TMPro;
using UnityEngine;

public class ShapeScript : MonoBehaviour
{
    [SerializeField]
    private string _message; // Visible in the Inspector

    protected string Message
    {
        get => _message; // Accessor
        set => _message = value; // Mutator
    }

    public TMP_Text infoText;


    // abstraction
    private void OnMouseDown()
    {
        performAction();
    }

    private void performAction()
    {
        //abstraction
        DisplayInfo();
        doStuff();
    }

    // polymorphism
    virtual protected void DisplayInfo()
    {
        infoText.text = _message;
    }

    virtual protected void doStuff()
    {

    }
}
