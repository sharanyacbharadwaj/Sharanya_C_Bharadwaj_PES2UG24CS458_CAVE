using UnityEngine;

public class RoomLights : MonoBehaviour
{
    public GameObject row1;
    public GameObject row2;
    public GameObject row3;
    public GameObject row4;
    public GameObject row5;

    private bool row1On = true;
    private bool row2On = true;
    private bool row3On = true;
    private bool row4On = true;
    private bool row5On = true;

    public void ToggleRow1() { row1On = !row1On; SetLights(row1, row1On); }
    public void ToggleRow2() { row2On = !row2On; SetLights(row2, row2On); }
    public void ToggleRow3() { row3On = !row3On; SetLights(row3, row3On); }
    public void ToggleRow4() { row4On = !row4On; SetLights(row4, row4On); }
    public void ToggleRow5() { row5On = !row5On; SetLights(row5, row5On); }

    private void SetLights(GameObject row, bool state)
    {
        Light[] lights = row.GetComponentsInChildren<Light>();
        foreach (Light light in lights)
        {
            light.enabled = state;
        }
    }
}
