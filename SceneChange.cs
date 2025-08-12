using UnityEditor.SceneManagement;
using UnityEngine;

public class SceneChange : MonoBehaviour
{
    public string sceneName;

    void OnTriggerEnter(Collider other)
    {
        EditorSceneManager.LoadScene(sceneName);
    }
}
