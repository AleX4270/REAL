using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bolts : MonoBehaviour
{
    public float boltsCooldown;
    public float boltsSpeed;
    private Vector2 startingPosition;
    private Rigidbody2D rb2d;

    private void Awake()
    {
        startingPosition = transform.position;
        rb2d = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        shootBolts();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            GameManager.Instance.gameplayManager.resetPlayer();
        }

        rb2d.velocity = Vector2.zero;
        resetBolts();
        StartCoroutine(shootBolts());
    }

    internal IEnumerator shootBolts()
    {
        yield return new WaitForSeconds(boltsCooldown);

        rb2d.velocity = new Vector2(this.boltsSpeed * Time.fixedDeltaTime, 0);
    }

    internal void resetBolts()
    {
        this.transform.position = startingPosition;
    }
}
