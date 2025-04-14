using UnityEngine;

public class ChangeSky : MonoBehaviour
{
    float time;

    /* Material startSky;
    Material endSky;
    Material newSky;

    Color startTop;
    Color startHorizon;
    Color startBottom;

    Color midTop;
    Color midHorizon;
    Color midBottom; */

    public bool doYouLikeTheColorOfTheSky;
    public Color currentColor;
    public bool isDay = true;
    public float changeSpeed = .1f;

    public Material sky;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        sky = RenderSettings.skybox;
        sky.SetColor("_SkyTint", new Color(180, 180, 180, 1));
        isDay = true;
        currentColor = sky.GetColor("_SkyTint");
    }

    // Update is called once per frame
    void Update()
    {
        if (doYouLikeTheColorOfTheSky) { 
            flipDayNight();
        }
    }

    void flipDayNight()
    {
        
        if (isDay) // change to night
        {
            currentColor = new Color((currentColor.r - changeSpeed), (currentColor.g - changeSpeed), (currentColor.b - changeSpeed), 1);
            sky.SetColor("_SkyTint", currentColor);
        }
        else // change to day
        {
            print("changing to day");
            currentColor = new Color(currentColor.r + changeSpeed, currentColor.g + changeSpeed, currentColor.b + changeSpeed, 1);
            sky.SetColor("_SkyTint", currentColor);
        }
        print(currentColor);

        if ((currentColor.r <= 0 && currentColor.b <= 0 && currentColor.g <= 0) || (currentColor.r >= 250 && currentColor.b >= 250 && currentColor.g >= 250)) // one extreme or the other
        {
            print("i'm trying to flip out rn");
            // flip isDay
            isDay = !isDay;
            // mark that we've completed this task for now
            doYouLikeTheColorOfTheSky = false;
        }
    }
}
