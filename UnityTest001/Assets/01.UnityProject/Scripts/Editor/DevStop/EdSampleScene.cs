//using System.Collections;
//using System.Collections.Generic;
//using System.Linq;

//using UnityEngine;
//using UnityEditor;

//[InitializeOnLoad]
//public class EdSampleScene
//{
//    static Camera mainCamera = default;        //!< 에디터에서 초기화할 메인 카메라
//    static GameObject cameraObjs = default;

//    static EdSampleScene()
//    {
//        SceneInit();
//    }

//    private static void SceneInit()
//    {
//        GameObject[] rootObjs = CScenes.GetEditorRootObjs();
//        List<string> initObjs = new List<string>();

//        foreach (GameObject rootObj in rootObjs)
//        {
//            // 초기화가 필요한 오브젝트를 가려낸다
//            switch (rootObj.name)
//            {
//                case CDefine.INIT_ROOT_OBJ_NAME_CAMERA_OBJS:
//                    initObjs.Add(CDefine.INIT_ROOT_OBJ_NAME_CAMERA_OBJS);
//                    cameraObjs = rootObj;
//                    break;
//                case CDefine.INIT_ROOT_OBJ_NAME_UI_OBJS:
//                    initObjs.Add(CDefine.INIT_ROOT_OBJ_NAME_UI_OBJS);
//                    break;
//                case CDefine.INIT_ROOT_OBJ_NAME_CAMERA_MAIN:
//                    mainCamera = rootObj.GetComponent<Camera>();
//                    break;
//                default:
//                    /* Do nothing */
//                    break;
//            }       // switch
//        }       // loop

//        // { 샘플 씬을 생성한다
//        bool isInitSomething = false;
//        if(initObjs.Contains(CDefine.INIT_ROOT_OBJ_NAME_CAMERA_OBJS) == false &&
//            mainCamera != default)
//        {
//            InitCameraObjs();
//            isInitSomething = true;
//        }
//        //if(initObjs.Contains(CDefine.INIT_ROOT_OBJ_NAME_UI_OBJS) == false)
//        //{

//        //}
//        // } 샘플 씬을 생성한다






//        // 씬이 초기화 된 경우 저장하고 탈출한다
//        if(isInitSomething == true)
//        {
//            CScenes.SaveEditorScene();
//        }
//        return;   
//    }       // SceneInit()

//    //! 카메라 오브젝트를 생성한다
//    private static void InitCameraObjs()
//    {
//        // 카메라를 정리할 오브젝트를 생성한다
//        Debug.Log("카메라 오브젝트 생성");

//        cameraObjs = CObjs.CreateLocalObj(
//            CDefine.INIT_ROOT_OBJ_NAME_CAMERA_OBJS);

//        // 카메라 위치 이동해서 정리
//        mainCamera.transform.SetParent(cameraObjs.transform, false);
//        mainCamera.clearFlags = CameraClearFlags.SolidColor;
//        mainCamera.backgroundColor = Color.black;
//    }       // InitCameraObjs()
//}
