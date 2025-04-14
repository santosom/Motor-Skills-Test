using UnityEngine;

public class LampLight : MonoBehaviour
{
    public Light lampLight;
    public GameObject lightSource;
    public bool isOn = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        lampLight = lightSource.GetComponent<Light>();
        lampLight.GetComponent<Light>().enabled = isOn;
    }

    public void calledFromClick()
    {
        lampLight.GetComponent<Light>().enabled = isOn;
        isOn = !isOn;
    }

    public void turnOff() // this is for the lightswitch, which will first turn off all the lights, and then turn them back on if both are true
        // that will be in a seperate script
    {
        lampLight.GetComponent<Light>().enabled = false;
        isOn = false;
    } 

    public void turnOn()
    {
        lampLight.GetComponent<Light>().enabled = true;
        isOn = true;
    }
}
