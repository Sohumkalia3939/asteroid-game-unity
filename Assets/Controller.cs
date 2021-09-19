using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    private Vector3 touchPosition;
    private Rigidbody2D rb;
    private Vector3 direction;
    public float moveSpeed = 30f;
    public float runspeed ;
    public Controller controller;
    public weopon Weopon;

    private Vector2 startTouchPosition, endTouchPosition;

    // Use this for initialization
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void Update()
    {
//        Instantiate(Missile, new Vector3(SpaceShip.transform.position.x, SpaceShip.transform.position.y, SpaceShip.transform.position.y), Quaternion.identity);

        rb.AddForce(transform.up * runspeed * Time.deltaTime);
        transform.Rotate(0f, 180f, 0f);

        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
            startTouchPosition = Input.GetTouch(0).position;

        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended)
        {
            endTouchPosition = Input.GetTouch(0).position;

            if ((endTouchPosition.x < startTouchPosition.x) && transform.position.x > -1.75f)
                transform.position = new Vector2(transform.position.x - 1.75f, transform.position.y);

            if ((endTouchPosition.x > startTouchPosition.x) && transform.position.x < 1.75f)
                transform.position = new Vector2(transform.position.x + 1.75f, transform.position.y);
        }
    

















}
    // called when the cube hits the floor
    void OnCollisionEnter2D(Collision2D col)
    {
        controller.enabled = false;
        Weopon.enabled = false;
        Debug.Log("OnCollisionEnter2D");
        FindObjectOfType<GameOverScreen>().gameover();
    }
   
  //  public void Kala()
  //  {
     //   Instantiate(Missile, new Vector3(SpaceShip.transform.position.x+1, SpaceShip.transform.position.y+1, SpaceShip.transform.position.y), Quaternion.identity);

    //}
}


