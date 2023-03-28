using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterScript : MonoBehaviour
{
    [Header("References")]
    [SerializeField] private ParticleSystem bloodFx;
    [SerializeField] private PlayerScript player;

    [Header("InGame Stats")]
    [SerializeField] private float damageDealt = 20;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("player").GetComponent<PlayerScript>();
    }
    public void playFX() {
        bloodFx.Play();

    }

    public void DamagePlayer()
    {
        player.OnDamage(2000);
        playFX();
    }
}
