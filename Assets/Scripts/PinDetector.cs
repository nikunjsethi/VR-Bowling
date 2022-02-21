using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class PinDetector : MonoBehaviour
{
    public static PinDetector instance;
    private static int scoring;
    TextMeshProUGUI score;
    public bool oneDown;                                           //when the first pin touches the ground
    public GameObject Ball;
    public GameObject Pins;

    private void Awake()
    {
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        GameObject ball = Instantiate(Ball, new Vector3(0.718f, 0.529f, -3.87f), Quaternion.identity);
        score = GameObject.Find("Score").GetComponent<TextMeshProUGUI>();
        scoring = 0;
        score.text = scoring.ToString();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Pin"))
        {
            scoring++;
            score.text = scoring.ToString();
            Destroy(other.GetComponent<BoxCollider>());
            if(oneDown==false)  
            {
                oneDown = true;
                Destroy(GameObject.FindGameObjectWithTag("Player"),3);
                Destroy(other.gameObject.transform.parent.gameObject,5);
                StartCoroutine(Instantiation());
            }
        }
    }

    IEnumerator Instantiation()
    {
        yield return new WaitForSeconds(7f);
        GameObject ball = Instantiate(Ball, new Vector3(0.718f, 0.529f, -3.87f), Quaternion.identity);
        GameObject pins = Instantiate(Pins, new Vector3(0, 0, 0), Quaternion.identity);
        scoring = 0;
        score.text = 0.ToString();
        oneDown = false;
    }
}
