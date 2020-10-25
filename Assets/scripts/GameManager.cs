using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    public int listCount;
    public int maximumMap;
    public static int maximumMapSize;
    void Start()
    {
        maximumMapSize = maximumMap;
    }

    // Update is called once per frame
    void Update()
    {
        listCount = Pathmaker.fList.Count;
        print(listCount+",Global:"+Pathmaker.globalTileCount);
        while(listCount > maximumMapSize)
        {
            Pathmaker.fList.RemoveAt(listCount-1);
            Destroy(Pathmaker.fList[Pathmaker.fList.Count-1].gameObject);
            listCount -= 1;
            Pathmaker.globalTileCount -= 1;
        }
        
    }
}
