using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class kus : MonoBehaviour
{

    Rigidbody2D rigi;

    public static int basla;

    public float ziplama_hizi;

    // Start is called before the first frame update
    void Start()
    {
        
        rigi = GetComponent<Rigidbody2D>();
        rigi.gravityScale = 0;
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            basla = 1;

            rigi.gravityScale = 2;
            rigi.velocity = Vector2.up * ziplama_hizi;

            

        }
        

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        yonetici.skor = 0;
        basla = 0;
        SceneManager.LoadScene(0);
    }
}
