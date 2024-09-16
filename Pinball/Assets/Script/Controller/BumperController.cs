using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BumperController : MonoBehaviour
{
    public Collider bola;
    public float multipler;
    public float score;
    private Animator animator;
    private Renderer renderer;

    public AudioManager audioManager;
    public VFXManager vfxManager;
    public ScoreManager scoreManager;
    // Start is called before the first frame update

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider == bola)
        {
            Rigidbody bolarig = bola.GetComponent<Rigidbody>();
            bolarig.velocity *= multipler;

            animator.SetTrigger("hit");

            audioManager.PlaySFX(collision.transform.position);
            vfxManager.PlayVXF(collision.transform.position);
            scoreManager.AddScore(score);
        }
    }
    void Start()
    {
        animator = GetComponent<Animator>();
        renderer = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
