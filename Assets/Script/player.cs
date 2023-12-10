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

    public void run()
    {
    //     float threshold = 0.1f; // Adjust the threshold value as needed
    //      if (Vector3.Distance(transform.position, fromChannel.manager_channel[channel_new].channels.position) > threshold)
    // {
    //     Vector3 targetPosition = fromChannel.manager_channel[channel_new].channels.position;
    //     Vector3 newPosition = Vector3.MoveTowards(transform.position, targetPosition, fromChannel.speed * Time.deltaTime);
    //     rb.MovePosition(newPosition);
    //     Debug.Log("Moving to channel " + channel_new);

        if(transform.position != fromChannel.manager_channel[channel_new].channels.position){
            Vector3 box = Vector3.MoveTowards(transform.position,fromChannel.manager_channel[channel_new].channels.position,fromChannel.speed*Time.deltaTime);
            rb.MovePosition(box);
            print("1");
        }
        else{
            print("2");
            // Debug.Log("Arrived at channel " + channel_new);
            channel_new = (channel_new + 1)% fromChannel.manager_channel.Count;
        }
    }
}
