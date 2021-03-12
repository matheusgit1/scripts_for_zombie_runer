using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathHangler : MonoBehaviour
{
    [SerializeField] Canvas gameOverCanvas;

    public void Start()
    {
        gameOverCanvas.enabled = false;
    }

    public void HanglerDeath()
    {
        //Debug.Log("you die my friend");
        gameOverCanvas.enabled = true;
        Time.timeScale = 0;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
}
