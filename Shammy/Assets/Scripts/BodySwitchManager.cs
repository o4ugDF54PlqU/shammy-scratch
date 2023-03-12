using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BodySwitchManager : MonoBehaviour
{
    public SpriteRenderer[] buttons;
    public GameObject[] backgrounds;
    public itchySpot[] spots;
    public static BodySwitchManager instance;
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        // changeButtonColor(buttons[0], Color.green);
        // changeLimb(0);
    }

    // Update is called once per frame
    void Update()
    {
        
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

        for(int a = 0; a < spots.Length; a++)
        {
            spots[a].ActivateScratch(false);
        }
    }

    private static void changeButtonColor(SpriteRenderer button, Color newColor)
    {
        //Debug.Log(button.color);
        button.color = newColor;
        //Debug.Log(button.color);
        button.gameObject.GetComponent<limbButton>().currentColor = newColor;
    }
}
