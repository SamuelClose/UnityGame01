using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{

    public GameArtData stats;
    public String player1Name;
    public float health, stamina, height, crouchHeight, speed, jumpMax, jumpCount;


    private void Awake()
    {
        health = stats.playerHealth;
        stamina = stats.playerStamina;
        height = stats.playerHeight;
        crouchHeight = stats.playerCrouch;
        player1Name = stats.playerName;
    }

    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
}
