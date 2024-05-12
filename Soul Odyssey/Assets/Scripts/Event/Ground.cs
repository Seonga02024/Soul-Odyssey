using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground : MonoBehaviour
{
    private bool onGround;
    private float friction; // 마찰력

    private void OnCollisionEnter2D(Collision2D collision){
        EvaluateCollision(collision);
        RetireveFriction(collision);
    }

    private void OnCollisionStay2D(Collision2D collision){
        EvaluateCollision(collision);
        RetireveFriction(collision);
    }

    private void OnCollisionExit2D(Collision2D collision){
        onGround = false;
        friction = 0;
    }

    private void EvaluateCollision(Collision2D colllision){
        for(int i=0; i <colllision.contactCount; i++){
            Vector2 normal = colllision.GetContact(i).normal;
            onGround |= normal.y >= 0.9f;
        }
    }

    private void RetireveFriction(Collision2D collision){
        PhysicsMaterial2D material = collision.rigidbody.sharedMaterial;
        friction = 0;
        if(material != null){
            friction = material.friction;
        }
    }

    public bool GetOnGround(){
        return onGround;
    }

    public float GetFriction(){
        return friction;
    }
}
