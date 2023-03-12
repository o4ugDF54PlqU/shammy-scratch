using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BodySwitchManager : MonoBehaviour
{
    public SpriteRenderer[] buttons;
    public GameObject[] backgrounds;
    public itchySpot[] spots;
    itchySpot lastScratchedSpot;

    float itchCooldown;
    public static BodySwitchManager instance;
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        changeButtonColor(buttons[0], Color.green);
        changeLimb(0);
        itchCooldown = -1.0f;
    }

    // Update is called once per frame
    void Update()
    {
        itchCooldown -= Time.deltaTime;

        if(0 >= itchCooldown)
        {
            Debug.Log("set itchy");
            if(null == lastScratchedSpot)
            {
                spots[Random.Range(0, spots.Length)].SetItchy();
            }
            else
            {
                itchySpot nextSpot = spots[Random.Range(0, spots.Length)];

                while(lastScratchedSpot == nextSpot)
                {
                    nextSpot = spots[Random.Range(0, spots.Length)];
                }

                nextSpot.SetItchy();
            }
            
            itchCooldown = 6.0f;
        }
    }

    void OnMessageReceived(string message)
    {
        Debug.Log("Received message: " + message);
    }

    public void changeLimb(int limb)
    {
        clear();
        //Debug.Log("calling changeButtonColor");
        changeButtonColor(buttons[limb], Color.green);
        backgrounds[limb].SetActive(true);
        spots[limb].ActivateScratch(true);
    }

    public void clear()
    {
        foreach (var button in buttons)
        {
            changeButtonColor(button, Color.red);
        }
        foreach (var background in backgrounds)
        {
            background.SetActive(false);
        }

        for(int a = 0; spots.Length > a; a++)
        {
            spots[a].ActivateScratch(false);
        }
    }

    public void SetLastScratchedSpot(itchySpot spot)
    {
        lastScratchedSpot = spot;
    }

    private static void changeButtonColor(SpriteRenderer button, Color newColor)
    {
        //Debug.Log(button.color);
        button.color = newColor;
        //Debug.Log(button.color);
        button.gameObject.GetComponent<limbButton>().currentColor = newColor;
    }
}
