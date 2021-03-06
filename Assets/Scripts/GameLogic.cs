using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLogic : MonoBehaviour
{
    public GameObject Ball;
    public GameObject Pins;
    void Start()
    {
        GameObject ball = Instantiate(Ball, new Vector3(0.718f, 0.529f, -3.87f), Quaternion.identity);
    }

    private void Update()
    {
        if(PinDetector.instance.oneDown==true)
        {
         //   CapsuleCollider.instance.bowled = false;
            StartCoroutine(Instantiation());
        }
    }

    IEnumerator Instantiation()
    {
        yield return new WaitForSeconds(7f);
        GameObject ball = Instantiate(Ball, new Vector3(0.718f, 0.529f, -3.87f), Quaternion.identity);
        GameObject pins = Instantiate(Pins, new Vector3(0, 0, 0), Quaternion.identity);
        
    }
}
