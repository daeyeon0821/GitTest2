using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor.SceneManagement;

public static partial class CScenes
{
    //! 현재 씬의 Root objects를 가져온다
    public static GameObject[] GetEditorRootObjs()
    {
        Scene scene_ = CScenes.GetEditorScene();
        return scene_.GetRootGameObjects();
    }       // GetRootObjs()

    //! 씬의 Root objects를 가져온다
    public static GameObject[] GetEditorRootObjs(string sceneName)
    {
        Scene scene_ = CScenes.GetEditorScene(sceneName);
        return scene_.GetRootGameObjects();
    }       // GetRootObjs()

    //! 현재 씬의 이름을 가져온다
    public static string GetEditorSceneName()
    {
        return CScenes.GetEditorScene().name;
    }       // GetSceneName()

    //! 현재 Scene을 가져온다
    public static Scene GetEditorScene()
    {
        return EditorSceneManager.GetActiveScene();
    }       // GetScene()

    //! Scene을 가져온다
    public static Scene GetEditorScene(string sceneName)
    {
        return EditorSceneManager.GetSceneByName(sceneName);
    }       // GetScene()

    //! 현재 씬을 저장한다
    public static bool SaveEditorScene()
    {
        return EditorSceneManager.SaveScene(
            CScenes.GetEditorScene());
    }       // SaveCurrentScene()
}
