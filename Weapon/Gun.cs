using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName="New Gun", menuName="Guns/Gun")]
public class Gun : ScriptableObject
{
   public string gunName;
   public GameObject gunPrefab;
   
   [Header("Stats")]
   public int minimumDamage;
   public int maximumDamage;
   public float maximumRange;
   
   public virtual void OnRightMouseDown()
   {

   }
  /* public virtual void OnMouseDown(Transform cameraPos)
   {
       
   }

   public virtual void OnMouseHold(Transform cameraPos)
   {

   }*/
}
