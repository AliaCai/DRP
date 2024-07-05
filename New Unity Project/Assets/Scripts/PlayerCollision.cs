using UnityEngine;

public class PlayerCollision : MonoBehaviour{
    
    public PlayerMovement movement;

    void OnCollisionEnter(Collision colliisonInfo){//need to speell it right! //called when collide -> object need to have collider and regit body

       if (colliisonInfo.collider.tag == "Obstacle"){ //tag need to be set in unity
        Debug.Log("we hit ab obstacle");

        movement.enabled = false;
       }
    }
}
