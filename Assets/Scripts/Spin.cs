using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spin : MonoBehaviour
{
    [SerializeField] private RectTransform wheel;
    [SerializeField] private GameObject winGraphic;
    [SerializeField] private GameObject loseSound;
    
    //animator varibles
    private Animator animator;
    private int animationHash;


    //start possition for refresh
    private Vector3 startPosition;

    //spin state
    private bool isSpinning;
    private int count = 0;

    //results
    private int result;

    //getters
    public int Count { get { return count; } set { count = value; } }
    public bool IsSpinning { get { return isSpinning; } }
    public int Result { get { return result; } }

    // Start is called before the first frame update
    void Start()
    {
        animator = wheel.GetComponent<Animator>();
        animationHash = Animator.StringToHash("StopInt");
        animator.SetInteger(animationHash, -1);
        startPosition = wheel.position;
    }

    // Update is called once per frame
    void Update()
    {
        

    }

    public void StopSpin()
    {
        
        result = Random.Range(1, 8);
        animator.SetInteger(animationHash, result);
        isSpinning = false;
    }

    public void StartSpin()
    {
        isSpinning = true;
        winGraphic.SetActive(false);
        loseSound.SetActive(false);
        animator.enabled = true;
        animator.SetInteger(animationHash, 0);
    }
    
    public void RefreshSpin()
    {
        isSpinning = false;
        animator.enabled = false;
        animator.SetInteger(animationHash, -1);
        wheel.position = startPosition;
    }
}
