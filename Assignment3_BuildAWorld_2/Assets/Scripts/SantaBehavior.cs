using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SantaBehavior : MonoBehaviour
{

private int positionX=0;
private int positionZ=0;

    // Start is called before the first frame update
    void Start()
    {
    positionX= Random.Range(-475,-809);
    positionZ=Random.Range(-82,-237);
    
    transform.position=new Vector3(positionX,486,positionZ);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
