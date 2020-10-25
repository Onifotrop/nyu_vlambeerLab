using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cam : MonoBehaviour
{
    // Start is called before the first frame update
    public float rotateSpeed;
    public float xOffset;
    public float yOffset;
    public float zOffset;
    void Start()
    {
        //this.transform.position = new Vector3(Pathmaker.xPos/Pathmaker.fList.Count,Pathmaker.yPos/Pathmaker.fList.Count,-360);
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = new Vector3(Pathmaker.xPos/Pathmaker.fList.Count + xOffset,Pathmaker.yPos/Pathmaker.fList.Count + yOffset,Pathmaker.zPos/Pathmaker.fList.Count + zOffset);
        this.transform.Rotate(0,rotateSpeed * Time.deltaTime,0);
    }
}
