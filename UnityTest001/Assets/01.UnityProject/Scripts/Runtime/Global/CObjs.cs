using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class CObjs
{
    //! ���ο� ������Ʈ�� �����Ѵ�
    public static GameObject CreateLocalObj(string objName)
    {
        return CObjs.CreateLocalObj(objName, null, Vector3.zero);
    }       // CreateLocalObj()

    //! ���ο� ������Ʈ�� �����Ѵ�
    public static T CreateLocalObj<T>(string objName,
        GameObject objParent, Vector3 objPos) where T : Component
    {
        GameObject obj_ = CObjs.CreateLocalObj(objName, objParent, objPos);
        return obj_.AddComponent<T>();
    }       // CreateLocalObj()

    //! ���ο� ������Ʈ�� �����Ѵ�
    public static GameObject CreateLocalObj(string objName, 
        GameObject objParent, Vector3 objPos)
    {
        // Create new obj
        GameObject obj_ = new GameObject(objName);
        obj_.transform.localPosition = objPos;

        // �θ� ������ ���
        if(objParent == default || objParent == null) { /* Do nothing */ }
        else
        {
            obj_.transform.SetParent(objParent.transform, false);
        }

        return obj_;
    }       // CreateLocalObj()
}
