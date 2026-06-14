using UnityEngine;

public class PrintCenter : MonoBehaviour
{
    void Start()
    {
        Debug.Log(gameObject.name + " center: " + GetComponent<Renderer>().bounds.center);
    }
}