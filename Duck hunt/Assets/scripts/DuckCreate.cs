using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DuckCreate : MonoBehaviour {
    private Vector3 start_pos = new Vector3(5, 5, 5);
    public GameObject duck;
    private float speed = 10f;
    private void Start()
    {
        
        GameObject dog = GameObject.Find("Dog");
        duck = GameObject.CreatePrimitive(PrimitiveType.Capsule);
        duck.transform.position = dog.GetComponent<DogControl>().target;
        duck.GetComponent<Collider>().isTrigger = false;
        
    }

    void OnCollisionEnter(Collision collision)
    {
        Destroy(duck);
    }

    void OnTriggerEnter(Collider other)
    {
        Destroy(duck);
    }
}
