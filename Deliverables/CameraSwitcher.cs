using UnityEngine;

public class CameraSwitcher : MonoBehaviour
{
    public Camera cam1;
    public Camera cam2;
    public Camera cam3;

    public void SwitchToCam1()
    {
        cam1.enabled = true;
        cam2.enabled = false;
        cam3.enabled = false;
    }

    public void SwitchToCam2()
    {
        cam1.enabled = false;
        cam2.enabled = true;
        cam3.enabled = false;
    }

    public void SwitchToCam3()
    {
        cam1.enabled = false;
        cam2.enabled = false;
        cam3.enabled = true;
    }
}
