using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    [Header("InGame Stats")]
    [SerializeField] private float pHealth = 100;

    private Vector3 inputMovement;

    public void OnDamage(float dmgDealt)
    {
        pHealth = pHealth - dmgDealt;
        Debug.Log(pHealth);
    }

    private void Update()
    {
        LookAtMouse();   
    }

    private void LookAtMouse()
    {
       
    }
}
