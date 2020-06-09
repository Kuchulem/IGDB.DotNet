using IGDB.DotNet.Models.Enums;
using System;
using System.Collections.Generic;

namespace IGDB.DotNet.Models
{
    ///<summary>
    /// Model description for Game
    ///</summary>
    public class Game : IEndpoint
    {

        /// <summary>
        /// Id
        /// </summary>
        public ulong Id { get; set; }

        /// <summary>
        /// AgeRatings
        /// </summary>
        public IEnumerable<AgeRating> AgeRatings { get; set; }

        /// <summary>
        /// AggregatedRating
        /// </summary>
        public double AggregatedRating { get; set; }

        /// <summary>
        /// AggregatedRatingCount
        /// </summary>
        public int AggregatedRatingCount { get; set; }

        /// <summary>
        /// AlternativeNames
        /// </summary>
        public IEnumerable<AlternativeName> AlternativeNames { get; set; }

        /// <summary>
        /// Artworks
        /// </summary>
        public IEnumerable<Artwork> Artworks { get; set; }

        /// <summary>
        /// Bundles
        /// </summary>
        public IEnumerable<Game> Bundles { get; set; }

        /// <summary>
        /// Category
        /// </summary>
        public GameCategoryEnum Category { get; set; }

        /// <summary>
        /// Collection
        /// </summary>
        public Collection Collection { get; set; }

        /// <summary>
        /// Cover
        /// </summary>
        public Cover Cover { get; set; }

        /// <summary>
        /// CreatedAt
        /// </summary>
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Dlcs
        /// </summary>
        public IEnumerable<Game> Dlcs { get; set; }

        /// <summary>
        /// Expansions
        /// </summary>
        public IEnumerable<Game> Expansions { get; set; }

        /// <summary>
        /// ExternalGames
        /// </summary>
        public IEnumerable<ExternalGame> ExternalGames { get; set; }

        /// <summary>
        /// FirstReleaseDate
        /// </summary>
        public DateTime FirstReleaseDate { get; set; }

        /// <summary>
        /// Follows
        /// </summary>
        public int Follows { get; set; }

        /// <summary>
        /// Franchise
        /// </summary>
        public Franchise Franchise { get; set; }

        /// <summary>
        /// Franchises
        /// </summary>
        public IEnumerable<Franchise> Franchises { get; set; }

        /// <summary>
        /// GameEngines
        /// </summary>
        public IEnumerable<GameEngine> GameEngines { get; set; }

        /// <summary>
        /// GameModes
        /// </summary>
        public IEnumerable<GameMode> GameModes { get; set; }

        /// <summary>
        /// Genres
        /// </summary>
        public IEnumerable<Genre> Genres { get; set; }

        /// <summary>
        /// Hypes
        /// </summary>
        public int Hypes { get; set; }

        /// <summary>
        /// InvolvedCompanies
        /// </summary>
        public IEnumerable<InvolvedCompany> InvolvedCompanies { get; set; }

        /// <summary>
        /// Keywords
        /// </summary>
        public IEnumerable<Keyword> Keywords { get; set; }

        /// <summary>
        /// MultiplayerModes
        /// </summary>
        public IEnumerable<MultiplayerMode> MultiplayerModes { get; set; }

        /// <summary>
        /// Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// ParentGame
        /// </summary>
        public Game ParentGame { get; set; }

        /// <summary>
        /// Platforms
        /// </summary>
        public IEnumerable<Platform> Platforms { get; set; }

        /// <summary>
        /// PlayerPerspectives
        /// </summary>
        public IEnumerable<PlayerPerspective> PlayerPerspectives { get; set; }

        /// <summary>
        /// Popularity
        /// </summary>
        public double Popularity { get; set; }

        /// <summary>
        /// PulseCount
        /// </summary>
        public int PulseCount { get; set; }

        /// <summary>
        /// Rating
        /// </summary>
        public double Rating { get; set; }

        /// <summary>
        /// RatingCount
        /// </summary>
        public int RatingCount { get; set; }

        /// <summary>
        /// ReleaseDates
        /// </summary>
        public IEnumerable<ReleaseDate> ReleaseDates { get; set; }

        /// <summary>
        /// Screenshots
        /// </summary>
        public IEnumerable<Screenshot> Screenshots { get; set; }

        /// <summary>
        /// SimilarGames
        /// </summary>
        public IEnumerable<Game> SimilarGames { get; set; }

        /// <summary>
        /// Slug
        /// </summary>
        public string Slug { get; set; }

        /// <summary>
        /// StandaloneExpansions
        /// </summary>
        public IEnumerable<Game> StandaloneExpansions { get; set; }

        /// <summary>
        /// Status
        /// </summary>
        public GameStatusEnum Status { get; set; }

        /// <summary>
        /// Storyline
        /// </summary>
        public string Storyline { get; set; }

        /// <summary>
        /// Summary
        /// </summary>
        public string Summary { get; set; }

        /// <summary>
        /// Tags
        /// </summary>
        public IEnumerable<int> Tags { get; set; }

        /// <summary>
        /// Themes
        /// </summary>
        public IEnumerable<Theme> Themes { get; set; }

        /// <summary>
        /// TimeToBeat
        /// </summary>
        public TimeToBeat TimeToBeat { get; set; }

        /// <summary>
        /// TotalRating
        /// </summary>
        public double TotalRating { get; set; }

        /// <summary>
        /// TotalRatingCount
        /// </summary>
        public int TotalRatingCount { get; set; }

        /// <summary>
        /// UpdatedAt
        /// </summary>
        public DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Url
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// VersionParent
        /// </summary>
        public Game VersionParent { get; set; }

        /// <summary>
        /// VersionTitle
        /// </summary>
        public string VersionTitle { get; set; }

        /// <summary>
        /// Videos
        /// </summary>
        public IEnumerable<GameVideo> Videos { get; set; }

        /// <summary>
        /// Websites
        /// </summary>
        public IEnumerable<Website> Websites { get; set; }

        /// <summary>
        /// Checksum
        /// </summary>
        public string Checksum { get; set; }
    }

}
