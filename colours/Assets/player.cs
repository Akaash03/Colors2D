using UnityEngine;
using UnityEngine.SceneManagement;

public class player : MonoBehaviour {
    public float jumpforce = 10f;

    public Rigidbody2D rb;
    public SpriteRenderer sr;

    public string currentcolor;

    public Color colorCyan;
    public Color colorYellow;
    public Color colorMagenta;
    public Color colorviolet;

    private void Start()
    {
        Setrandomcolor();
    }

    void Update () {
        if(Input.GetButtonDown("Jump") || Input.GetMouseButtonDown(0))
        {
            rb.velocity = Vector2.up * jumpforce;
        }		
	}

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "colorchanger")
        {
            Setrandomcolor();
            Destroy(col.gameObject);
            return;
        }
       if(col.tag != currentcolor && col.tag != "plane")
        {
            Debug.Log("GAME OVER!!!");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    void Setrandomcolor()
    {
        int index = Random.Range(0, 4);

        switch (index)
        {
            case 0:
                currentcolor = "Cyan";
                sr.color = colorCyan;
                break;
            case 1:
                currentcolor = "Yellow";
                sr.color = colorYellow;
                break;
            case 2:
                currentcolor = "Magenta";
                sr.color = colorMagenta;
                break;
            case 3:
                currentcolor = "violet";
                sr.color = colorviolet;
                break;
        }
    }
}
