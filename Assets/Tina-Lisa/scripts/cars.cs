using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Tisa
{

    public class cars : MonoBehaviour
    {
        public Text coinText;
        public GameObject korb;
       
        public int coinCount = 0;

        //public GameManager gameManager;
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

        private void FixedUpdate()
        {
            coinText.text = coinCount.ToString();
        }

        private void OnTriggerEnter(Collider other)

        {
            if (other.gameObject.CompareTag("car"))
            {
                other.gameObject.SetActive(false);
                //gameManager.addPoint();
                // korb.transform.position = new Vector3(0, 1.5f, 0);
                coinCount++;
                UnityEngine.Debug.Log("car im korb");
            }
        }
    }
}