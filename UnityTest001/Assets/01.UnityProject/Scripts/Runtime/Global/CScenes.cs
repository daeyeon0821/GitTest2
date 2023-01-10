using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public static partial class CScenes
{
    //! ���� ���� Root objects�� �����´�
    public static GameObject[] GetRootObjs()
    {
        Scene scene_ = CScenes.GetScene();
        return scene_.GetRootGameObjects();
    }       // GetRootObjs()

    //! ���� Root objects�� �����´�
    public static GameObject[] GetRootObjs(string sceneName)
    {
        Scene scene_ = CScenes.GetScene(sceneName);
        return scene_.GetRootGameObjects();
    }       // GetRootObjs()

    //! ���� ���� �̸��� �����´�
    public static string GetSceneName()
    {
        return CScenes.GetScene().name;
    }       // GetSceneName()

    //! ���� Scene�� �����´�
    public static Scene GetScene()
    {
        return SceneManager.GetActiveScene();
    }       // GetScene()

    //! Scene�� �����´�
    public static Scene GetScene(string sceneName)
    {
        return SceneManager.GetSceneByName(sceneName);
    }       // GetScene()
}       // class CScenes
