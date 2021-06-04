using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Transform playerMove;
    [SerializeField]
    float playerSpeed;
    [SerializeField]
    AnimationCurve playerAnimCurve;
    //Animation playerAnimCurve;
    private void Awake()
    {
        playerMove = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        playerMove.position += playerSpeed * playerMove.forward * Time.deltaTime;
        float Y = playerAnimCurve.Evaluate(Mathf.PingPong(Time.time, 2f));
        playerMove.position = new Vector3(playerMove.position.x, Y, playerMove.position.z);
    }
}
