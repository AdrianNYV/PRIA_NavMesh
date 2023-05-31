using UnityEngine;
using UnityEngine.AI;
    
public class Enemy : MonoBehaviour {
    public Transform player;
    private NavMeshAgent agent;
       
    void Start () {
        agent = GetComponent<NavMeshAgent>();
        agent.destination = player.position; 
    }

    void Update() {
        agent.destination = player.position; 
    }
}