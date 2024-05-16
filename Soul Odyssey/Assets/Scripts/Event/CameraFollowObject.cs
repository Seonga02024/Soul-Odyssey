using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowObject : MonoBehaviour
{
    // [Header("References")]
    // [SerializeField] private Transform _playerTransform;

    // [Header("Flip Rotation Stats")]
    // [SerializeField] private float _flipYRotationTime = 0.5f;

    // private Coroutine _turnCoroutine;
    // private Player _player;
    // private bool _isFacingRight;

    // private void Awake(){
    //     _player = _playerTransform.gameObject.GetComponent<Player>();
    //     _isFacingRight = _player.IsFacingRight;
    // }

    // private void Update(){
    //     transform.position = _playerTransform.position;
    // }

    // public void CallTrun(){
    //     _turnCoroutine = StartCoroutine(FlipLerp());
    // }

    // private IEnumerator FlipLerp(){
    //     float startRotation = transform.localEulerAngles.y;
    //     float endRotationAmount = DeterminEndRotation();
    //     float yRotation = 0f;

    //     float elapsedTime = 0f;
    //     while(elapsedTime < _flipYRotationTime){
    //         elapsedTime += Time.deltaTime;
    //         yRotation = Mathf.Lerp(startRotation, endRotationAmount, (elapsedTime / _flipYRotationTime));
    //         transform.rotation = Quaternion.Lerp(0f, yRotation,0f);

    //         yield return null;
    //     }
    // }

    // private float DeterminEndRotation(){
    //     _isFacingRight = !_isFacingRight;
    //     if(_isFacingRight){
    //         return 180f;
    //     }else{
    //         return 0f;
    //     }
    // }
}
