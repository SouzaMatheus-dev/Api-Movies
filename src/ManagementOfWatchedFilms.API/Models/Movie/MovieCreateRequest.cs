using System.ComponentModel.DataAnnotations;

namespace ManagementOfWatchedFilms.API.Models.Movie
{
    public class MovieCreateRequest
    {
        /// <summary>
        /// Obtém ou define o identificador do IMDb do filme.
        /// </summary>
        [Required]
        public string IMDbId { get; set; }

        /// <summary>
        /// Obtém ou define o nome do filme.
        /// </summary>
        [Required]
        public string Name { get; set; }

        /// <summary>
        /// Obtém ou define uma breve descrição do filme.
        /// </summary>
        [Required]
        public string Description { get; set; }

        /// <summary>
        /// Obtém ou define a data de lançamento do filme.
        /// </summary>
        [Required]
        public DateTime ReleaseDate { get; set; }

        /// <summary>
        /// Obtém ou define o gênero do filme.
        /// </summary>
        [Required]
        public string Genre { get; set; }
    }
}