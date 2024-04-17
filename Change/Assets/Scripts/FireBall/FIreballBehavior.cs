using UnityEngine;

public class FireballBehavior : MonoBehaviour
{
    private ParticleSystem _particleSystem;
    void Start()
    {
        transform.parent = null;
        _particleSystem = transform.GetChild(0).GetComponent<ParticleSystem>();
        ParticleSystem.MainModule main = _particleSystem.main;
        main.startColor = ChoosenColor.currentColor;
    }

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
    }
}
