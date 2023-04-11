using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    [Header("InGame Stats")]
    [SerializeField] private float pHealth = 100;

    [Header("Calculations")]
    private Vector3 _moveDirection;
    //private Vector3 _mousePos;
    public bool isAttacking = false;

    [Header("References")]
    private Rigidbody rb;
    [SerializeField] public GameObject WeaponCollider;


    public void OnDamage(float dmgDealt)
    {
        pHealth = pHealth - dmgDealt;
        Debug.Log($"Player Health = {pHealth}");
    }
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        ProcessInputs();

    }
    private void FixedUpdate()
    {
        PlayerMovement();
        
    }

    private void ProcessInputs()
    {
        var horizontalInput = Input.GetAxisRaw("Horizontal");
        var verticalInput = Input.GetAxisRaw("Vertical");
        _moveDirection = new Vector3(horizontalInput, transform.position.y, verticalInput).normalized;

        if (Input.GetMouseButton(0))
        {
            isAttacking = true;
            WeaponCollider.SetActive(true);
        }

        else if (Input.GetMouseButtonUp(0))
        {
            isAttacking = false;
            WeaponCollider.SetActive(false);
        }
    }

   
    private void PlayerMovement()
    {
        rb.velocity = new Vector3(_moveDirection.x * 10, 0, _moveDirection.z * 10);
        
    }

    public void DamageEnemy(MonsterScript currentEnemy, float weaponDamage)
    {
        if (currentEnemy !=null)
        {
            currentEnemy.monsterOnDamage(weaponDamage);
        }
    
    
    }



}
