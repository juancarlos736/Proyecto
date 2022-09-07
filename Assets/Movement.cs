using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Movement : MonoBehaviour
{
    public float speed=2f;
    public float jumpSpeed=4f;
    public Text textScore;

    public Rigidbody2D body;
    // Start is called before the first frame update
    void Start()
    {
        textScore.text = puntos.puntaje.ToString();
        body= GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void FixedUpdate(){

        if(Input.GetKey("a") || Input.GetKey("left")){

            body.velocity = new Vector2(-speed,body.velocity.y);
            

        }else if(Input.GetKey("d") || Input.GetKey("right")){

             body.velocity= new Vector2(speed,body.velocity.y);
             
             

        }
        else if(Input.GetKey("w") || Input.GetKey("up")){

             body.velocity= new Vector2(body.velocity.x,speed);
            

        }
        else if(Input.GetKey("s") || Input.GetKey("down")){

             body.velocity= new Vector2(body.velocity.x,-speed);
            

        }
        else{
            body.velocity= new Vector2(body.velocity.x,0);
            body.velocity= new Vector2(0,body.velocity.y);

        }
        }
}



