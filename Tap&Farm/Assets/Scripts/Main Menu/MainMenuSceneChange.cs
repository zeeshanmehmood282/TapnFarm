using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenuSceneChange : MonoBehaviour
{
    // Start is called before the first frame update

    public string sceneToLoad;
    public void scenechange()
    {
        SceneManager.LoadScene(sceneToLoad);
    }

    public void CloseGame()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
}
