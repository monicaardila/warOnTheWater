using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{   
    public float moveSpeed, lifeTime;
    public Rigidbody rb;
		public GameObject impactEffect;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       rb.velocity = transform.forward * moveSpeed;
            lifeTime -= Time.deltaTime; 
		 if (lifeTime <=0)
			{
				Destroy (gameObject);
			}
    }
	void OnTriggerEnter(Collider col){
		switch (col.gameObject.tag){
		case "bacteria":
			 
			Destroy(gameObject);

			//Destroy(col.gameObject);
			col.gameObject.GetComponent<EnemyHealthController>().DamageEnemy();
			Instantiate(impactEffect,transform.position,transform.rotation);
			break;
		}
		}
}
