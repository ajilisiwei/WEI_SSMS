using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeYou.Billiards;
using WEI_SSMS_DAL;

namespace WEI_SSMS_SERVICE
{
    public abstract class BaseService<TModel, TEFModel, TPrimaryKey> : IBaseService<TModel, TPrimaryKey>
        where TModel : class,new()
        where TEFModel : class,new()
        where TPrimaryKey : struct
    {
        private DbContext _Context = new SSMSEntities();

        /// <summary>
        /// EF实体转换为Model
        /// </summary>
        /// <param name="oModel"></param>
        /// <returns></returns>
        public virtual TModel ConvertToModel(TEFModel EfModel)
        {
            try
            {
                string strConvert = Common.JsonSe(EfModel);
                return Common.JsonDe<TModel>(strConvert);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Model实体转换为EF实体
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public virtual TEFModel ConvertToModel(TModel model)
        {
            try
            {
                string strConvert = Common.JsonSe(model);
                return Common.JsonDe<TEFModel>(strConvert);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 根据条件获取符合条件的实体集
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        public IEnumerable<TModel> GetSearchList(System.Linq.Expressions.Expression<Func<TEFModel, bool>> where)
        {
            try
            {
                using (_Context)
                {
                    IEnumerable<TEFModel> lstEf = _Context.Set<TEFModel>().Where(where);
                    List<TModel> lstModel = new List<TModel>();
                    foreach (TEFModel model in lstEf)
                    {
                        lstModel.Add(ConvertToModel(model));
                    }
                    return lstModel;
                }
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public virtual TModel Get(TPrimaryKey gid)
        {
            return ConvertToModel(Find(gid));
        }
        protected TEFModel Find(TPrimaryKey gid)
        {
            return _Context.Set<TEFModel>().Find(gid);
        }

        public bool Add(TModel model)
        {
            try
            {
                if (null == model) return false;
                TEFModel efModel = ConvertToModel(model);
                _Context.Entry<TEFModel>(efModel).State = EntityState.Added;
                return Commit();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Update(TModel model)
        {
            try
            {
                if (null == model) return false;
                TEFModel efModel = ConvertToModel(model);
                _Context.Entry<TEFModel>(efModel).State = EntityState.Modified;
                return Commit();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 根据主键进行删除
        /// </summary>
        /// <param name="gid"></param>
        /// <returns></returns>
        public bool Delete(TPrimaryKey gid)
        {
            try
            {
                return Delete(gid, true);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public virtual bool Delete(TPrimaryKey gid, bool isSave)
        {
            try
            {
                TModel model = Get(gid);
                if (null == model) return false;
                return Delete(model, isSave);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 根据实体删除
        /// </summary>
        /// <param name="model"></param>
        /// <param name="isSave"></param>
        /// <returns></returns>
        public virtual bool Delete(TModel model, bool isSave)
        { 
            try
            {
                if (null == model) return true;
                TEFModel efModel = ConvertToModel(model);
                _Context.Entry<TEFModel>(efModel).State = EntityState.Deleted;
                bool bResult = Commit(isSave);
                return bResult;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 提交所做的更改
        /// </summary>
        /// <returns></returns>
        public virtual bool Commit(bool isSave = true)
        {
            if (!isSave) return true;
            try
            {
                bool bResult = false;
                if (null == _Context) return bResult;
                bResult = _Context.SaveChanges() > 0;
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
