using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BodySwitchManager : MonoBehaviour
{
    public SpriteRenderer[] buttons;
    private static SpriteRenderer[] buttonsStatic;
    // Start is called before the first frame update
    void Start()
    {
        buttons[0].color = Color.green;
        buttonsStatic = buttons;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMessageReceived(string message)
    {
        Debug.Log("Received message: " + message);
    }

    public static void clearButtons()
    {
        foreach (var button in buttonsStatic)
        {
            button.color = Color.red;
        }
    }
}
