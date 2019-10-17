using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //Make sure to add this for access to the SceneManagment class.


public class collisionTester : MonoBehaviour
{
    public GameObject check;


    //Any Collider2D component will call this function on
    //any attached scripts when the collider enters a collision with another collider.
    //The gameobject must also have a RigidBody2D attached.
    private void OnCollisionEnter2D(Collision2D collision)
    {
     


        if (collision.collider.gameObject == check)
        {
            SceneManager.LoadScene(2);
        }
    }


}


