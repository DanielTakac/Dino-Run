using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoneMovement : MonoBehaviour{

    public GameObject startPoint;
    public GameObject endPoint;

    public float startPositionEnd;
    public float startPosition;
    public float speed = 0.1f;
    public float speedMultiplier = 1f;

    public float offSet = 0.05f;

    void Start()
    {

        startPosition = transform.position.x; //detects the position of the object
        startPositionEnd = endPoint.transform.position.x; //detects the position of the end point

    }

    void Update()
    {

        //Detects if the object is almost at the same position as at start and teleports it back
        if (endPoint.transform.position.x >= startPoint.transform.position.x - offSet && endPoint.transform.position.x <= startPoint.transform.position.x + offSet)
        {

            transform.position = new Vector2(startPosition, transform.position.y);
            endPoint.transform.position = new Vector2(startPositionEnd, endPoint.transform.position.y);

        }

        //Moving
        transform.position -= new Vector3(speed * speedMultiplier * Time.deltaTime, 0, 0);
        endPoint.transform.position -= new Vector3(speed * speedMultiplier * Time.deltaTime, 0, 0);

    }

}
