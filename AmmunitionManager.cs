using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AmmunitionManager : MonoBehaviour
{
    public static AmmunitionManager instance;

    [SerializeField] private int ammoCount=50;
    [SerializeField] private Text ammoCountText;
    private void awake()
    {
        if(instance==null)
        {
            instance=this; //if theres no instance of the class, set it to this one
        }

        else if(instance!=this)
        {
            Destroy(this); //prevents duplicates
        }
    }

    public bool ConsumeAmmo()
    {
        if(ammoCount>0)
        {
            ammoCount--;
            return true; //we have ammo and we reduced it by one
        }

        else
        {
            return false;
        }
       
    }
    private void UpdatedAmmoCountUI()
    {
        ammoCountText.text="Ammo: "+ammoCount;
    }
}
