using System;
using System.Data;
using System.Collections.Generic;
using CaiCong.DAL;
using CaiCongModel;
namespace CaiCong.BLL
{
	/// <summary>
	/// ShoppingCarTable
	/// </summary>
	public partial class ShoppingCarTableBLL
	{
        DAL.ShoppingCarTableDAL scDal=new DAL.ShoppingCarTableDAL();
        /// <summary>
        /// 添加一件商品到购物车
        /// </summary>
        /// <param name="shoppingCar">shoppingCar对象</param>
        /// <returns>是否成功</returns>
	    public bool Add(CaiCongModel.ShoppingCarTable shoppingCar)
        {
            return scDal.Add(shoppingCar);
        }
        /// <summary>
        /// 删除一个购物车中的商品
        /// </summary>
        /// <param name="ID">购物车的ID</param>
        /// <returns>是否成功</returns>
	    public bool Del(int ID)
        {
            return scDal.Del(ID);
        }
        /// <summary>
        /// 更改一个商品的数量
        /// </summary>
        /// <param name="GoodsNumber">商品的数量</param>
        /// /// <param name="ID">购物车的ID</param>
        /// <returns>是否成功</returns>
	    public bool Update(int GoodsNumber,int ID)
        {
            return scDal.Update(GoodsNumber,ID);
        }
        /// <summary>
        /// 根据用户ID 查询购物车中的商品
        /// </summary>
        /// <param name="UserID"></param>
        /// <returns></returns>
	    public List<ShoppingCarTable> SelectList(int UserID)
        {
            return scDal.SelectList(UserID);
        }
    }
}

