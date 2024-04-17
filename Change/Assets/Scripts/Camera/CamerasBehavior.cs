using Cinemachine;
using System;
using UnityEngine;

public class CamerasBehavior : MonoBehaviour
{
    public static Action pressedSpace;

    public static bool camOnTop
    {
        get { return _camOnTop; }
        private set { _camOnTop = value; }
    }

    [SerializeField]
    private CinemachineVirtualCamera camTop;
    [SerializeField]
    private CinemachineVirtualCamera camSide;

    private static bool _camOnTop = true;

    private void ChangeCameras()
    {
        camTop.enabled = camOnTop;
        camSide.enabled = !camOnTop;
        camOnTop = !camOnTop;
    }

    private void OnEnable()
    {
        pressedSpace += ChangeCameras;
    }

    private void OnDisable()
    {
        pressedSpace -= ChangeCameras;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            pressedSpace?.Invoke();
        }
    }
}
