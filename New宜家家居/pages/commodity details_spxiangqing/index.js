
Page({

  data: {

    //轮播图开始位置
    // banner
    imgUrls: [
      // "/images/床02.jpg",
      // "/images/床02.jpg",
      // "/images/床03.jpg",
      // "/images/床04.jpg",
      // "/images/沙发02.jpg",
      // "/images/沙发01.jpg",    

    ],
    indicatorDots: true, //是否显示面板指示点
    autoplay: true, //是否自动切换
    interval: 2000, //自动切换时间间隔,3s
    duration: 1000, //  滑动动画时长1s    
  },
  //轮播图结束位置 

  //=========================

  onLoad: function (options) {
    var that = this;
    var id = parseInt(options.id);
    console.log(id);
    //获取产品详情
    wx.request({
      url: 'http://localhost:8765/wyTProductDetail/SSS?productID='+id,
      method:'get',
      success:function(res){
        console.log(res);
        that.setData({
           itemSize: res.data, 
           })
      }
    })          
},
  AddCarts:function(){
          wx.request({
            url: 'http://localhost:8765/TProduct/AddCarts',
            data: '',
            header: {},
            method: 'GET',
            dataType: 'json',
            responseType: 'text',
            success: function(res) {},
            fail: function(res) {},
            complete: function(res) {},
          })
  },

  //详情
  select_this: function (e) {

    var current = e.currentTarget.dataset.current;
    this.setData({
      tabCurrent: current
    })
  },


  //购买
  goBuy: function () {
    var isShow = !this.data.isShow;
    this.setData({
      isShow: isShow
    })
  },
  //关闭
  close: function () {
    this.setData({
      isShow: false
    })
  },


  //类型
  chooseType: function (e) {
    var chooseType = e.currentTarget.dataset.type;
    this.setData({
      chooseType: chooseType

    })
  },
  //尺寸
  chooseType1: function (e) {
    var chooseType1 = e.currentTarget.dataset.type;
    this.setData({
      chooseType1: chooseType1
    })
  },
  //数量加减

  buyCount: function (e) {
    var id = e.currentTarget.id;
    var count = this.data.buyCount;
    if (id == "add") {
      count = (count > 0) ? count + 1 : 1
    } else {
      count = (count > 0) ? count - 1 : 0
    }
    this.setData({ buyCount: count });

    this.buyNow('');
  },


  order:function(){
   wx.navigateTo({
     url: "/pages/order/order",
   })
  },



  // // 立即购买
  // immeBuy() {
  //   wx.showToast({
  //     title: '购买成功',
  //     icon: 'success',
  //     duration: 2000
  //   });
  // },
})
