using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootFireBall : MonoBehaviour
{
    [SerializeField]
    private GameObject _fireball;
    [SerializeField]
    private Transform _shootPosition;
    [SerializeField]
    private float _fireballspeed = 3f;

    private ParticleSystem _particleSystem;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            print(ChoosenColor.currentColor);
            GameObject fireball = Instantiate(_fireball, _shootPosition);
            fireball.GetComponent<Rigidbody>().velocity = transform.forward * _fireballspeed;
        }
        
    }
}
