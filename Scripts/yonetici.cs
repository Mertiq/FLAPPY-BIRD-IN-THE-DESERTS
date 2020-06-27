using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class yonetici : MonoBehaviour
{
    public GameObject boru;

    public static int skor = 0;

    public Text skott;

    // Start is called before the first frame update
    void Start()
    {
        
        InvokeRepeating("borus", 0f, 1.0f);
        
        
        skott.text = skor.ToString();
    }

    private void Update()
    {
        skott.text = skor.ToString();
    }


    void borus()
    {
        if(kus.basla == 1)
        {
            GameObject yeni = Instantiate(boru);
        }
       
    }
}
