using System.Threading.Tasks;

namespace LinCms.Blog.Collections;

/// <summary>
/// �����ղط���
/// </summary>
public interface IArticleCollectionService:IApplicationService
{
    /// <summary>
    /// �ղػ�ȡ���ղ�����
    /// </summary>
    /// <param name="crDto"></param>
    /// <returns></returns>
    Task<bool> CreateOrCancelAsync(CreateCancelArticleCollectionDto crDto);
}