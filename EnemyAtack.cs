using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAtack : MonoBehaviour
{
  [SerializeField] Transform target;
  [SerializeField] float damage = 20f;
  
  public void AtackHitevent()
  {
    
    if(target == null){return;}
    Debug.Log("Bang Bang");
    target.SendMessage("TakeDamage",damage);
  }
}