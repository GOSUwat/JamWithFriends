using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Campfire : Respawn
{

    public void SetTimer(int time)
    {
        throw new System.NotImplementedException();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent <PlayerMovement>())
        {
            gameObject.SetActive(false);
            RespawnableObject.respawn?.Invoke(gameObject,_respawnTime);
            RespawnableObject.hello?.Invoke();
        }
    }
}
