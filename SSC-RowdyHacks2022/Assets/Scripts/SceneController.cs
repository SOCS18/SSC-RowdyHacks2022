using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadMainGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void QuitGameButton()
    {
        // if user is in the unity editor, scene stops playing
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
        // if user is playing the game, application will quit
#else
        Application.Quit();
#endif
    }
}
