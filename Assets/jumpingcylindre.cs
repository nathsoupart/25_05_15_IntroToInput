using UnityEngine;

public class jumpingcylindre : MonoBehaviour
{   [SerializeField] private Rigidbody _rigidbody;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _rigidbody.AddForce(Vector3.up * 10, ForceMode.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }
}
