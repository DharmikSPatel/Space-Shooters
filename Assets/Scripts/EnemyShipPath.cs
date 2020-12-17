using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShipPath : MonoBehaviour
{
    public Vector3 target1;
    public Vector3 target2;
    public Vector3 target3;
    public Vector3 target4;
    public float speed;
    string leg;
    int seed;
    bool freeze;
    public GameObject myExplo;
    public GameObject shipExplp1;

    // Start is called before the first frame update
    void Start()
    {
        leg = "fir";
        seed = SpawnEnemyShip.seed;
        target1.x *= seed;
        target2.x *= seed;
        target3.x *= seed;
        target4.x *= seed;
        freeze = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -14)
        {
            GameObject.Destroy(this.gameObject);
        }
        if (!freeze)
        {
            move();
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name.Contains("missile"))
        {
            GameObject.Destroy(other.gameObject);
            freeze = true;
            GameObject.Instantiate(myExplo, transform.position, transform.rotation);
            GameObject.Destroy(transform.gameObject, .5f);
        }
        else if (other.gameObject.transform.parent.gameObject.transform.parent.gameObject.name.Equals("Main Ship"))
        {
            
            GameObject ship = other.gameObject.transform.parent.gameObject.transform.parent.gameObject;
            GameObject ship_colliders = other.gameObject.transform.parent.gameObject;
            GameObject.Destroy(ship_colliders);
            GameObject.Instantiate(shipExplp1, ship.transform.position, ship.transform.rotation).transform.parent = null;
            freeze = true;
            GameObject.Destroy(transform.gameObject, .5f);
            GameObject.Destroy(ship, .2f);
        }
    }
    public void move()
    {
        float step = speed * Time.deltaTime;
        

        if (transform.position == target1)
        {
            leg = "sec";

        }
        else if (transform.position == target2)
        {
            leg = "thi";
        }
        else if (transform.position == target3)
        {
            leg = "fou";
        }

        if (leg.Equals("fir"))
            transform.position = Vector3.MoveTowards(transform.position, target1, step);
        else if (leg.Equals("sec"))
        {
            transform.position = Vector3.MoveTowards(transform.position, target2, step);
            transform.rotation = new Quaternion(.3f*seed, .7f, -.7f, -.3f*seed);
        }
        else if (leg.Equals("thi"))
        {
            transform.position = Vector3.MoveTowards(transform.position, target3, step);
            transform.rotation = new Quaternion(.7f * seed, .3f, -.3f, -.7f * seed);

        }
        else if (leg.Equals("fou"))
        {
            transform.position = Vector3.MoveTowards(transform.position, target4, step);
            transform.rotation = new Quaternion(0f, .7f, -.7f, 0f);
        }
    }
}
