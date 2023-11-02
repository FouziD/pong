using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scenemanage : MonoBehaviour
{ // keuze van de spel version
    public void playervsplayer()
    {
        SceneManager.LoadScene("playervsplayer");
    }
    public void playerVsBot()
    {
        SceneManager.LoadScene("playerVsBot");
    }
    public void Snellegame()
    {
        SceneManager.LoadScene("Snellegame");
    }
}