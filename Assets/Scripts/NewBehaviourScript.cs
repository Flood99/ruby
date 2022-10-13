using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public int spd = 3;
    float Horizontal;
    float Vertical;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        Horizontal = Input.GetAxis("Horizontal");
        Vertical = Input.GetAxis("Vertical");
        transform.Translate(new Vector3(Horizontal * spd * Time.deltaTime,Vertical*spd*Time.deltaTime,0));
    }
}
