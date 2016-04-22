using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TeYou.Billiards
{
    /// <summary>
    /// 通用功能接口
    /// </summary>
    /// <typeparam name="TModel">返回的实体类型</typeparam>
    /// <typeparam name="TPrimaryKey">该实体的主键类型</typeparam>
    public interface IBaseService<TModel, TPrimaryKey>
        where TModel : class,new()
        where TPrimaryKey : struct
    {
        /// <summary>
        /// 根据id获取单个实体
        /// </summary>
        /// <returns></returns>
        TModel Get(TPrimaryKey gid);

        /// <summary>
        /// 增加
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        bool Add(TModel model);

        /// <summary>
        /// 更新
        /// </summary>
        /// <returns></returns>
        bool Update(TModel model);
        /// <summary>
        /// 删除
        /// </summary>
        /// <returns></returns>
        bool Delete(TPrimaryKey gid);

    }
}
