using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PainelGameOver : MonoBehaviour
{
    public void ReiniciarJogo()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void SairJogo()
    {
        Application.Quit();
        Debug.Log("Saiu do Jogo");
    }
}
