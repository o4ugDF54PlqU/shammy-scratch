using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class limbButton : MonoBehaviour
{
    public int limb;
    public Color currentColor;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<SpriteRenderer>().color = Color.red;
        currentColor = Color.red;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        BodySwitchManager.changeLimb(limb);
        Debug.Log("Square clicked!");
    }

    private void OnMouseEnter()
    {
        GetComponent<SpriteRenderer>().color = Color.yellow;
    }

    private void OnMouseExit()
    {
        GetComponent<SpriteRenderer>().color = currentColor;
    }
}
