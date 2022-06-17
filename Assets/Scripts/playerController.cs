using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//the details about the ui tool set is held in this namespace

//declaring rb of type rigidbody


public class playerController : MonoBehaviour
{
    //to make it editable in the inspector use public variables
    public float speed;
    //this variable hold reference to the ui text component
    public Text countText;
    public Text winText;
    private Rigidbody rb;
    private int count;
    void Start()
    {
        // a reference to the attached rigid body
        rb = GetComponent<Rigidbody>();
        count = 0;
        setCountText();
        winText.text = "";

    }
    void FixedUpdate()
    {
        float moveHorizotal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(moveHorizotal, 0.0f, moveVertical);
        rb.AddForce(movement*speed);
    }
    //this function will be called everytime the attache object touch another abject.......
    //the "other" is the another captured gameobject
     void OnTriggerEnter(Collider other)
    {
        //compare tag sees if the tags of the collided and the string is the same
        if (other.gameObject.CompareTag("pickup"))
        {
            //sets the gameobject true or false
            //we shall set the objects on triggers
            other.gameObject.SetActive(false);
            count += 1;
            setCountText();


        }
        
    }
    void setCountText()
    {
        countText.text = "count: " + count.ToString();
        if (count >= 12)
        {
            winText.text = "You Win!";
        }
    }
}
