using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] float hitPoints = 100f;
    //[SerializeField] GameObject uiText;

    public void TakeDamage(float Damage)
    {
        //EnemyAtack Damage = GetComponent<EnemyAtack>();
        hitPoints = hitPoints - Damage;
        if(hitPoints <= 0)
        {
            //GetComponent<GameObject>();
            //uiText.SetActive(true);
            GetComponent<DeathHangler>().HanglerDeath();//entra na função HanglerDeath da classe DeathHangler
            //GetComponete<classe>().função da classe();
            
        }
    }
}
