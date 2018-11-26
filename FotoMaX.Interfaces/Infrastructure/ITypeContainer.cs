namespace FotoMaX.Interfaces.Infrastructure
{
    public interface ITypeContainer
    {
        void Register<TFrom, TTo>();
    }
}