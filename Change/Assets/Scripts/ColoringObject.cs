using System.Collections.Generic;
using UnityEngine;

public class ColoringObject : MonoBehaviour
{
    [SerializeField]
    private GameObject _colorManager;

    private List<Material> _materials;

    private void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i <= Random.Range(1, 8); i++)
        {
            print(MaterialList.materials[1]);
        }
        gameObject.GetComponent<Renderer>().material.SetColor("_Color", MaterialList.materials[0].color);
    }
}
