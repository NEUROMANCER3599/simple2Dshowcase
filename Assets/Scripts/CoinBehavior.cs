using UnityEngine;

public class CoinBehavior : MonoBehaviour
{
    [SerializeField] private Animator CoinAnimator;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        CoinAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   public void OnCollected()
    {
        CoinAnimator.SetTrigger("OnCollected");
        Destroy(this.gameObject, 2f);
    }
}
