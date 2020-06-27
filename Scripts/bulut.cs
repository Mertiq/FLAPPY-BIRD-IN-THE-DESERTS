using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulut : MonoBehaviour
{
    //-3.5f basa al 3.5f
    // 4.5- 0 yükselkik

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (kus.basla == 1)
        {
            if (transform.position.x <= -3.5f)
            {
            
                float y = Random.Range(0.0f, 4.5f);
                transform.position = new Vector3(3.5f, y, transform.position.z);    
            }
            

            transform.Translate(-0.009f , 0, 0);

        }

    }
}
