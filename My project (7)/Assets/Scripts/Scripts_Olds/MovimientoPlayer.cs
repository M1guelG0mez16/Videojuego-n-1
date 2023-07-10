using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoPlayer : MonoBehaviour
{
  public Rigidbody2D rb;
  public float speedForce;

    // Start is called before the first frame update
    void Start()
    {
      Debug.Log("aca es el metodo start");  
      gameObject.transform.position = new Vector3(-24.58f, -5.48f, 0);
    }


    // Update is called once per frame
    void Update()
    {
      Debug.Log("aca es el metodo update"); 

      if (Input.GetKey("right") && (gameObject.transform.position.x < 24.52))
      {
          rb.AddForce(new Vector2(speedForce, 0) * Time.deltaTime);
      }

      if (Input.GetKey("left") && (gameObject.transform.position.x > -24.52))
      {
          gameObject.transform.Translate(-3.5f * Time.deltaTime, 0, 0);
      }

      if (Input.GetKey("up"))
      {
         gameObject.transform.Translate(0, 3.5f * Time.deltaTime, 0);
      }

      if ((gameObject.transform.position.y < -15.25))
      {
          Debug.Log("Game over");
      }
    }
}
 