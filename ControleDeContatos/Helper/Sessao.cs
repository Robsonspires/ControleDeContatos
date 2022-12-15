using ControleDeContatos.Models;
using Newtonsoft.Json;

namespace ControleDeContatos.Helper
{
    public class Sessao : ISessao
    {
        private readonly IHttpContextAccessor _httpContext;

        public Sessao(IHttpContextAccessor httpContext) => _httpContext = httpContext;
        //public Sessao(IHttpContextAccessor httpContext)
        //{
        //    _httpContext = httpContext;
        //}

        public UsuarioModel BuscarSessaodoUsuario()
        {
#pragma warning disable CS8600 // Conversão de literal nula ou possível valor nulo em tipo não anulável.
            string sessaoUsuario = _httpContext.HttpContext?.Session.GetString("sessaoUsuarioLogado");
#pragma warning restore CS8600 // Conversão de literal nula ou possível valor nulo em tipo não anulável.

#pragma warning disable CS8603 // Possível retorno de referência nula.
            if (string.IsNullOrEmpty(sessaoUsuario)) return null;
#pragma warning restore CS8603 // Possível retorno de referência nula.

#pragma warning disable CS8603 // Possível retorno de referência nula.
            return JsonConvert.DeserializeObject<UsuarioModel>(sessaoUsuario);
#pragma warning restore CS8603 // Possível retorno de referência nula.
        }

        public void CriarSessaoDoUsuario(UsuarioModel usuario)
        {
            string? valor = JsonConvert.SerializeObject(usuario);
#pragma warning disable CS8602 // Desreferência de uma referência possivelmente nula.
            _httpContext.HttpContext.Session.SetString("sessaoUsuarioLogado", valor);
#pragma warning restore CS8602 // Desreferência de uma referência possivelmente nula.
        }

        public void RemoverSessaoUsuario()
        {
#pragma warning disable CS8602 // Desreferência de uma referência possivelmente nula.
            _httpContext?.HttpContext.Session.Remove("sessaoUsuarioLogado");
#pragma warning restore CS8602 // Desreferência de uma referência possivelmente nula.
        }
    }
}
