using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itchySpot : MonoBehaviour
{
    public int pleasurePerSecond;
    public int bloodLossPerSecond;
    bool canScratch;
    private bool scratching = false;
    // Start is called before the first frame update
    void Start()
    {
        canScratch = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        if (canScratch && scratching)
        {
            BloodLossBarManager.addBloodLoss(bloodLossPerSecond * Time.deltaTime);
        }
    }

    public void ActivateScratch(bool isActive)
    {
        scratching = false;
        canScratch = isActive;
        GetComponent<SpriteRenderer>().enabled = isActive;
    }

    private void OnMouseEnter()
    {
        if (canScratch)
        {
            PleasureBarManager.addPleasure(pleasurePerSecond);
            scratching = true;
            Debug.Log("scratchy scratch");
        }
    }

    private void OnMouseExit()
    {
        scratching = false;
    }
}
