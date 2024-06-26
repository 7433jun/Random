using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class JsonExample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

[System.Serializable]
public class JTestClass
{
    public int i;
    public float f;
    public bool b;
    public Vector3 v;
    public string str;
    public int[] iArray;
    public List<int> iList = new List<int>();

    public JTestClass() { }

    public JTestClass(bool isSet)
    {
        if (isSet)
        {
            i = 10;
            f = 99.9f;
            b = true;
            v = new Vector3(39.56f, 21.2f, 6.4f);
            str = "JSON Test String";
            iArray = new int[] { 1, 1, 3, 5, 8, 13, 21, 34, 55 };
            for (int idx = 0; idx < 5; idx ++)
            {
                iList.Add(2 * idx);
            }
        }
    }

    public void Print()
    {
        Debug.Log("i = " + i);
        Debug.Log("f = " + f);
        Debug.Log("b = " + b);
        Debug.Log("v = " + v);
        Debug.Log("str = " + str);

        for (int idx = 0; idx < iArray.Length; idx++)
        {
            Debug.Log(string.Format("iArray[{0}] = {1}", idx, iArray[idx]));
        }

        for (int idx = 0; idx < iList.Count; idx++)
        {
            
        }
    }
}