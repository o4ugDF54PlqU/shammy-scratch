using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BodySwitchManager : MonoBehaviour
{
    public SpriteRenderer[] buttons;
    public GameObject[] backgrounds;
    private static SpriteRenderer[] buttonsStatic;
    private static GameObject[] backgroundsStatic;
    // Start is called before the first frame update
    void Start()
    {
        buttons[0].color = Color.green;
        buttonsStatic = buttons;
        backgroundsStatic = backgrounds;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMessageReceived(string message)
    {
        Debug.Log("Received message: " + message);
    }

    public static void changeLimb(int limb)
    {
        clear();
        buttonsStatic[limb].color = Color.green;
        backgroundsStatic[limb].SetActive(true);
    }

    public static void clear()
    {
        foreach (var button in buttonsStatic)
        {
            button.color = Color.red;
        }
        foreach (var background in backgroundsStatic)
        {
            background.SetActive(false);
        }
    }
}
