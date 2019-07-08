using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerr : MonoBehaviour
{
    public Rigidbody p;
    private float a;
    public float horizspeed = 100f;
    public spawner Spawn;
    public float movspeed = 10f;
    // Update is called once per frame
    //void Start(){Spawn.StartCoroutine("spawn");}
    void Update()
    {
        a = Input.GetAxisRaw("Horizontal");
        if(!(a<0 && transform.position.x< -10f) && !(a>0 && transform.position.x> 10f)) transform.Translate(Vector3.right * a * horizspeed * Time.deltaTime );
        //transform.Translate(Vector3.right * -a * horizspeed * Time.deltaTime );
        
        //transform.Translate(Vector3.right * -a * horizspeed * Time.deltaTime ); 
        

    }
    void OnTriggerEnter(Collider collider){
        if(collider.tag=="block"){
        p.isKinematic = true;
        p.isKinematic = false;
        p.AddForce(Vector3.up*500f);
        
        }
        else if(collider.tag=="bigbloack"){
            p.AddForce(Vector3.up*10000f);
        }
    }
}
