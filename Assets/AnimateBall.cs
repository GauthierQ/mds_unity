using System;
using UnityEngine;
using System.Collections;

public class AnimateBall : MonoBehaviour
{

    public float speed = 0.2f;
    private DateTime newDir = DateTime.Now;
    private Vector3 dir = Vector3.right;
    public GameObject sparkle;


   
    void Update()
    {


        if (newDir < DateTime.Now)
        {
            dir = new Vector3(UnityEngine.Random.Range(-1f, 1f), UnityEngine.Random.Range(-1f, 1f), 0).normalized;
            newDir = DateTime.Now.AddSeconds(1);
        }

        transform.position = transform.position + dir * (speed * Time.deltaTime);
        transform.localEulerAngles = new Vector3(0, 0, Mathf.Rad2Deg * Mathf.Atan2(dir.y, dir.x));
    }

    private void OnCollisionEnter2D(Collision2D other){
       Instantiate(sparkle, (Vector3) other.contacts[0].point, Quaternion.identity);
    }
    
}
