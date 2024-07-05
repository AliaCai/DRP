using UnityEngine;

// so camera does not rotate the the object
public class FollowPlayer : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;//vector3 store 3 floats -> easy for position

    // Update is called once per frame
    void Update(){

        transform.position = player.position + offset; //this transform refers to the transform of the current object
    }
}
