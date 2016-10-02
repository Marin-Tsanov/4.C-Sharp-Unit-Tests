namespace SantaseGame
{
    public interface IDeepCloneable<out T>
    {
        T DeepClone();
    }
}