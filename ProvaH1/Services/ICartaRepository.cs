using ProvaH1.Models;

namespace ProvaH1.Services
{
    public interface ICartaRepository
    {
        void CriarCarta(Carta carta);
        List<Carta> ListarCartas();
    }
}
