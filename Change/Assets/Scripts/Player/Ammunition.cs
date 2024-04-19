using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ammunition : MonoBehaviour
{
    [SerializeField]
    private int _maxBullets = 5;

    private int _bullets;

    public static Action reload;

    public void Reload()
    {
        _bullets = _maxBullets;
        PrintAmmo.setValue(_bullets);
    }

    public bool CanShoot()
    {
        if (_bullets == 0)
        {
            return false;
        }
        return true;
    }

    public void ShootBullet()
    {
        if (CanShoot())
        {
            _bullets--;
            PrintAmmo.setValue(_bullets);
        }
    }

    private void Start()
    {
        _bullets = _maxBullets;
        PrintAmmo.setValue(_bullets);

    }

    private void OnEnable()
    {
        reload += Reload;
    }

    private void OnDisable()
    {
        reload -= Reload;
    }


}
