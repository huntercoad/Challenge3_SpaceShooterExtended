using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponController : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip weapon_enemy;
    public GameObject shot;
    public Transform shotSpawn;
    public float fireRate;
    public float delay;

    

    void Start()
    {
        InvokeRepeating("Fire", delay, fireRate);
    }

    void Fire()
    {
        Instantiate(shot, shotSpawn.position, shotSpawn.rotation);
        audioSource.clip = weapon_enemy;
        audioSource.Play();
    }
}
