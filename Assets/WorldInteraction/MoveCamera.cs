using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    float rotationX = 0f;
    float rotationY = 0f;
    public float xMin = -65f;
    public float xMax = 65f;
    new public GameObject camera;

    public float mouseSenstivity = 20f;

    // Update is called once per frame
    void Start()
    {
        //Cursor.visible = false;
    }

    void Update()
    {
        rotationX -= (Input.GetAxis("Mouse Y") * mouseSenstivity);
        rotationY += Input.GetAxis("Mouse X") * mouseSenstivity;
        // use Mathf.Clamp to put a limit on how far a player can look up and down, in order to not just let them spin around forever :)
        camera.transform.localEulerAngles = new Vector3(Mathf.Clamp(rotationX, xMin, xMax), rotationY, 0f);
    }
}
