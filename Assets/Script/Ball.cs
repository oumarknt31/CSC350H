
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class NewBehaviourScript : MonoBehaviour
{
    Animation anim;
    static int numOfCollisions;
    const float MinInpulseForce = 3.0f;
    const float MaxInpulseForce = 5.0f;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("This is the first game");
        /*Vector3 position = transform.position;
        position.x = 5;
        transform.position = position;*/
        /*Vector3 newscale = transform.localScale;
        newscale.x = 4;
        newscale.y = 2;
        transform.localScale = newscale;*/
        Rigidbody2D rb2d = GetComponent<Rigidbody2D>();
        //Vector2 direction(0,5);
        //float 
        rb2d.AddForce(new Vector2((Mathf.Cos(Random.Range(0, 2 * Mathf.PI)) * Random.Range(3, 5)), (Mathf.Sin(Random.Range(0, 2 * Mathf.PI)) *
       Random.Range(3, 5))), ForceMode2D.Impulse);
    }
    // Update is called once per frame
    void Update()
    {
        if (numOfCollisions == 20)
        {
            UnityEditor.EditorApplication.isPaused = true;
        }
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        numOfCollisions++;
        Debug.Log("Number of Collision: " + numOfCollisions);
    }

}
