//using System.Collections;
//using System.Collections.Generic;
//using System.Linq;

//using UnityEngine;
//using UnityEditor;

//[InitializeOnLoad]
//public class EdSampleScene
//{
//    static Camera mainCamera = default;        //!< �����Ϳ��� �ʱ�ȭ�� ���� ī�޶�
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
//            // �ʱ�ȭ�� �ʿ��� ������Ʈ�� ��������
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

//        // { ���� ���� �����Ѵ�
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
//        // } ���� ���� �����Ѵ�






//        // ���� �ʱ�ȭ �� ��� �����ϰ� Ż���Ѵ�
//        if(isInitSomething == true)
//        {
//            CScenes.SaveEditorScene();
//        }
//        return;   
//    }       // SceneInit()

//    //! ī�޶� ������Ʈ�� �����Ѵ�
//    private static void InitCameraObjs()
//    {
//        // ī�޶� ������ ������Ʈ�� �����Ѵ�
//        Debug.Log("ī�޶� ������Ʈ ����");

//        cameraObjs = CObjs.CreateLocalObj(
//            CDefine.INIT_ROOT_OBJ_NAME_CAMERA_OBJS);

//        // ī�޶� ��ġ �̵��ؼ� ����
//        mainCamera.transform.SetParent(cameraObjs.transform, false);
//        mainCamera.clearFlags = CameraClearFlags.SolidColor;
//        mainCamera.backgroundColor = Color.black;
//    }       // InitCameraObjs()
//}
