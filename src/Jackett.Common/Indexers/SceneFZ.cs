using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using Jackett.Common.Indexers.Abstract;
using Jackett.Common.Models;
using Jackett.Common.Services.Interfaces;
using Jackett.Common.Utils.Clients;
using NLog;

namespace Jackett.Common.Indexers
{
    [ExcludeFromCodeCoverage]
    public class SceneFZ : XtremeZoneTracker
    {
        public override string[] LegacySiteLinks { get; protected set; } = {
            "https://scenefz.me/",
            "https://www.scenefz.me/",
            "https://www.u-torrents.ro/"
        };

        public SceneFZ(IIndexerConfigurationService configService, WebClient wc, Logger l, IProtectionService ps)
            : base(
                id: "scenefz",
                name: "SceneFZ",
                description: "SceneFZ is a ROMANIAN Private Torrent Tracker for MOVIES / TV / GENERAL",
                link: "https://speedapp.io/",
                caps: new TorznabCapabilities
                {
                    TvSearchParams = new List<TvSearchParam>
                    {
                        TvSearchParam.Q, TvSearchParam.Season, TvSearchParam.Ep, TvSearchParam.ImdbId
                    },
                    MovieSearchParams = new List<MovieSearchParam>
                    {
                        MovieSearchParam.Q, MovieSearchParam.ImdbId
                    },
                    MusicSearchParams = new List<MusicSearchParam>
                    {
                        MusicSearchParam.Q
                    },
                    BookSearchParams = new List<BookSearchParam>
                    {
                        BookSearchParam.Q
                    }
                },
                configService: configService,
                client: wc,
                logger: l,
                p: ps)
        {
            AddCategoryMapping(38, TorznabCatType.Movies, "Movie Packs");
            AddCategoryMapping(10, TorznabCatType.MoviesSD, "Movies: SD");
            AddCategoryMapping(35, TorznabCatType.MoviesSD, "Movies: SD Ro");
            AddCategoryMapping(8, TorznabCatType.MoviesHD, "Movies: HD");
            AddCategoryMapping(29, TorznabCatType.MoviesHD, "Movies: HD Ro");
            AddCategoryMapping(7, TorznabCatType.MoviesDVD, "Movies: DVD");
            AddCategoryMapping(2, TorznabCatType.MoviesDVD, "Movies: DVD Ro");
            AddCategoryMapping(17, TorznabCatType.MoviesBluRay, "Movies: BluRay");
            AddCategoryMapping(24, TorznabCatType.MoviesBluRay, "Movies: BluRay Ro");
            AddCategoryMapping(59, TorznabCatType.Movies, "Movies: Ro");
            AddCategoryMapping(57, TorznabCatType.MoviesUHD, "Movies: 4K (2160p) Ro");
            AddCategoryMapping(61, TorznabCatType.MoviesUHD, "Movies: 4K (2160p)");
            AddCategoryMapping(41, TorznabCatType.TV, "TV Packs");
            AddCategoryMapping(66, TorznabCatType.TV, "TV Packs Ro");
            AddCategoryMapping(45, TorznabCatType.TVSD, "TV Episodes");
            AddCategoryMapping(46, TorznabCatType.TVSD, "TV Episodes Ro");
            AddCategoryMapping(43, TorznabCatType.TVHD, "TV Episodes HD");
            AddCategoryMapping(44, TorznabCatType.TVHD, "TV Episodes HD Ro");
            AddCategoryMapping(60, TorznabCatType.TV, "TV Ro");
            AddCategoryMapping(11, TorznabCatType.PCGames, "Games: PC-ISO");
            AddCategoryMapping(52, TorznabCatType.Console, "Games: Console");
            AddCategoryMapping(1, TorznabCatType.PC0day, "Applications");
            AddCategoryMapping(14, TorznabCatType.PC, "Applications: Linux");
            AddCategoryMapping(37, TorznabCatType.PCMac, "Applications: Mac");
            AddCategoryMapping(19, TorznabCatType.PCMobileOther, "Applications: Mobile");
            AddCategoryMapping(62, TorznabCatType.TV, "TV Cartoons");
            AddCategoryMapping(3, TorznabCatType.TVAnime, "TV Anime / Hentai");
            AddCategoryMapping(6, TorznabCatType.BooksEBook, "E-books");
            AddCategoryMapping(5, TorznabCatType.Audio, "Music");
            AddCategoryMapping(64, TorznabCatType.AudioVideo, "Music Video");
            AddCategoryMapping(18, TorznabCatType.Other, "Images");
            AddCategoryMapping(22, TorznabCatType.TVSport, "TV Sports");
            AddCategoryMapping(58, TorznabCatType.TVSport, "TV Sports Ro");
            AddCategoryMapping(9, TorznabCatType.TVDocumentary, "TV Documentary");
            AddCategoryMapping(63, TorznabCatType.TVDocumentary, "TV Documentary Ro");
            AddCategoryMapping(65, TorznabCatType.Other, "Tutorial");
            AddCategoryMapping(67, TorznabCatType.OtherMisc, "Miscellaneous");
            AddCategoryMapping(15, TorznabCatType.XXX, "XXX Movies");
            AddCategoryMapping(47, TorznabCatType.XXX, "XXX DVD");
            AddCategoryMapping(48, TorznabCatType.XXX, "XXX HD");
            AddCategoryMapping(49, TorznabCatType.XXXImageSet, "XXX Images");
            AddCategoryMapping(50, TorznabCatType.XXX, "XXX Packs");
            AddCategoryMapping(51, TorznabCatType.XXX, "XXX SD");
        }
    }
}
