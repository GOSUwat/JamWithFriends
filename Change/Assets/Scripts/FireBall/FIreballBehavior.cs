using UnityEngine;

public class FireballBehavior : MonoBehaviour
{

    private ParticleSystem _particleSystem;
    private ParticleSystem.MainModule main;
    void Start()
    {
        transform.parent = null;
        _particleSystem = transform.GetChild(0).GetComponent<ParticleSystem>();
        main = _particleSystem.main;
        main.startColor = ChoosenColor.currentColor;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<ColoringObject>())
        {

            collision.gameObject.GetComponent<ColoringObject>().OnHit(main.startColor.color);
        }
        Destroy(gameObject);
    }
}
