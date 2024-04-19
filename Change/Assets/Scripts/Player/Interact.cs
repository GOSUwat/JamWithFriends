using UnityEngine;

public class Interact : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.GetComponent<Campfire>())
        {
            Ammunition.reload?.Invoke();
        }
    }
}
