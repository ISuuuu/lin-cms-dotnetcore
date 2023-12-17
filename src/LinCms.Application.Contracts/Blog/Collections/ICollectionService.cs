using System;
using System.Threading.Tasks;
using IGeekFan.FreeKit.Extras.Dto;
using LinCms.Blog.Collections;
using LinCms.Entities.Blog;

namespace LinCms.Blog.Collections;

/// <summary>
/// �ղؼз���
/// </summary>
public interface ICollectionService : ICrudAppService<CollectionDto, CollectionDto, Guid, CollectionSearchDto, CreateUpdateCollectionDto, CreateUpdateCollectionDto>
{

}