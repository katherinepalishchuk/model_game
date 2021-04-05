using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class monetka : MonoBehaviour {

    
    public int monetka2 = 0;

    public enter enter;
    public GameObject a;

    public enter_1 enter_1;
    public GameObject a1;

    public enter_2 enter_2;
    public GameObject a2;

    public enter_3 enter_3;
    public GameObject a3;

    public enter_4 enter_4;
    public GameObject a4;

    public enter_5 enter_5;
    public GameObject a5;

    public enter_6 enter_6;
    public GameObject a6;


    public enter_7 enter_7;
    public GameObject a7;








    // Start is called before the first frame update
    void Start()
    {
        enter = a.GetComponent<enter>();

        enter_1 = a1.GetComponent<enter_1>();

        enter_2 = a2.GetComponent<enter_2>();

        enter_3 = a3.GetComponent<enter_3>();

        enter_4 = a4.GetComponent<enter_4>();

        enter_5 = a5.GetComponent<enter_5>();

        enter_6 = a6.GetComponent<enter_6>();

        enter_7 = a7.GetComponent<enter_7>();



    }

    // Update is called once per frame
    public void Update()
    {
        monetka2 = enter.coins + enter_1.coins_1 + enter_2.coins_2 + enter_3.coins_3 + enter_4.coins_4 + enter_5.coins_5 + enter_6.coins_6 + enter_7.coins_7;

        if(monetka2==8)
        {
            SceneManager.LoadScene("Win");
        }
    }
}
