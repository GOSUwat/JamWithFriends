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

    private Ammunition ammo;

    private void Shoot()
    {
        if (ammo.CanShoot())
        {
            ammo.ShootBullet();
            GameObject fireball = Instantiate(_fireball, _shootPosition);
            fireball.GetComponent<Rigidbody>().velocity = transform.forward * _fireballspeed;
        }
        
    }

    private void Start()
    {
        ammo = GetComponent<Ammunition>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            Shoot();
        }
        
    }

    
}
