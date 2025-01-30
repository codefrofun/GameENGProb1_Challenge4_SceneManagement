using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{

    public GameObject circle;


    private void Update()
    {
        if (Input.GetKey(KeyCode.Alpha2))
        {
            LoadGamePlay();
        }

        if (Input.GetKey(KeyCode.Alpha1))
        {
            LoadMainMenu();
        }
    }

    void LoadGamePlay()
    {

        SceneManager.LoadScene(1);
        SceneManager.sceneLoaded += OnSceneLoaded;
        //GameObject spawner = GameObject.Find("SpawnPoint.Game");
        //circle.transform.position = spawner.transform.position;
    }

    void LoadMainMenu()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
        SceneManager.LoadScene(0);
        //GameObject spawner = GameObject.Find("SpawnPoint.Main");
        //circle.transform.position = spawner.transform.position;
    }

    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        Debug.Log("Scene" + scene.isLoaded + "is laoded.");
    }
}