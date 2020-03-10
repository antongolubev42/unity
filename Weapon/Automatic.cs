using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName="Automatic Gun",menuName="Guns/Automatic")]
public class Automatic : Gun
{   
    /*public float fireRate;
    private float lastTimeFired;

    public override void OnMouseHold(Transform cameraPos)
    {   
        //total time youve been running
        if(Time.time - lastTimeFired > 1 / fireRate)
        {   
           
            lastTimeFired=Time.time;

            RaycastHit whatIHit;
            if(Physics.Raycast(cameraPos.position,cameraPos.transform.forward,out whatIHit, Mathf.Infinity))
            {
                Debug.Log(whatIHit.collider.name);

                IDamagable damagable=whatIHit.collider.GetComponent<IDamagable>();
                if(damagable!=null)
                {
                    //checks the distance of the fired shot
                    float normalisedDistance=whatIHit.distance/maximumRange;
                    //if the distance is more than 1 that means that it is above the max range
                    if(normalisedDistance<=1)
                    {
                        //make damage drop off as range goes up
                        damagable.DealDamage(Mathf.RoundToInt(Mathf.Lerp(maximumDamage,minimumDamage,normalisedDistance)));
                    }
                }

            }
        } 
    }        */
 
}
