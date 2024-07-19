namespace AgenciaViagem.Models
{

    public class Enum
    {
        /// <summary>
        /// Define os estados possíveis de uma tela.
        /// </summary>
        public enum EstadoTela
        {
            /// <summary>
            /// Estado para criar um item.
            /// </summary>
            Criar,

            /// <summary>
            /// Estado para editar um item existente.
            /// </summary>
            Editar
        }

        /// <summary>
        /// Define os perfis possíveis para um cliente.
        /// </summary>
        public enum PessoaClientePerfil
        {
            /// <summary>
            /// Perfil de usuário padrão.
            /// </summary>
            Usuario,

            /// <summary>
            /// Perfil de administrador.
            /// </summary>
            Admin
        }
    }
}
