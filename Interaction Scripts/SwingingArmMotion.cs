

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwingingArmMotion : MonoBehaviour
{
    // Game Objects
    [SerializeField] private GameObject LeftHand;
    [SerializeField] private GameObject RightHand;
    [SerializeField] private GameObject MainCamera;
    [SerializeField] private GameObject ForwardDirection;

    //Vector3 Positions
    [SerializeField] private Vector3 PositionPreviousFrameLeftHand;
    [SerializeField] private Vector3 PositionPreviousFrameRightHand;
    [SerializeField] private Vector3 PlayerPositionPreviousFrame;
    [SerializeField] private Vector3 PlayerPositionCurrentFrame;
    [SerializeField] private Vector3 PositionCurrentFrameLeftHand;
    [SerializeField] private Vector3 PositionCurrentFrameRightHand;

    //Speed
    [SerializeField] private float Speed = 20;
    [SerializeField] private float HandSpeed;
    [SerializeField] private float Gravity = 0.5f;

    // Ground Check
    [SerializeField] private bool isGrounded = false;

    void Start()
    {
        PlayerPositionPreviousFrame = transform.position; //set current positions
        PositionPreviousFrameLeftHand = LeftHand.transform.position; //set previous positions
        PositionPreviousFrameRightHand = RightHand.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        // get forward direction from the center eye camera and set it to the forward direction object
        float yRotation = MainCamera.transform.eulerAngles.y;
        ForwardDirection.transform.eulerAngles = new Vector3(0, yRotation, 0);

        // get positons of hands
        PositionCurrentFrameLeftHand = LeftHand.transform.position;
        PositionCurrentFrameRightHand = RightHand.transform.position;

        // position of player
        PlayerPositionCurrentFrame = transform.position;

        // get distance the hands and player has moved from last frame
        var playerDistanceMoved = Vector3.Distance(PlayerPositionCurrentFrame, PlayerPositionPreviousFrame);
        var leftHandDistanceMoved = Mathf.Abs(PositionPreviousFrameLeftHand.y - PositionCurrentFrameLeftHand.y);
        var rightHandDistanceMoved = Mathf.Abs(PositionPreviousFrameRightHand.y - PositionCurrentFrameRightHand.y);

        // aggregate to get hand speed
        HandSpeed = (leftHandDistanceMoved + rightHandDistanceMoved) / 2f;

        if (Time.timeSinceLevelLoad > 1f)
        {
            transform.position += ForwardDirection.transform.forward * HandSpeed * Speed * Time.deltaTime;
            transform.position += ForwardDirection.transform.up * HandSpeed * Speed * Time.deltaTime;
        }

        // add gravity to make object fall
        if (!isGrounded)
        {
            transform.position += Vector3.down * Gravity * Time.deltaTime;
            transform.position += ForwardDirection.transform.forward * 2 * Gravity * Time.deltaTime;
        }

        // Ground check
        RaycastHit hit;
        if (Physics.Raycast(transform.position, Vector3.down, out hit, 0.5f))
        {
            if (hit.collider.gameObject.tag == "Ground")
            {
                isGrounded = true;
            }
        }
        else
        {
            isGrounded = false;
        }

        // set previous position of hands for next frame
        PositionPreviousFrameLeftHand = PositionCurrentFrameLeftHand;
        PositionPreviousFrameRightHand = PositionCurrentFrameRightHand;
        // set player position previous frame
        PlayerPositionPreviousFrame = PlayerPositionCurrentFrame;
    }
}