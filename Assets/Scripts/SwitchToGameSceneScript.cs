using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchToGameSceneScript : MonoBehaviour
{
    public void SwitchToGameScene()
    {
        SceneManager.LoadScene("GameScene");
    }
}
