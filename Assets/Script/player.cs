using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public managerChannel fromChannel;
    public int channel_new;
    public int countBox;
    public int boxIng;
    private Rigidbody rb;
    public bool ready;

    //----------------------------------------------------------
    void Start() {
        rb = GetComponent<Rigidbody>();
    }
    void Update() {
        if(ready == true){
            run();
        }
    }

    public void enter_numberBox(int _inbex){
        if(_inbex > 0){
            countBox = _inbex;
            ready = true;
        }
        
    }

    public void run(){
        //-------------------------------------------
        if(transform.position != fromChannel.manager_channel[channel_new].channels.position){
            Vector3 box = Vector3.MoveTowards(transform.position,fromChannel.manager_channel[channel_new].channels.position,fromChannel.speed*Time.deltaTime);
            rb.MovePosition(box);
            // print("1");
        }
        //--------------------------------------------
        else{
            // print("2");
            channel_new = (channel_new + 1)% fromChannel.manager_channel.Count;
            if(countBox -1 > 0){
                countBox -=1;
                print("count: " + countBox);
            }
            else{
                ready = false;
                if(channel_new == 0){
                    boxIng = fromChannel.manager_channel.Count;
                }
                else{
                    boxIng = (channel_new -1);
                }
            }
        }
    }
}
