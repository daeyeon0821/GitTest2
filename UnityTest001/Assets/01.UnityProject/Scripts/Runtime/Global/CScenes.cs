using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public static partial class CScenes
{
    //! 현재 씬의 Root objects를 가져온다
    public static GameObject[] GetRootObjs()
    {
        Scene scene_ = CScenes.GetScene();
        return scene_.GetRootGameObjects();
    }       // GetRootObjs()

    //! 씬의 Root objects를 가져온다
    public static GameObject[] GetRootObjs(string sceneName)
    {
        Scene scene_ = CScenes.GetScene(sceneName);
        return scene_.GetRootGameObjects();
    }       // GetRootObjs()

    //! 현재 씬의 이름을 가져온다
    public static string GetSceneName()
    {
        return CScenes.GetScene().name;
    }       // GetSceneName()

    //! 현재 Scene을 가져온다
    public static Scene GetScene()
    {
        return SceneManager.GetActiveScene();
    }       // GetScene()

    //! Scene을 가져온다
    public static Scene GetScene(string sceneName)
    {
        return SceneManager.GetSceneByName(sceneName);
    }       // GetScene()
}       // class CScenes
