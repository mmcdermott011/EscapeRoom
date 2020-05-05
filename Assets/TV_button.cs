using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TV_button : MonoBehaviour
{
    private int count;
    public GameObject TV_text;
    public GameObject TV_audio;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
  
    }

public void Activate(){
  	Instantiate(TV_text);
        //yield return new WaitForSeconds(2);
        Instantiate(TV_audio);

}

   
}

