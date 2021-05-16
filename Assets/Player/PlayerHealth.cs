using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class PlayerHealth : MonoBehaviour
{

    public int maxHealth = 1;
    public int currentHealth;
    public Rigidbody rbPlayer;
    
    public Text PlayerLifeText;
    public gameManager gm;
    [SerializeField] private Material Pmaterial;

    // Start is call1ed before the first frame update
    void Awake()
    {
        currentHealth = maxHealth;
        rbPlayer = GetComponent<Rigidbody>();
        Pmaterial = GetComponent<Renderer>().material;

    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(currentHealth);
        if(Input.GetKeyDown("l"))
        {
            didDamage();
        }
    }

    public void LooseHealth(int dammage)
    {
        Debug.Log("LooseHP");
        if (currentHealth <= 0)
        {
            DeathPlayer();
        }
        currentHealth -= dammage;
        // PlayerLife();
    }
    void DeathPlayer()
    {
        Debug.Log("je suis mort");
        SceneManager.LoadScene("DefeatScene");
    }
    // DEbug // 
    void didDamage()
    {
        
            currentHealth -= 1;
        
    }

    void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag=="Enemy")
        {
            Destroy(gameObject);
            SceneManager.LoadScene("DefeatScene");
        }
    }
}
