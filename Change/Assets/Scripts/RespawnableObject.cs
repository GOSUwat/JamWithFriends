using System;
using System.Threading.Tasks;
using UnityEngine;

public class RespawnableObject : MonoBehaviour
{

    public static Action<GameObject,int> respawn;
    public static Action hello;


    private async void Respawn(GameObject obj,int respawnTime)
    {
        print("Hello");
        await Task.Delay(respawnTime * 1000);
        obj.SetActive(true);
    }

    private void OnEnable()
    {
        respawn += Respawn;
    }

    private void OnDisable()
    {
        respawn -= Respawn;
    }


}
