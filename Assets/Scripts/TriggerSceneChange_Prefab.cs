using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggerSceneChange_Prefab : MonoBehaviour
{
    public string sceneName;
    public string spawnPointName;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            GameSceneManager.instance.ChangeScene(sceneName, spawnPointName);
        }
    }
}
