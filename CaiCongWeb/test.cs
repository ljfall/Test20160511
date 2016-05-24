using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CaiCongModel;
using CaiCong.BLL;

namespace CaiCongWeb
{
    partial class test
    {
        //订单
        OrderTableBLL otBll = new OrderTableBLL();
        //购物车
        ShoppingCarTableBLL scBll=new ShoppingCarTableBLL();
        //收藏
        CollectTableBLL ctBll=new CollectTableBLL();
        //优惠劵
        CouponTableBLL couponBll=new CouponTableBLL();
        //敏感词
        SensitiveWordTableBLL swBll=new SensitiveWordTableBLL();
        //评价表
        AppraiseTableBLL atBll=new AppraiseTableBLL();
        public bool OrderDel()
        {
            return otBll.Del("12345");
        }
        public List<OrderTable> OrderSelect()
        {

            return otBll.SelectList(12);
        }
        public bool ShopCarAdd()
        {
            ShoppingCarTable shoppingCar=new ShoppingCarTable();
            shoppingCar.GoodsID = 1234;//商品ID
            shoppingCar.GoodsNumber = 666;//商品数量
            shoppingCar.ThisTime=DateTime.Now;
            shoppingCar.UserID = 12;//用户ID
            return scBll.Add(shoppingCar);
        }
        public bool ShopCarDel()
        {
            return scBll.Del(3);
        }
        public bool ShopCarUpdate()
        {

            return scBll.Update(5,12);//商品的数量和商品的ID 
        }
        public List<ShoppingCarTable> ShopCarSelect()
        {

            return scBll.SelectList(2);
        }
        public bool CollectAdd()
        {
            CollectTable collect=new CollectTable();
            collect.CollectTime=DateTime.Now;
            collect.CollectUserID = 2;
            collect.GoodsID = 2;
            return ctBll.Add(collect);
        }
        //根据商品ID删除收藏
        public bool CollectDelByGoodsId()
        {

            return ctBll.DelByGoodsID(2);
        }
        //根据用户ID删除收藏
        public bool CollectDelByUserId()
        {

            return ctBll.DelByUserID(2);
        }
        public object CollectSelect()
        {
            //根据用户ID查询,返回单一值
            return ctBll.Select(2);
        }
        public bool SensitiveWordAdd()
        {
            SensitiveWordTable sensitiveWord=new SensitiveWordTable();
            sensitiveWord.SensitiveWord = "敏感词";//敏感词
            sensitiveWord.SensitiveWordGenre = 1;//敏感等级
            sensitiveWord.Substitutes = "***";//敏感词替代词
            return swBll.Add(sensitiveWord);
        }
        public bool SensitiveWordDel()
        {

            return swBll.Del(3);
        }
        public bool SensitiveWordSelecJZ()
        {
            //暂时没有使用
            return false;
        }
        public bool SensitiveWordSelectMH()
        {
            //暂时没有使用
            return false;
        }
        public bool SensitiveWordSelectByDJ()
        {
            //暂时没有使用
            return false;
        }
        public bool CouponAdd()
        {
            CouponTable coupon=new CouponTable();
            coupon.UserID = 2;//优惠券所属用户的ID
            coupon.GetTime=DateTime.Now;//获取时间
            coupon.ShopID = 2;//对应店铺ID
            coupon.Subduction = 32;//优惠券消减值
            coupon.UseMoney = 100;//优惠券满足值
            return couponBll.Add(coupon);
        }
        //通过ID删除优惠券
        public bool CouponDelByID()
        {

            return couponBll.DelByID(1);
        }
        //通过商铺ID删除优惠券
        public bool CouponDelByShopID()
        {

            return couponBll.DelByShopID(2);
        }
        //通过用户ID删除优惠券
        public bool CouponDelByUserID()
        {

            return couponBll.DelByUserID(3);
        }

        //通过店铺ID查询优惠券
        public List<CouponTable> CouponSelectByShopId()
        {

            return couponBll.SelectByShopIDList(2);
        }
        //通过用户ID查询优惠券
        public List<CouponTable> CouponSelectByUserId()
        {

            return couponBll.SelectByUserIDList(2);
        }
        public bool AppraiseAdd()
        {

            return false;
        }
        public bool AppraiseDelByID()
        {

            return false;
        }
        public bool AppraiseDelByUserID()
        {

            return false;
        }
        public bool AppraiseDelByGoodsID()
        {

            return false;
        }
        public bool AppraiseSelectByID()
        {

            return false;
        }
        public bool AppraiseSelectByUserID()
        {

            return false;
        }
        public bool AppraiseSelectByGoodsID()
        {

            return false;
        }
        public bool AppraiseSelectByAll()
        {

            return false;
        }
    }
}