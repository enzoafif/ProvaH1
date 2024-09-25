using ProvaH1.Models;

namespace ProvaH1.Services
{
    public class CartaRepository : ICartaRepository
    {
        private static List<Carta> listaCartas = [];

        public void CriarCarta(Carta carta)
        {
            listaCartas.Add(carta);
        }

        public List<Carta> ListarCartas()
        {
            return listaCartas;
        }
    }
}
