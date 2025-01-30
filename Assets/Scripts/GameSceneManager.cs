using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSceneManager : MonoBehaviour
{
    public static GameSceneManager instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // This will be used to transition between scenes
    public void ChangeScene(string sceneName, string spawnPointName)
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName);

        GameObject spawnPoint = GameObject.Find(spawnPointName);

        if (spawnPoint != null)
        {
            PlayerMovement.instance.transform.position = spawnPoint.transform.position;
        }
    }
}
