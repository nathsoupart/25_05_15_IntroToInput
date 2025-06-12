using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class FollowMouse : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Mouse.current.rightButton.wasPressedThisFrame == false) return;
        Vector2 mousePosition = Mouse.current.position.ReadValue();
        transform.position = mousePosition;
        
    }
}
