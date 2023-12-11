using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public managerChannel fromChannel;
    public int channel_new;
    private Rigidbody rb;
    void Start() {
        rb = GetComponent<Rigidbody>();
    }
    void Update() {
        run();
    }

    public void run(){
        //-------------------------------------------
        if(transform.position != fromChannel.manager_channel[channel_new].channels.position){
            Vector3 box = Vector3.MoveTowards(transform.position,fromChannel.manager_channel[channel_new].channels.position,fromChannel.speed*Time.deltaTime);
            rb.MovePosition(box);
            print("1");
        }
        //--------------------------------------------
        else{
            print("2");
            channel_new = (channel_new + 1) % fromChannel.manager_channel.Count;
        }
    }
}
