using UnityEngine;

public class MaterialList : MonoBehaviour
{
    [SerializeField]
    private Material[] _materials = new Material[5];

    public static Material[] materials = new Material[5];

    private void Start()
    {
        materials = _materials;
    }
}
