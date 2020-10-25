using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Floordelete : MonoBehaviour
{
    public Material matOne;
    public Material matTwo;
    public Material matThree;

    public int randomInt;
    // Start is called before the first frame update
    void Start()
    {
        randomInt = (int) (Random.Range(0, 3));
        print("random int is"+randomInt);
        if (randomInt == 0)
        {
            this.GetComponent<MeshRenderer>().material = matOne;
        }
        else if (randomInt == 1)
        {
            this.GetComponent<MeshRenderer>().material = matTwo;
        }
        else if (randomInt == 2)
        {
            this.GetComponent<MeshRenderer>().material = matThree;
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
