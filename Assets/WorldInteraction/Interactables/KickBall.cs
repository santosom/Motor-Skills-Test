using UnityEngine;

public class KickBall : MonoBehaviour
{
    private Rigidbody rb;
    public Transform playerOrientation;
    // ignore that this isn't actually what power means, i'm just using it as a modifier
    public float power = 20f;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    
    /*void OnMouseOver()
    {
        print("mousing over the ball rn.");
        if(Input.GetMouseButtonDown(0))
        {
            // use our knowledge of the player's orientation to kick 
            Vector3 toKick = playerOrientation.forward * power + playerOrientation.right * power + transform.up * (power*5);
            rb.AddForce(toKick, ForceMode.Force);
            print("I've been clicked!");
        }
    } */

    // will be called from our laser script we just wrote
    public void calledFromClick()
    {
        Vector3 toKick = playerOrientation.forward * power + playerOrientation.right * power + transform.up * (power * 8);
        rb.AddForce(toKick, ForceMode.Force);
        print("kick called");
    }
}
