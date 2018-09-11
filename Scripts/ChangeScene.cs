using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour {

    private void Start()
    {
        
    }
    public void ChangeSceneTo(int sceneNumber)
    {
        SceneManager.LoadScene(sceneBuildIndex: sceneNumber);
    }

}
