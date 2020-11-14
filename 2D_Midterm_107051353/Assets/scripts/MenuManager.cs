
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
  public void  StartGame()
    {
        print("Start");
        SceneManager.LoadScene(1);
    }
   public void QuitGame()
    {
        print("Quit");
        Application.Quit();
    }
}
