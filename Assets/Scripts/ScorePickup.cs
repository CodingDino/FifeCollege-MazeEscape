using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScorePickup : MonoBehaviour {

    public Score scoreTracker;
    public int scoreValue = 1;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Only do stuff if it's the player we've hit
        if (collision.GetComponent<Player>())
        {
            // Updating the score based on how much this item is worth
            scoreTracker.ChangeValue(scoreValue);

            // get rid of the item (it's been used up)
            Destroy(gameObject);
        }
    }

}
