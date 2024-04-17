using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraCullingMask : MonoBehaviour
{
    private Camera m_Camera;

    [SerializeField]
    private LayerMask _topCamerMask;
    [SerializeField]
    private LayerMask _sideCamerMask;
    
    private void SwitchCameraMask()
    {
        if (CamerasBehavior.camOnTop)
        {
            m_Camera.cullingMask = _topCamerMask;
        }
        else
        {
            m_Camera.cullingMask = _sideCamerMask;
        }
    }

    void Start()
    {
        m_Camera = Camera.main;
    }

    private void OnEnable()
    {
        CamerasBehavior.pressedSpace += SwitchCameraMask;
    }
    private void OnDisable()
    {
        CamerasBehavior.pressedSpace -= SwitchCameraMask;
    }
}
