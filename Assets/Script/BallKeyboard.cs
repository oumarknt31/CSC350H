using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallKeyboard : MonoBehaviour 
{
    [SerializeField] float movingSpeedPerSecond = 5;

    float screenLeft, screenRight, screenTop, screenBottom;
    float colliderHalfWidth, colliderHalfHeight;
    // Start is called before the first frame update
    void Start()
    {


        ScreenUtils.initialize();

        CircleCollider2D collider = GetComponent<CircleCollider2D>();
        Vector3 circleColliderDim = collider.bounds.max - collider.bounds.min;


        colliderHalfWidth = circleColliderDim.x / 2;
        colliderHalfHeight = circleColliderDim.y / 2;

        Debug.Log(screenLeft + " " + screenRight + " " + screenTop + " " + screenBottom + " " + colliderHalfWidth + " " + colliderHalfHeight);
    }

    // Update is called once per frame
    void Update()
    {
        

        Vector3 position = transform.position;
        float horizontalInput = Input.GetAxis("Horizontal");
        position.x += horizontalInput * movingSpeedPerSecond * Time.deltaTime;
        transform.position = position;

        float verticalInput = Input.GetAxis("Vertical");
        position.y += verticalInput * movingSpeedPerSecond * Time.deltaTime;
        transform.position = position;

        KeepInScreen();
        //ScreenUtils.KeepInScreen(psoition, colliderHalfWidth, colliderHalfHeight);

    }

    void KeepInScreen()
    {
        Vector3 position = transform.position;

        if (position.x - colliderHalfWidth < ScreenUtils.ScreenLeft)
        {
            position.x = ScreenUtils.ScreenLeft + colliderHalfWidth;
        }

        if (position.x + colliderHalfWidth > ScreenUtils.ScreenRight)
        {
            position.x = ScreenUtils.ScreenRight - colliderHalfWidth;
        }

        if (position.y - colliderHalfHeight < ScreenUtils.ScreenBottom)
        {
            position.y = ScreenUtils.ScreenBottom + colliderHalfHeight;
        }

        if (position.y + colliderHalfHeight > ScreenUtils.ScreenTop)
        {
            position.y = ScreenUtils.ScreenTop - colliderHalfHeight;
        }

        transform.position = position;
    }
}
