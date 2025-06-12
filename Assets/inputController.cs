using UnityEngine;
using UnityEngine.InputSystem;

public class inputController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Mouse.current.leftButton.wasPressedThisFrame == true)
        {
            //Debug.Log(Mouse.current.leftButton.wasPressedThisFrame/*True*/);
            Debug.Log("Mouse leftButton wasPressedThisFrame");
            Vector2 mousePosition = Mouse.current.position.ReadValue();
            // float mousePositionX = Mouse.current.position.ReadValue().x;
            // float mousePositionY = Mouse.current.position.ReadValue().y;
            //Vector2 mousePosition = new Vector2(mousePositionX, mousePositionY);
            Debug.Log("mouse Position" + mousePosition);
        }   
        if (Mouse.current.rightButton.wasPressedThisFrame == true)
        {
            //Debug.Log(Mouse.current.rightButton.wasPressedThisFrame/*True*/);
            Debug.Log("Mouse rightButton wasPressedThisFrame");
        }   
        if (Mouse.current.leftButton.isPressed == true)
        {
            //Debug.Log(Mouse.current.leftButton.isPressed/*True*/);
            Debug.Log("Mouse leftButton isPressed");
        }
       
    }
}
