using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuddyManager : MonoBehaviour
{
    public float buddyPingPong;
    public float PingPongThreshold;
    private Animation anim;
    
    private Vector3 buddypos;

    public Transform Player;
    public Transform followPos;

    public float buddytraverseTime;

    public ThirdPersonController controller;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animation>();

       

    }

    private void LateUpdate()
    {
        Debug.Log(controller.MoveSpeed);
        if(controller.MoveSpeed < 0.4f)
        {
            anim.CrossFade("Wizard_Run");
        }
        if(controller.MoveSpeed >= 0.4)
        {
            anim.CrossFade("Wizard_Idle");
        }

        Vector3 toTarget = followPos.transform.position - transform.position;
        
        float speed = 1.5f;

        transform.Translate(toTarget * buddytraverseTime * Time.deltaTime);

        //transform.rotation = Player.transform.rotation;
        transform.forward = Vector3.forward+ Player.transform.forward;
        //transform.LookAt(Player);

    }
    

      

    

    /*
    // Update is called once per frame
    void LateUpdate()
    {
        restpos = followPos.position;
        buddypos = gameObject.transform.position;
        
        
        gameObject.transform.position = Vector3.Lerp(buddypos, restpos, buddytraverseTime);
       
        
    }
    */
    /*
    void Example()
    {
        float vertical = Mathf.PingPong(buddyPingPong, PingPongThreshold);
        buddypos.y = followPos.transform.position.y;
        buddypos = new Vector3(followPos.transform.position.x, 0, followPos.transform.position.z);

        transform.position = new Vector3(0, vertical, 0) + buddypos;
        gameObject.transform.forward = Player.transform.forward;
    }
    */
}
