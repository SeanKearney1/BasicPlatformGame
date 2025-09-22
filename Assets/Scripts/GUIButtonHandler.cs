using UnityEngine;
using UnityEngine.SceneManagement;
public class GUIButtonHandler : MonoBehaviour
{
    public GameObject menu;
    private bool sceneLoaded = false;
    private bool gamePaused = false;

    public void Update()
    {
        showPauseMenu();
    }


    public void loadGame()
    {
        DontDestroyOnLoad(this.gameObject);
        menu.SetActive(false);
        SceneManager.LoadScene("SampleScene");
        sceneLoaded = true;
    }

    public void exitGame()
    {
        Application.Quit();
    }

    private void showPauseMenu()
    {
        if (Input.GetKeyDown(KeyCode.P) && sceneLoaded == true) {
            if (!gamePaused)
            {
                menu.SetActive(true);
                Time.timeScale = 0.0f;
                gamePaused = true;
            }
            else
            {
                menu.SetActive(false);
                Time.timeScale = 1.0f;
                gamePaused = false;
            }
        } 
    }
}
