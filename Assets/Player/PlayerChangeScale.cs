using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerChangeScale : MonoBehaviour
{
    private GameObject player;
    // taille général // 


    private Vector3 scaleChange;
    // changer la taille en X
    private Vector3 scalechangeX;
    private Vector3 scalechangeY;

    // Set taille (1:1:1) 
    private Vector3 resetScale ;

    void Start()
    {
        // general // 
        scaleChange = new Vector3(1f, 1f, 1f);

        // base scale // 
        resetScale = new Vector3(1f, 1f, 1f);
    }

    void Update()
    {

        //Get bigger height // 
        if (Input.GetKey(KeyCode.UpArrow) )
        {
            scaleChange.y += 0.01f;
            this.transform.localScale = scaleChange;
        }
        //Get smaller height // 
        if (Input.GetKey(KeyCode.DownArrow))
        {
            scaleChange.y -= 0.01f;
            this.transform.localScale = scaleChange;
            // this.transform.localScale = this.transform.localScale - scaleChange;
        }


        //Get bigger width // 
        if (Input.GetKey(KeyCode.RightArrow))
        {
            scaleChange.x += 0.01f;
            this.transform.localScale = scaleChange;
            //this.transform.localScale = this.transform.localScale + scaleChange;
        }
        //Get smaller width // 
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            scaleChange.x -= 0.01f;
            this.transform.localScale = scaleChange;
            //this.transform.localScale = this.transform.localScale - scaleChange;
        }
        if(Input.GetKey("space"))
        {
            this.transform.localScale = resetScale;
        }
        Debug.Log(scaleChange);

        if (Input.GetKey("escape"))
        {
            SceneManager.LoadScene("MainMenu");
        }
    }   
}