using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OneBallBehaviour : MonoBehaviour
{
    public float TooFar = 5;

    //public float XRotation = 0;
    //public float YRotation = 1;
    //public float ZRotation = 0;
    public float XSpeed;
    public float YSpeed;
    public float ZSpeed;

    //public float DegreesPerSecond = 180;
    public float Multiplier = 0.75f;

    public int ballNumber = 0;
    static int counter;
    // Start вызывается перед первым обновлением кадра
    void Start()
    {
        //transform.position = new Vector3(3 - Random.value * 6, 3 - Random.value * 6, 3 - Random.value * 6);
        counter++;
        ballNumber = counter;

        ResetBall();
    }
    // Update вызывается один раз на кадр
    void Update()
    {
        //Vector3 axis = new Vector3(XRotation, YRotation, ZRotation);
        //transform.RotateAround(Vector3.zero, axis, DegreesPerSecond * Time.deltaTime);
        //// Debug.DrawRay(Vector3.zero, axis, Color.yellow);

        XSpeed += Multiplier - Random.value * Multiplier * 2;
        YSpeed += Multiplier - Random.value * Multiplier * 2;
        ZSpeed += Multiplier - Random.value * Multiplier * 2;

        transform.Translate(Time.deltaTime * XSpeed, Time.deltaTime * YSpeed, Time.deltaTime * ZSpeed);

        if ((Mathf.Abs(transform.position.x) > TooFar)
            || (Mathf.Abs(transform.position.y) > TooFar)
            || (Mathf.Abs(transform.position.z) > TooFar))
        {
            ResetBall();
        }
    }
    void OnMouseDown()
    {
        GameController controller = Camera.main.GetComponent<GameController>();
        if (!controller.GameOver)
        {
            controller.ClickedOnBall();
            Destroy(gameObject);  
        }
    }

    void ResetBall()
    {
        XSpeed = Multiplier - Random.value * Multiplier * 2;
        YSpeed = Multiplier - Random.value * Multiplier * 2;
        ZSpeed = Multiplier - Random.value * Multiplier * 2;
        transform.position = new Vector3(3 - Random.value * 6, 3 - Random.value * 6, 3 - Random.value * 6);
    }
}
