using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    private int health = 100;
    private Material mat;
    private Color CD;
    public Text healthText;
    private Animator anim;


    private void Start()
    {
        mat = GetComponent<MeshRenderer>().material;
        CD = mat.color;
        healthText.text = health.ToString();
        anim = GetComponent<Animator>();
    }

    public void DetectHit(int damage)
    {
        health -= damage;
        anim.SetTrigger("Hit");
        if (health <= 0)
        {
            Destroy(gameObject);
        }
        StartCoroutine(HitEffect());
    }

    public IEnumerator HitEffect()
    {
        healthText.text = health.ToString();
        yield return null;
    }
}
