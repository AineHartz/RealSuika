using UnityEngine;

public class PlayButton : MonoBehaviour
{
    public void gotoGame()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("gameplay");
    }
}