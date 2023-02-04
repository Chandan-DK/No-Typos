using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchToGameSceneScript : MonoBehaviour
{
    public void ChangeToGameScene()
    {
        SceneManager.LoadScene("GameScene");
    }
}
