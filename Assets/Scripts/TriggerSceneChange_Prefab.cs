using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggerSceneChange_Prefab : MonoBehaviour
{
    [SerializeField] private string sceneName;
    [SerializeField] private string spawnPointName;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            if (!string.IsNullOrEmpty(sceneName) && !string.IsNullOrEmpty(spawnPointName))
            {
                Debug.Log("Player entered trigger. Changing scene to: " + sceneName + " and spawn point: " + spawnPointName);

                if (GameSceneManager.instance != null)
                {
                    GameSceneManager.instance.ChangeScene(sceneName, spawnPointName);
                }
                else
                {
                    Debug.LogError("GameSceneManager instance is not found!");
                }
            }
        }
    }
}
