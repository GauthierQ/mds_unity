using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalDetector : MonoBehaviour
{

     public GameObject scoreBlue;
     public GameObject scoreOrange;
     private int scoreb = 0;
     private int scoreo = 0;

    void Start()
    {
        scoreBlue.SetActive(false);
        scoreOrange.SetActive(false);
    }    

     private void OnTriggerEnter2D(Collider2D other) {

        if (other.gameObject.CompareTag("orange")) {
            if(scoreb == 0) {
                scoreBlue.SetActive(true);
                scoreb = scoreb +1;
            } else{
                GameObject go = GameObject.Instantiate(scoreBlue);
                Transform target = Camera.main.transform;
                go.transform.parent = target;
                go.transform.position = new Vector3(scoreBlue.transform.position.x - scoreb, scoreBlue.transform.position.y, 10);
                scoreb = scoreb +1;
            }
           
     
        }
        if (other.gameObject.CompareTag("blue")) {
            if(scoreo == 0){
                scoreOrange.SetActive(true);
                 scoreo = scoreo +1;                
            }else{
                GameObject go = GameObject.Instantiate(scoreOrange);
                Transform target = Camera.main.transform;
                go.transform.parent = target;
                go.transform.position = new Vector3(scoreOrange.transform.position.x + scoreo, scoreOrange.transform.position.y, 10);
                 scoreo = scoreo +1;
            }
            
        }
    }
}
