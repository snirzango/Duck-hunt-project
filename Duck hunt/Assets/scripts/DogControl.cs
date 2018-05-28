using System;
using System.Collections;
using UnityEngine;

public class DogControl : MonoBehaviour{
    private float speed;
    public Vector3 target;
    private Vector3 start_pos = new Vector3(0, 0, 0);
    bool ducks_flyed = false;
    void Start()
    {
        speed = 10;
    }


    void Update()
    {
        float step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, target, step);
        if (target.Equals(transform.position) && !ducks_flyed && transform.position != start_pos) 
        {
            ducks_flyed = true;
            fly_ducks(target);//target means the postion where the ducks started to fly
        }
     

    }

    private void fly_ducks(Vector3 target)
    {
        throw new NotImplementedException();
    }
}