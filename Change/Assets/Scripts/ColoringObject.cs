using System.Collections.Generic;
using UnityEngine;

public class ColoringObject : MonoBehaviour
{
    [SerializeField]
    private float minColorCount = 1;
    [SerializeField]
    private float maxColorCount = 9;    

    private List<Color> _objectColors = new List<Color>();
    private List<Color> _saveOvjectColors;

    private void Start()
    {
        for(int i = 0; i <= Random.Range(minColorCount, maxColorCount); i++)
        {
            _objectColors.Add(MaterialList.colors[Random.Range(0,5)]);
        }
        _saveOvjectColors = _objectColors;
        gameObject.GetComponent<Renderer>().material.SetColor("_Color", _objectColors[0]);
    }

    public void OnHit(Color fireballColor)
    {
        if(fireballColor != gameObject.GetComponent<Renderer>().material.color)
        {
            return;
        }

        if(_objectColors.Count != 0)
        {
            _objectColors.RemoveAt(0);      
        }
        if(_objectColors.Count == 0)
        {
            gameObject.SetActive(false);
            return;
        }
        gameObject.GetComponent<Renderer>().material.SetColor("_Color", _objectColors[0]);

    }
}
