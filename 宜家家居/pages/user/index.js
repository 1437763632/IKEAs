//index.js
//获取应用实例
var app = getApp()
var sta = require("../../utils/statistics.js");
Page({
  data: {
    userInfo: {},
  },
  onShow:function (){
    sta();
  },
  onLoad: function () {
    var that = this
    app.getUserInfo(function (userInfo){
         that.setData({
              userInfo:userInfo
          });
    })
  },
  
  //登录用户信息
  userdata:function (){
      wx.navigateTo({url: "/pages/userdata/index"})
  },

  //我的收藏
  collect_shouchang:function(){
    wx.navigateTo({
      url: '/pages/collect_shouchang/index',
    })
  },

  //优惠券
  my_coupon_youhuiquan: function () {
    wx.navigateTo({ url: "/pages/my_coupon_youhuiquan/index" });
  },
  youhui:function(){
    wx.navigateTo({
      url:'/pages/youhui/index',
    })
  },

  //我的地址
  address: function (){
      wx.navigateTo({url:"/pages/address/index"});
  },


  
  
  order:function (){
    //订单
    wx.navigateTo({url:"/pages/order/index"})
  },

  keep:function () {
    //收藏
  },
  share:function (){
    //分享
  }
})
