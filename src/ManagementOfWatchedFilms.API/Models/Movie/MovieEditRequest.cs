using System.ComponentModel.DataAnnotations;

namespace ManagementOfWatchedFilms.API.Models.Movie
{
    public class MovieEditRequest
    {
        /// <summary>
        /// Obtém ou define o identificador do IMDb do filme.
        /// </summary>
        public string? IMDbId { get; set; }

        /// <summary>
        /// Obtém ou define o nome do filme.
        /// </summary>
        public string? Name { get; set; }

        /// <summary>
        /// Obtém ou define uma breve descrição do filme.
        /// </summary>
        public string? Description { get; set; }

        /// <summary>
        /// Obtém ou define a data de lançamento do filme.
        /// </summary>
        public DateTime? ReleaseDate { get; set; }

        /// <summary>
        /// Obtém ou define o gênero do filme.
        /// </summary>
        public string? Genre { get; set; }

        // <summary>
        /// Obtém ou define a nota do usuário para o filme.
        /// </summary>
        public string? UserScore { get; set; }

        /// <summary>
        /// Obtém ou define um valor que indica se o filme foi assistido.
        /// </summary>
        public bool? Watched { get; set; }
    }
}