using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponScript : MonoBehaviour
{
    [SerializeField] private PlayerScript player;
    [SerializeField] private float weaponDamage = 20;

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Monster"))
        {

            player.DamageEnemy(other.GetComponent<MonsterScript>(), weaponDamage);
            
        }
    }
}
