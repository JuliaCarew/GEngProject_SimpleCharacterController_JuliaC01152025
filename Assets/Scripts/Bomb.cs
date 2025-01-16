using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;

    void Awake(){
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    private void OnEnable(){
        InputActions.InteractEvent += BombFlash; 
        InputActions.InteractEventCancelled += BombFlashEnd; 
    }
    private void OnDisable()
    {
        InputActions.InteractEvent -= BombFlash; 
        InputActions.InteractEventCancelled -= BombFlashEnd; 
    }

    private void BombFlash() // red when space is pressed, grey when released
    {
        spriteRenderer.color = Color.red;      
    }
    private void BombFlashEnd()
    {
        spriteRenderer.color = Color.grey;      
    }
}
