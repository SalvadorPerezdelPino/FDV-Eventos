using System;
using UnityEngine;

enum SpeedMode {NORMAL, SILENT}
public class SpeedModeController : MonoBehaviour
{
    public PlayerMovement player;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeSpeedMode(int mode)
    {
        switch (mode)
        {
            case (int)SpeedMode.NORMAL:
            {
                player.speed = 5.0f;
                break;
            }
            case (int)SpeedMode.SILENT:
            {
                player.speed = 2.0f;
                break;
            }
        }
    }
}
