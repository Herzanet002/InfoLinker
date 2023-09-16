﻿using InfoLinker.Api.Models;

namespace InfoLinker.Api.Services.Interfaces;

public interface IRssWorkerService
{
    ValueTask<IEnumerable<ContentModel>> GetFeeds(int? pageIndex, int? pageSize);
    
    ValueTask<IEnumerable<ContentModel>> GetFeeds(Guid feederId, int? pageIndex, int? pageSize);
}