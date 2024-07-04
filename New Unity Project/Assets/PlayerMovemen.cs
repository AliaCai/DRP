using UnityEngine;

public class PlayerMovemen : MonoBehaviour
{


    public Rigidbody rb;//toggle the rigitbody here

    // Start is called before the first frame update
    void Start(){//run when the game starts, there can be many spaces

        //Debug.Log("Hello, world");//like print lol

        //rb.useGravity=false;

        //rb.AddForce(0, 200, 500);  //forcee in x, y, z
        
    }



    // Update is called once per frame -> different computer's and situtations frame is different -> Time.deltaTime cancel out with probelm with Update
    // FixedUpdate us better to caluclate physics
    void FixedUpdate() {

        rb.AddForce(0,0,2000 * Time.deltaTime);//same in all system
        
    }
}
