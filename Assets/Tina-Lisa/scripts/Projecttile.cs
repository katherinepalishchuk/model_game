using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projecttile : MonoBehaviour
{

    public Rigidbody bulletPrefabs;
    public Rigidbody greenBottlePrefab;
    public Rigidbody whiteBottlePrefab;
    public Rigidbody trash;
    public Rigidbody plant;
    public GameObject cursor;
    public LayerMask layer;
    public Transform shootPoint;
    private Camera cam;
    public float randomObject;
    public float i = 0;
    public timer Timer;

    // Start is called before the first frame update
    void Start()
    {
         
        randomObject = Random.Range(0,1);
        
        
        cam = Camera.main;
        Timer = GameObject.FindObjectOfType<timer>(); 
        
    }

    // Update is called once per frame
    void Update()
    {
       Debug.Log(randomObject);
        LaunchProjectile();
       
         if (i == 20) {
                  Timer.finished = true;
                  Debug.Log("finised");
              }
    }
    void LaunchProjectile()
    {
        Ray camRay = cam.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(camRay, out hit, 100f, layer))
        {
            cursor.SetActive(true);
            cursor.transform.position = hit.point + Vector3.up * 0.1f;

            Vector3 Vo = CalculateVelocity(hit.point, shootPoint.position, 1f);
            transform.rotation = Quaternion.LookRotation(Vo);
            /* if(randomObject == 0)
            {
                Rigidbody objPlant = Instantiate(plant, new Vector3(10,3,9), Quaternion.identity);
                
            }
             else if (randomObject == 1 || randomObject == 2){
                Rigidbody objTrash = Instantiate(trash, new Vector3(10,3,9), Quaternion.identity);
               
                }
                else if (randomObject == 3 || randomObject == 4) {
                    
                Rigidbody objTrash = Instantiate(bulletPrefabs, new Vector3(10,3,9), Quaternion.identity);
                
                //Debug.Log(randomObject);
                
            
                         
                     }
                     else if (randomObject == 5 || randomObject == 6) {
                    
                Rigidbody objTrash = Instantiate(greenBottlePrefab, new Vector3(10,3,9), Quaternion.identity);
                
                //Debug.Log(randomObject);
                
            
                         
                     }
                      else {
                    
                Rigidbody objTrash = Instantiate(whiteBottlePrefab, new Vector3(10,3,9), Quaternion.identity);
                
                //Debug.Log(randomObject);
                
            
                         
                     }*/
            if(Input.GetMouseButtonDown(0))
            {
                
                if (i < 20){
                    i++;
                if(randomObject == 0)
                {
                Rigidbody objPlant = Instantiate(plant, shootPoint.position, Quaternion.identity);
                objPlant.transform.rotation = Random.rotation ;
                objPlant.transform.Rotate(new Vector3(Random.Range(-500.0f, 500.0f),Random.Range(-500.0f, 500.0f),Random.Range(-500.0f, 500.0f)) * Time.deltaTime, Space.World);

                objPlant.velocity = Vo;
               // Debug.Log(randomObject);
                }
                else if (randomObject == 1 || randomObject == 2){
                Rigidbody objTrash = Instantiate(trash, shootPoint.position, Quaternion.identity);
                objTrash.transform.rotation = Random.rotation ;
                objTrash.transform.Rotate(new Vector3(Random.Range(-500.0f, 500.0f),Random.Range(-500.0f, 500.0f),Random.Range(-500.0f, 500.0f)) * Time.deltaTime, Space.World);

                objTrash.velocity = Vo;
                //Debug.Log(randomObject);
                }
                else if (randomObject == 3 || randomObject == 4) {
                    
                Rigidbody objTrash = Instantiate(bulletPrefabs, shootPoint.position, Quaternion.identity);
                objTrash.transform.rotation = Random.rotation ;
                objTrash.transform.Rotate(new Vector3(Random.Range(-500.0f, 500.0f),Random.Range(-500.0f, 500.0f),Random.Range(-500.0f, 500.0f)) * Time.deltaTime, Space.World);

                objTrash.velocity = Vo;
                //Debug.Log(randomObject);
                
            
                         
                     }
                     else if (randomObject == 5 || randomObject == 6) {
                    
                Rigidbody objTrash = Instantiate(greenBottlePrefab, shootPoint.position, Quaternion.identity);
                objTrash.transform.rotation = Random.rotation ;
                objTrash.transform.Rotate(new Vector3(Random.Range(-500.0f, 500.0f),Random.Range(-500.0f, 500.0f),Random.Range(-500.0f, 500.0f)) * Time.deltaTime, Space.World);

                objTrash.velocity = Vo;
                //Debug.Log(randomObject);
                
            
                         
                     }
                      else {
                    
                Rigidbody objTrash = Instantiate(whiteBottlePrefab, shootPoint.position, Quaternion.identity);
                objTrash.transform.rotation = Random.rotation ;
                objTrash.transform.Rotate(new Vector3(Random.Range(-500.0f, 500.0f),Random.Range(-500.0f, 500.0f),Random.Range(-500.0f, 500.0f)) * Time.deltaTime, Space.World);

                objTrash.velocity = Vo;
                //Debug.Log(randomObject);
                
            
                         
                     }
                     randomObject = Random.Range(0,8);
                 }
                 else{
                    cursor.SetActive(false);
                  }
            }

    Vector3 CalculateVelocity(Vector3 target, Vector3 origin, float time)
    {
            //define distance x and y
            Vector3 distance = target - origin;
            Vector3 distanceXZ = distance;
            distanceXZ.y = 0f;

            //create float that represents our distance
            float Sy = distance.y;
            float Sxz = distanceXZ.magnitude;

            float Vxz = Sxz / time;
            float Vy = Sy / time + 0.5f * Mathf.Abs(Physics.gravity.y) * time;


            Vector3 result = distanceXZ.normalized;
            result *= Vxz;
            result.y = Vy;

            return result;
    }
        }
}
}
