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
            m_Camera.cullingMask = _sideCamerMask;
        }
        else
        {
            m_Camera.cullingMask = _topCamerMask;
        }
    }

    void Start()
    {
        m_Camera = Camera.main;
        m_Camera.cullingMask = _sideCamerMask;
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
