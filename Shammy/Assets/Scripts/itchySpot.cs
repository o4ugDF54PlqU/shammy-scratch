using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itchySpot : MonoBehaviour
{
    public int pleasurePerSecond;
    private bool scratching = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        if (scratching)
        {
            PleasureBarManager.addPleasure(pleasurePerSecond * Time.deltaTime);
        }
    }

    private void OnMouseEnter()
    {
        scratching = true;
        Debug.Log("scratchy scratch");
    }

    private void OnMouseExit()
    {
        scratching = false;
    }
}
