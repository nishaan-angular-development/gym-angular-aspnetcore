using Nishaan.Gym.ViewModel;

namespace Nishaan.Gym.Interface
{
    public interface IGenerateRecepit
    {
        GenerateRecepitViewModel Generate(int paymentId);
    }
}