using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation : MonoBehaviour
{
    [SerializeField]
    private Animator _anim;
    private Rigidbody _rigidbody;

    private void Start()
    {
        _anim = GetComponent<Animator>();
        _rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        print(_rigidbody.velocity.magnitude);
        if(_rigidbody.velocity.magnitude >= 0.1f)
        {
            _anim.SetBool("isRunning", true);
        }
        if(_rigidbody.velocity.magnitude < 0.1f)
        {
            _anim.SetBool("isRunning", false);
        }
    
            
    }
}
