using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    public void GameScene()
    {
        SceneManager.LoadScene("Game", LoadSceneMode.Single);
    }


    public void GameOverScene()
    {
        SceneManager.LoadScene("GameOver", LoadSceneMode.Single);
    }

    public void TitleScene()
    {
        SceneManager.LoadScene("Title", LoadSceneMode.Single);
    }
}
