using UnityEngine;

public class RayBasedNavigation : MonoBehaviour
{
    public Camera mainCam;
    private RaycastHit hit;
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        mainCam = GetComponent<Camera>();
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 lineOrigin = mainCam.ViewportToWorldPoint(new Vector3(0.5f, 0.5f, 0.0f));
        Debug.DrawRay(lineOrigin, mainCam.transform.forward * 50f, Color.yellow);

        if (Input.GetMouseButtonDown(0))
        {

            if (Physics.Raycast(lineOrigin, mainCam.transform.forward, out hit, 50f))
            {

                if (hit.transform.CompareTag("Interactive")) // save ourselves some time/computational brainpower, only go down this route if we already know the object we're hitting is interactive
                {
                    print("hit something we can mess with");

                    if (hit.transform.name == "Basketball")
                    {
                        var objScript = hit.transform.GetComponent<KickBall>();
                        objScript.calledFromClick();
                    } else if (hit.transform.name == "lampmodel")
                    {
                        print("calling a lamp");
                        var objScript = hit.transform.GetComponent<LampLight>();
                        objScript.calledFromClick();
                    } else if (hit.transform.name == "hattest")
                    {
                        // to implement
                        var objScript = hit.transform.GetComponent<WearAccessory>();
                        objScript.calledFromClick();
                    } else if (hit.transform.name == "Rug")
                    {
                        var objScript = hit.transform.GetComponent<ChangeMaterial>();
                        objScript.calledFromClick();
                    } else if (hit.transform.name == "Light Switch")
                    {
                        var objScript = hit.transform.GetComponent<LightswitchBehavior>();
                        objScript.calledFromClick();
                    }
                }
            }
        }

        // if (hit.transform.CompareTag("MyTag"))

    }
}
