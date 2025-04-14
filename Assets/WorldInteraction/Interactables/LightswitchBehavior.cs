using UnityEngine;

public class LightswitchBehavior : MonoBehaviour
{
    public GameObject[] lamps;
    bool allOff = true;

    public void calledFromClick()
    {
        for (int i = 0; i < lamps.Length; i++)
        {
            var objScript = lamps[i].transform.GetComponent<LampLight>();
            bool thisLampOn = objScript.isOn;
            if (thisLampOn)
            {
                allOff = false;
                break;
            }
        }
        switchAll();
    }

    void switchAll()
    {
        for (int i = 0; i < lamps.Length; i++)
        {
            if (allOff) { // if all are off, then click all on
                var objScript = lamps[i].transform.GetComponent<LampLight>();
                objScript.turnOn();
            } else
            {
                var objScript = lamps[i].transform.GetComponent<LampLight>();
                objScript.turnOff();
            }
        }
        allOff = !allOff;

    }

}
