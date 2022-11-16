using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public GameObject jugador;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(jugador);
        SceneManager.LoadScene("New Scene");
    }
}
