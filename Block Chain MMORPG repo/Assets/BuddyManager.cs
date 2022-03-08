using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuddyManager : MonoBehaviour
{
    private Vector3 restpos;
    private Vector3 buddypos;

    public Transform Player;
    public Transform followPos;

    public float buddytraverseTime;

    // Start is called before the first frame update
    void Start()
    {

       

    }

    // Update is called once per frame
    void LateUpdate()
    {
        restpos = followPos.position;
        buddypos = gameObject.transform.position;
        
        
        gameObject.transform.position = Vector3.Lerp(buddypos, restpos, buddytraverseTime);
        gameObject.transform.forward = Player.transform.forward;
        
        
    }
}
