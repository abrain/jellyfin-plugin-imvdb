﻿using System.Threading;
using System.Threading.Tasks;
using Jellyfin.Plugin.IMVDb.Models;
using MediaBrowser.Controller.Providers;

namespace Jellyfin.Plugin.IMVDb
{
    /// <summary>
    /// The IMVDb client interface.
    /// </summary>
    public interface IImvdbClient
    {
        /// <summary>
        /// Gets the search result.
        /// </summary>
        /// <param name="searchInfo">The search info.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>The IMVDb search response.</returns>
        public Task<ImvdbSearchResponse?> GetSearchResponseAsync(
            MusicVideoInfo searchInfo,
            CancellationToken cancellationToken);

        /// <summary>
        /// Get result by id.
        /// </summary>
        /// <param name="imvdbId">The IMBDb id.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>The IMVDB video.</returns>
        public Task<ImvdbVideo?> GetIdResultAsync(
            string imvdbId,
            CancellationToken cancellationToken);
    }
}