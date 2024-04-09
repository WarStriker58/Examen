using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuSceneController : MonoBehaviour
{
    //Escena del juego.
    public void LoadGameScene()
    {
        SceneManager.LoadScene("GameScene");
    }
}