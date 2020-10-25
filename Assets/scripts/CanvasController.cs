using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CanvasController : MonoBehaviour
{
    // Start is called before the first frame update
    public Slider thisSlider;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //print(Pathmaker.verDelta);   
    }

    public void Restart()
    {
        SceneManager.LoadScene("mainLabScene");
        Pathmaker.globalTileCount = 0;
        Pathmaker.xPos = 0;
        Pathmaker.yPos = 0;
        Pathmaker.zPos = 0;
        //Restart();
    }

    public void changeVerticalDelta()
    {
        //thisSlider.value = Pathmaker.verDelta;
    }
}
