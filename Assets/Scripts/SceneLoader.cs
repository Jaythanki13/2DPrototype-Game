using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    //This is to Access from Inside Inspector Window of the Unity Editor
    public void LoadGame()
    {
        //We are Increasing level by One from Original Scene whichever is active currently
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quit!!");
    }
}
