using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneManagement : MonoBehaviour
{
    public void LoadMarket(){
        SceneManager.LoadScene(1);
    }

    public void LoadVillage(){
        SceneManager.LoadScene(0);
    }
}
