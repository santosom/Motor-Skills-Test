using UnityEngine;

public class UIBehavior : MonoBehaviour
{
    public Renderer rend;
    public Transform player;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rend = GetComponent<Renderer>();
        if (rend = null)
        {
            print("WARNING- REND IS NULL");
        }
    }

    void OnWillRenderObject()
    {
        transform.LookAt(player);
    }
}