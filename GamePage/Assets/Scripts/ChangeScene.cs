using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public int x;
    public void NextScene()
    {
        SceneManager.LoadScene(x);

    }
    public void MarketPlace()
    {
        Application.OpenURL("https://sarthakrawal.my.canva.site/demosite");
    }
    public void ExitGame()
    {
        Application.Quit();
    }


}
