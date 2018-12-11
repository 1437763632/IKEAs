
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

  onLoad: function () {
    var that = this;
    //获取产品尺寸
    wx.request({
      url: 'http://localhost:8765/ShoppingCar/GetProduct_Sizes',
      method:'get',
      // data: {
      //   Id: 2,
      // },
      success:function(res){
        console.log(res);
        that.setData({
           itemSize: res.data, 
           })
      }
    })         

     //获取价格
        wx.request({
          url: 'http://localhost:8765/TProduct/GetProduct',
          method: 'GET',
          data: {
            Id: 2,
          },
          success: function (res) {
            console.log(res.data)
            that.setData({
              itemPrice: res.data
            })
          }
        })   

    //获取类型
    wx.request({
      url: 'http://localhost:8765/ShoppingCar/getProductType',
      method: 'GET',
      data: {
        ProductTypeID: 2,
      },
      success: function (res) {
        console.log(res.data)
        that.setData({
          itemType: res.data
        })
      }
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






  // // 跳到购物车
  // addCar() {
  //   wx.switchTab({
  //     url: '/pages/detailAAA/detail'
  //   })
  // },
  // // 立即购买
  // immeBuy() {
  //   wx.showToast({
  //     title: '购买成功',
  //     icon: 'success',
  //     duration: 2000
  //   });
  // },
})
