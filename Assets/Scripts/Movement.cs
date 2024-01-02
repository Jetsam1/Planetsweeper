using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Movement : MonoBehaviour
{
    [SerializeField]
    private LayerMask Jumpable;

    public float speed;
    private float speedmod;
    public float speedmult;
    public float jumpHeight;
    private bool isJump;
    private bool doubleJump;
    private RaycastHit2D hit;
    public GameObject Bullet;
    public BoxCollider2D bc2d;
    public Rigidbody2D Prb2d;
    public Transform PointofFire;
    public GameObject Unluck;
    public GameObject Pause;
    public GameObject Resume;
    public GameObject scoreText;
    public GameObject finScore;
    public int score;
    public Text RealScore;
    public Text FinalScore;
    public int RockPoints;
    public int MissilePoints;
    public int CometPoints;


    
        
    


    // Start is called before the first frame update
    void Start()
    {
        Unluck.SetActive(false);
        Pause.SetActive(true);
        Resume.SetActive(true);
        scoreText.SetActive(true);
        finScore.SetActive(true);
        RealScore.text = score.ToString();
        FinalScore.text = score.ToString();
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
   
        if(isJump==true &&  IsGrounded())
        {
            speedmod = Mathf.Pow(speedmult , score);
            transform.Translate(speedmod *speed *Time.timeScale, jumpHeight*Time.timeScale, 0);
            isJump = false;
            doubleJump = true;
            
            
        }
        else if(doubleJump==true)
        {
            speedmod = Mathf.Pow(speedmult ,score);
            transform.Translate(speed * speedmod * Time.timeScale, jumpHeight * Time.timeScale, 0);
            doubleJump = false;
        }
        else
        {
            speedmod = Mathf.Pow(speedmult , score);
            transform.Translate(speed * speedmod*Time.timeScale, 0, 0);
        }
        RealScore.text= score.ToString();
        FinalScore.text = score.ToString();
    }


   private bool IsGrounded()
    {
        float extra = 0.55f;
        hit=Physics2D.Raycast(bc2d.bounds.center, Vector2.down, bc2d.bounds.extents.y + extra,Jumpable);
        Debug.DrawRay(bc2d.bounds.center, Vector2.down* (bc2d.bounds.extents.y + extra));
        Color rayColor;
        if(hit.collider !=null)
        {
            Debug.Log("Is Grounded");
            Debug.Log(hit.collider);
            rayColor = Color.green;
                
        }
        else
        {
            Debug.Log("Is Airborne");
            Debug.Log(hit.collider);
            rayColor = Color.red;

        }

        return hit.collider != null;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("has happened");
        if(collision.tag=="Hazard" || collision.tag=="Enemy")
        {
            Pause.SetActive(false);
            Resume.SetActive(false);
            scoreText.SetActive(false);
            finScore.SetActive(false);
            Unluck.SetActive(true);
            
            Time.timeScale = 0;
        }
    }


    public void Jump()
    {
        isJump = true;
        Debug.Log("Jump");
    }

    public void Fire()
    {
        Instantiate(Bullet, PointofFire.position, PointofFire.rotation);
    }


    public void Converter(string s)
    {
        if (s=="Hazard")
        {
            score++;
        }
        else if(s=="Enemy")
        {
            score = score + 3;
        }
        else
        {
            score = score + 5;
        }
    }
}
