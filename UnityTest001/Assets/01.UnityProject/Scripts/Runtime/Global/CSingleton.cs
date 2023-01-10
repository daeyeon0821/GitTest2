using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CSingleton<T> : CComponent where T : CSingleton<T>
{
    private static T instance = default;

    public static T Instance    //!< 싱글턴 인스턴스를 생성해서 DontDestroyOnLoad Obj 하위에 정렬한다
    {
        get
        {
            if( CSingleton<T>.instance == default || instance == null)
            {
                CSingleton<T>.instance = CObjs.CreateLocalObj<T>(
                    typeof(T).ToString(), null, Vector3.zero);
                DontDestroyOnLoad(instance.gameObject);
            }
            else { /* Do nothing */ }
            return CSingleton<T>.instance;
        }
    }

    #region Public Methods
    public static T Create()
    {
        return CSingleton<T>.Instance;
    }
    #endregion      // Public Method

    // Start is called before the first frame update
    public virtual void Start()
    {

    }

    // Update is called once per frame
    public virtual void Update()
    {

    }
}       // class CSingleton
