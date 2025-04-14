using UnityEngine;

public class WearAccessory : MonoBehaviour
{
    // we're going to stick this thing on the player's head, moving it to the transform
    public GameObject playerHead;
    // handle the GameObject itself
    public GameObject myself;
    public GameObject wornHat;
    public GameObject[] otherHats;
    public bool isWorn;
    int numOfHats;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        myself.SetActive(true);
        wornHat.SetActive(false);
        isWorn = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void calledFromClick()
    {
        putOnHat();
    }

    void putOnHat()
    {
        for (int i = 0; i < otherHats.Length; i++) {
            bool otherHatIsWorn = otherHats[i].GetComponent<WearAccessory>().isWorn;
            if (otherHatIsWorn) {
                otherHats[i].GetComponent<WearAccessory>().takeOffHat();
            }
        }

        wornHat.SetActive(true);
        myself.SetActive(false);
        isWorn = true;
    }

    public void takeOffHat()
    {
        myself.SetActive(true);
        wornHat.SetActive(false);
        isWorn = false;
    }
}
