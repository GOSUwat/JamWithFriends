using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    

    [SerializeField]
    private Rigidbody _rb;
    [SerializeField]
    private float _speed = 1.0f;
    [SerializeField]
    private float rotationSpeed = 300f;


    private Vector3 _dir;

    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        _dir = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        if(_dir != Vector3.zero)
        {
            Quaternion toRotation = Quaternion.LookRotation(_dir, Vector3.up);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotation, rotationSpeed * Time.deltaTime);
        }
    }

    private void FixedUpdate()
    {
        if(CamerasBehavior.camOnTop)
        {
            _rb.velocity = new Vector3(_dir.x * _speed, _rb.velocity.y, _dir.z * _speed);
        }
        
    }
}
