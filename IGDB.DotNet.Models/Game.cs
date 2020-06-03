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
        public ulong Id { get; set; }
        public IEnumerable<AgeRating> AgeRatings { get; set; }
        public double AggregatedRating { get; set; }
        public int AggregatedRatingCount { get; set; }
        public IEnumerable<AlternativeName> AlternativeNames { get; set; }
        public IEnumerable<Artwork> Artworks { get; set; }
        public IEnumerable<Game> Bundles { get; set; }
        public GameCategoryEnum Category { get; set; }
        public Collection Collection { get; set; }
        public Cover Cover { get; set; }
        public DateTime CreatedAt { get; set; }
        public IEnumerable<Game> Dlcs { get; set; }
        public IEnumerable<Game> Expansions { get; set; }
        public IEnumerable<ExternalGame> ExternalGames { get; set; }
        public DateTime FirstReleaseDate { get; set; }
        public int Follows { get; set; }
        public Franchise Franchise { get; set; }
        public IEnumerable<Franchise> Franchises { get; set; }
        public IEnumerable<GameEngine> GameEngines { get; set; }
        public IEnumerable<GameMode> GameModes { get; set; }
        public IEnumerable<Genre> Genres { get; set; }
        public int Hypes { get; set; }
        public IEnumerable<InvolvedCompany> InvolvedCompanies { get; set; }
        public IEnumerable<Keyword> Keywords { get; set; }
        public IEnumerable<MultiplayerMode> MultiplayerModes { get; set; }
        public string Name { get; set; }
        public Game ParentGame { get; set; }
        public IEnumerable<Platform> Platforms { get; set; }
        public IEnumerable<PlayerPerspective> PlayerPerspectives { get; set; }
        public double Popularity { get; set; }
        public int PulseCount { get; set; }
        public double Rating { get; set; }
        public int RatingCount { get; set; }
        public IEnumerable<ReleaseDate> ReleaseDates { get; set; }
        public IEnumerable<Screenshot> Screenshots { get; set; }
        public IEnumerable<Game> SimilarGames { get; set; }
        public string Slug { get; set; }
        public IEnumerable<Game> StandaloneExpansions { get; set; }
        public GameStatusEnum Status { get; set; }
        public string Storyline { get; set; }
        public string Summary { get; set; }
        public IEnumerable<int> Tags { get; set; }
        public IEnumerable<Theme> Themes { get; set; }
        public TimeToBeat TimeToBeat { get; set; }
        public double TotalRating { get; set; }
        public int TotalRatingCount { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string Url { get; set; }
        public Game VersionParent { get; set; }
        public string VersionTitle { get; set; }
        public IEnumerable<GameVideo> Videos { get; set; }
        public IEnumerable<Website> Websites { get; set; }
        public string Checksum { get; set; }
    }

}
