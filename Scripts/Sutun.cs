using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sutun : MonoBehaviour
{
    //-3.7f - 2.8f -7 -9
    

    

    // Start is called before the first frame update
    void Start()
    {
        float rand = Random.Range(-8f, -5f);

        transform.position = new Vector3(2.8f, rand, transform.position.z);

    }

    // Update is called once per frame
    void Update()
    {
        if (kus.basla == 1)
        {
            if (transform.position.x <= -3.7f)
            {
                yonetici.skor++;

                Destroy(gameObject);
            }
            transform.Translate(-2.5f * Time.deltaTime, 0, 0);

        }
    }

}
