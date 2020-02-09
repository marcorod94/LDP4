using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightColor : MonoBehaviour
{

    public Color endColor;
    public float fadeTime = 2.5f;
    Color selection;

    private float tColor;
    // Start is called before the first frame update
    void OnEnable()
    {
        selection = gameObject.GetComponent<Light>().color;
        tColor = 0; // reset timer
    }

    void Update()
    {
        if (tColor <= 1)
        { // if end color not reached yet...
            tColor += Time.deltaTime / fadeTime; // advance timer at the right speed
            GetComponent<Light>().color = Color.Lerp(selection, endColor, tColor);
        }
    }

    private void OnDisable()
    {
        GetComponent<Light>().color = selection;
    }
}
