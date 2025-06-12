using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class MoveMousePosition : MonoBehaviour
{
    private Camera _camera;

    [SerializeField] private GameObject excluded;

    [SerializeField] private IEnumerable<GameObject> excludeds;

    [SerializeField] public LayerMask _layerMask;

    [SerializeField] public float _maxDistance=20 ;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
         _camera = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            Vector2 mousePosition = Mouse.current.position.ReadValue();
            Ray ray = _camera.ScreenPointToRay(mousePosition);
            if (Physics.Raycast(ray, out RaycastHit hit, _maxDistance, _layerMask))
            {
                Vector3 newPosition = hit.point + Vector3.up * 5f;
                transform.position = hit.point;
            }

        }
    }
}