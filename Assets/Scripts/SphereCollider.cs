using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class SphereCollider : MonoBehaviour
{
    public static SphereCollider instance;
    public bool bowled;
    int count;
    static int scoring;
    TextMeshProUGUI score;
    private void Awake()
    {
        instance = this;
    }
    private void Start()
    {
        score = GameObject.Find("Score").GetComponent<TextMeshProUGUI>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Pin"))
        {
            if (count == 0)
            {
                bowled = true;
                count++;
                
            }
            scoring++;
            Destroy(gameObject, 3f);
            Destroy(collision.gameObject.transform.parent.gameObject, 5f);
            score.text = scoring.ToString();
        }
    }

}
