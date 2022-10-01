using System.Collections;
using UnityEngine;
using DG.Tweening;

public class CollectibleSpawner : MonoBehaviour
{
    // This script is to handle the respawning of the collectible as a disabled gameObject cannot run any methods or coroutines on its own.
    [SerializeField] private SpriteRenderer spriteRenderer;
    [SerializeField] private GameObject collectibleGameObject;
    
    [Header("Collectible Settings")]
    [SerializeField] private float respawnTime = 4f;
    [SerializeField] private Transform TweenEndPoint;

    private GameManager _gameManager;

    private void Start()
    {
        _gameManager = FindObjectOfType<GameManager>();
        transform.DOMove(TweenEndPoint.position, 2f).SetEase(Ease.InOutBack).SetLoops(-1, LoopType.Yoyo);
    }
    private IEnumerator RespawnCollectible()
    {
        yield return new WaitForSeconds(respawnTime);
        SetOutlineSpriteActive(false);
        collectibleGameObject.SetActive(true);
    }

    private void SetOutlineSpriteActive(bool state)
    {
        spriteRenderer.enabled = state;
    }

    public void SetOutlineSprite(Sprite sprite)
    {
        spriteRenderer.sprite = sprite;
    }
    
    public void StartRespawningCountdown() // This method is to let other script trigger the respawn countdown, and let this script handle the coroutine.
    {
        SetOutlineSpriteActive(true);
        StartCoroutine(RespawnCollectible());
    }
}
