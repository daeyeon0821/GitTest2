using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class CObjs
{
    //! 새로운 오브젝트를 생성한다
    public static GameObject CreateLocalObj(string objName)
    {
        return CObjs.CreateLocalObj(objName, null, Vector3.zero);
    }       // CreateLocalObj()

    //! 새로운 오브젝트를 생성한다
    public static T CreateLocalObj<T>(string objName,
        GameObject objParent, Vector3 objPos) where T : Component
    {
        GameObject obj_ = CObjs.CreateLocalObj(objName, objParent, objPos);
        return obj_.AddComponent<T>();
    }       // CreateLocalObj()

    //! 새로운 오브젝트를 생성한다
    public static GameObject CreateLocalObj(string objName, 
        GameObject objParent, Vector3 objPos)
    {
        // Create new obj
        GameObject obj_ = new GameObject(objName);
        obj_.transform.localPosition = objPos;

        // 부모가 존재할 경우
        if(objParent == default || objParent == null) { /* Do nothing */ }
        else
        {
            obj_.transform.SetParent(objParent.transform, false);
        }

        return obj_;
    }       // CreateLocalObj()
}
