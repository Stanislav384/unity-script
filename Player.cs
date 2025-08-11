using UnityEngine;

public class Player : MonoBehaviour
{
    private int coins;
    public AudioSource audiosource;
    public AudioClip collect_coin;

    public void CollectCoins()
    {
        coins++;

        audiosource.PlayOneShot(collect_coin);

        print(coins);
    }
}
