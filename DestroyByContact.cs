using UnityEngine;
using System.Collections;


public class DestroyByContact : MonoBehaviour
{
    //for explosions
    public GameObject explosion;
    public GameObject playerExplosion;


    //For Score
    public int scoreValue;
    private GameController gameController;

    void Start()
    {
        GameObject gameControllerObject = GameObject.FindGameObjectWithTag("GameController");
        if (gameControllerObject != null)
        {
            gameController = gameControllerObject.GetComponent<GameController>();
        }
        if (gameController == null)
        {
            Debug.Log("Cannot find 'GameController' script");
        }

    }





    //This will destroy enemy + bullet, bypassing the boundary.
    void onTriggerEnter(Collider other)
    {
        if (other.tag == "Boundary" || other.tag == "Enemy")
        {
            return;
        }
        //Instantiate will create explosion at the Nuke or Plane when shot

        if (explosion != null)
        {
            Instantiate(explosion, transform.position, transform.rotation);
        }
        Instantiate(explosion, transform.position, transform.rotation);
        if (other.tag == "Player")
        {
            //This Instantiate will create explosion at the nuke or plane when hit with user
            Instantiate(playerExplosion, other.transform.position, other.transform.rotation);
            gameController.GameOver();

        }

        //This will add points for destroying enemy
        gameController.AddScore(scoreValue);

        Destroy(other.gameObject);
        Destroy(gameObject);

    }

}

//Add this to the Nukes and Planes