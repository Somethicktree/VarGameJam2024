using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene_Manager : MonoBehaviour
{
    private string currentScene = "";

    private static Scene_Manager instance;
    public static Scene_Manager Instance
    { get { return instance; } }

    // Start is called before the first frame update
    void Start()
    {
        instance = this;

        //Keeps track of the current scene that is running;
        currentScene = SceneManager.GetActiveScene().name;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            LoadNewScene("Main_Level");
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            ReloadCurrentScene();
        }
    }

    public void LoadNewScene(string TargetScene)
    {
        currentScene = TargetScene;
        SceneManager.LoadScene(TargetScene);
    }

    public void ReloadCurrentScene()
    {
        SceneManager.LoadScene(currentScene);
    }
}
