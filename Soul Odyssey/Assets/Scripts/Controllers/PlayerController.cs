using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PlayerController", menuName = "InputController/PlayerController")]
public class PlayerController : InputController
{
    // private CameraFollowObject _cameraFollowObject;

    // [Header("Camera Stuff")]
    // [SerializeField] private GameObject _cameraFollowGo;

    // private void Start(){
    //     _cameraFollowObject = _cameraFollowGo.GetComponent<CameraFollowObject>();
    // }

    public override bool RetrieveJumpInput(){
        //Debug.Log("RetrieveJumpInput");
        //return Input.GetMouseButton(0);
        return Input.GetButtonDown("Jump");
    }

    public override float RetrieveMoveInput(){
        return Input.GetAxisRaw("Horizontal");
    }
}
