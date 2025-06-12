using UnityEngine;
using UnityEngine.InputSystem;
using System.Collections.Generic;
public class lookMouse : MonoBehaviour
{  
    [SerializeField] public LayerMask _layerMask;

    [SerializeField] public float _maxDistance=20 ;
 
    private Camera _camera;
    [SerializeField] private GameObject prefab;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _camera = Camera.main;
    }
    // Update is called once per frame
    void Update()
    {
        Vector2 mousePosition = Mouse.current.position.ReadValue();
        Ray ray = _camera.ScreenPointToRay(mousePosition);
        if (Physics.Raycast(ray, out RaycastHit hit, _maxDistance, _layerMask))
        {
            ;
            Vector3 direction = (hit.point - transform.position);
            Quaternion rotation = Quaternion.LookRotation(direction);
            transform.rotation = rotation;
        }

        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            GameObject instance = Instantiate(prefab, hit.point, Quaternion.identity);
        }
    
}
}

