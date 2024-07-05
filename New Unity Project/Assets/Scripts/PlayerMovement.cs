using UnityEngine;

public class PlayerMovement : MonoBehaviour
{


    public Rigidbody rb;//toggle the rigitbody here
    public float forwardForce = 2000f; // f means that I am  only talking about float
    public float sidewaysForce = 500f;

    // Start is called before the first frame update
    void Start(){//run when the game starts, there can be many spaces

        //Debug.Log("Hello, world");//like print lol

        //rb.useGravity=false;

        //rb.AddForce(0, 200, 500);  //forcee in x, y, z
        
    }



    // Update is called once per frame -> different computer's and situtations frame is different -> Time.deltaTime cancel out with probelm with Update
    // FixedUpdate us better to caluclate physics
    void FixedUpdate() {

        //Add a forward force
        rb.AddForce(0,0,forwardForce * Time.deltaTime);//same in all system

        if (Input.GetKey("d")) //input use update so it may untoned with fixUpdate sometimes -> not worry now
        {
            rb.AddForce(sidewaysForce*Time.deltaTime,0,0, ForceMode.VelocityChange);//forceparmeter ->which way to add force -> velocity change: repsonsibe to go left and right

            //drag: air resistance-> the higher the drag the more quickly our object is going to stop by air
        }

       if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce*Time.deltaTime,0,0, ForceMode.VelocityChange);
        }
        
    }
}
