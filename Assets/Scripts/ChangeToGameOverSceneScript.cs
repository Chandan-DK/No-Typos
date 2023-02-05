using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeToGameOverSceneScript : MonoBehaviour
{
    public static void SwitchToGameOverScene()
    {
        SceneManager.LoadScene("GameOverScene");
    }
}
