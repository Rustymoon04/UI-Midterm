using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class ImageAnimationController : MonoBehaviour
{
    public Image targetImage;  // The image that will be animated

    // Button 1: Scale
    public void ScaleImage()
    {
        targetImage.rectTransform.DOScale(new Vector3(1.5f, 1.5f, 1f), 1f).SetLoops(2, LoopType.Yoyo);
    }

    // Button 2: Zoom
    public void ZoomImage()
    {
        targetImage.rectTransform.DOScale(new Vector3(0.5f, 0.5f, 1f), 1f).SetLoops(2, LoopType.Yoyo);
    }

    // Button 3: Fade 
    public void Fade()
    {
        targetImage.DOFade(0, 1f).SetLoops(2, LoopType.Yoyo);
    }

    // Button 4: Fade Right (move image to the right while fading out)
    public void FadeRight()
    {
        targetImage.rectTransform.DOMoveX(targetImage.rectTransform.position.x + 200f, 1f).SetLoops(2, LoopType.Yoyo);
        targetImage.DOFade(0, 1f).SetLoops(2, LoopType.Yoyo);
    }

    // Button 5: Horizontal Flip
    public void HorizontalFlip()
    {
        targetImage.rectTransform.DORotate(new Vector3(0, 180, 0), 1f).SetLoops(2, LoopType.Yoyo);
    }

    // Button 6: Vertical Flip
    public void VerticalFlip()
    {
        targetImage.rectTransform.DORotate(new Vector3(180, 0, 0), 1f).SetLoops(2, LoopType.Yoyo);
    }
}
