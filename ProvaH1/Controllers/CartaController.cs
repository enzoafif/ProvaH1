using Microsoft.AspNetCore.Mvc;
using ProvaH1.Models;
using ProvaH1.Services;

namespace ProvaH1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartaController : ControllerBase
    {
        private readonly ICartaRepository _cartaRepository;

        public CartaController(ICartaRepository cartaRepository)
        {
            _cartaRepository = cartaRepository;
        }

        [HttpPost]
        public IActionResult CriarCarta(Carta carta)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _cartaRepository.CriarCarta(carta);

            return Ok("Carta criada com sucesso");
        }

        [HttpGet]
        public IActionResult ListarCartas()
        {
            var cartas = _cartaRepository.ListarCartas();

            return Ok(cartas);
        }
    }
}
