using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor.SceneManagement;

public static partial class CScenes
{
    //! ���� ���� Root objects�� �����´�
    public static GameObject[] GetEditorRootObjs()
    {
        Scene scene_ = CScenes.GetEditorScene();
        return scene_.GetRootGameObjects();
    }       // GetRootObjs()

    //! ���� Root objects�� �����´�
    public static GameObject[] GetEditorRootObjs(string sceneName)
    {
        Scene scene_ = CScenes.GetEditorScene(sceneName);
        return scene_.GetRootGameObjects();
    }       // GetRootObjs()

    //! ���� ���� �̸��� �����´�
    public static string GetEditorSceneName()
    {
        return CScenes.GetEditorScene().name;
    }       // GetSceneName()

    //! ���� Scene�� �����´�
    public static Scene GetEditorScene()
    {
        return EditorSceneManager.GetActiveScene();
    }       // GetScene()

    //! Scene�� �����´�
    public static Scene GetEditorScene(string sceneName)
    {
        return EditorSceneManager.GetSceneByName(sceneName);
    }       // GetScene()

    //! ���� ���� �����Ѵ�
    public static bool SaveEditorScene()
    {
        return EditorSceneManager.SaveScene(
            CScenes.GetEditorScene());
    }       // SaveCurrentScene()
}
