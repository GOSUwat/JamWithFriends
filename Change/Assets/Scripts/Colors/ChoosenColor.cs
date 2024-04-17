using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class ChoosenColor : MonoBehaviour
{
    public static Color currentColor;


    [SerializeField]
    private RectTransform[] _images = new RectTransform[5];
    [SerializeField]
    private RectTransform _selector;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            _selector.position = _images[0].position;
            currentColor = _images[0].GetComponent<UnityEngine.UI.Image>().color;
        }
        else if(Input.GetKeyDown(KeyCode.Alpha2))
        {
            _selector.position = _images[1].position;
            currentColor = _images[1].GetComponent<UnityEngine.UI.Image>().color;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            _selector.position = _images[2].position;
            currentColor = _images[2].GetComponent<UnityEngine.UI.Image>().color;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            _selector.position = _images[3].position;
            currentColor = _images[3].GetComponent<UnityEngine.UI.Image>().color;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            _selector.position = _images[4].position;
            currentColor = _images[4].GetComponent<UnityEngine.UI.Image>().color;
        }
    }
}
