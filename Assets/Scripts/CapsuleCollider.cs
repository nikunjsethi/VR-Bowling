using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CapsuleCollider : MonoBehaviour
{
    public static CapsuleCollider instance;
    private static int scoring;
    TextMeshProUGUI score;
    public bool bowled;
    private void Awake()
    {
        instance = this;
    }
    private void Start()
    {
        score= GameObject.Find("Score").GetComponent<TextMeshProUGUI>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            scoring++;
            bowled = true;
            Destroy(gameObject.GetComponent<BoxCollider>());
            score.text = scoring.ToString();
            Debug.Log("Scored");
        }
    }
}
