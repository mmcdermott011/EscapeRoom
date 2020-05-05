using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Winning_Script : MonoBehaviour
{
    [SerializeField] private Text Winner_Text;
    public GameObject Winner_audio;
    private int count;
    public GameObject Trigger;
    void Start()
    {
        count = 0;
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && count==0);
        {
            Winner_Text.text = "YOU ESCAPED";
            Instantiate(Winner_audio);
            count += 1;
            Destroy(Trigger);
        }
    }
}
