using UnityEngine;

public class ChangeMaterial : MonoBehaviour
{
    // we're just going to cycle through these
    public Material[] rugOption;
    public GameObject rug;
    private int currRugIndex;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // reference this object's material and set it equal to the first material in our array
        rug.GetComponent<MeshRenderer>().material = rugOption[0];
    }

    // cycle through rug materials
    public void calledFromClick()
    {
        if (currRugIndex == rugOption.Length-1) // then we're at the end of the array
        {
            currRugIndex = 0; // reset (think of this as a loop)
            rug.GetComponent<MeshRenderer>().material = rugOption[0];
        } else
        {
            currRugIndex++;
            rug.GetComponent<MeshRenderer>().material = rugOption[currRugIndex];
        }
    }
}
