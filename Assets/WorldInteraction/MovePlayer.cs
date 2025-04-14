using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    //inputs
    public float horizontal;
    public float vertical;

    //information about the body moving
    public Transform orientation;
    public Rigidbody rb;

    //information about moving
    private float velocity;
    public float speed = 50f;
    public Vector3 moveForce;
    public float maxVelocity = 1f;

    public bool suppressingMovement;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
        if (rb != null)
        {
            print("rb in place.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
        suppressingMovement = !(Input.GetAxis("Horizontal") != 0 || Input.GetAxis("Vertical") != 0);
        if (suppressingMovement)
        {
            rb.linearVelocity = Vector3.zero;
            rb.angularVelocity = Vector3.zero;
        }
        updateMove();
    }

    void updateMove()
    {
        moveForce = orientation.forward * vertical + orientation.right * horizontal;
        rb.AddForce(moveForce.normalized * speed, ForceMode.Force);
    }
}
