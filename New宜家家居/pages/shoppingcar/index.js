// pages/shopcart/shopcart.js

var goodList= [];//购物车
Page({
  /**
   * 页面的初始数据
   */

  data: {
   
    hasList: false, // 列表是否有数据
    'checked': false,
    'checkAll': false,// 全选状态，默认全选
    'totalCount': 0,
   'totalPrice': 0
  },
  onLoad: function () {
    var that = this;
    wx.request({
      url: 'http://localhost:8765/TProduct/GetCart',
      method: 'GET',
      data: {
        Id: 1,
      },
      success: function (res) {
         //console.log(res.data);
        that.setData({
          goodList: res.data,
         // hasList:true,length
        })
      }
      
    })
  
  },
  onShow: function () {
    var goodList = wx.getStorageSync("goodList")
    this.setData({
      cartList: false,
      goodList: goodList
    })
    this.cartItems

  },

  //删除购物车单个缓存
  shanchu: function (e) {
    var goodList = this.data.goodList  //获取购物车列表
    var index = e.currentTarget.dataset.index  //获取当前点击事件的下标索引
    goodList.splice(index, 1)
    this.setData({
      goodList: goodList
    });
    if (goodList.length) {
      this.setData({
        cartList: false
      });
    }
    this.calculateTotal()
    wx.setStorageSync("goodList", goodList)
  },
  //提示
  // go: function (e) {
  //   this.setData({
  //     goodList: []
  //   })
  //   wx.setStorageSync("goodList", [])
  // },

//
  order:function(){
    wx.navigateTo({
      url:"/pages/order/order",
    })
  },

  commodity: function (e) {
    wx.navigateTo({
      url: "/pages/commodity details_spxiangqing/index?id",
    })
  },




  //  * 计算商品总数

  calculateTotal: function () {
    var goodList = this.data.goodList;
    var totalCount = 0;
    var totalPrice = 0;
    for (var i = 0; i < goodList.length; i++) {
      var good = goodList[i];
      if (good.checked) {
        totalCount += good.SumNumber;
        totalPrice += good.SumNumber * good.Price;
      }
    }
    totalPrice = totalPrice.toFixed(2);
    this.setData({
      'totalCount': totalCount,
      'totalPrice': totalPrice
    })
  },


  /**
   * 用户点击商品减1
   */
  subtracttap: function (e) {
    var index = e.target.dataset.index;
    var goodList = this.data.goodList;
    var count = goodList[index].SumNumber;
    if (count <= 1) {
      return;
    } else {
      goodList[index].SumNumber--;
      this.setData({
        'goodList': goodList
      });
      this.calculateTotal();
    }
  },


  /**
   * 用户点击商品加1
   */
  addtap: function (e) {
    var index = e.target.dataset.index;
    var goodList = this.data.goodList;
    var count = goodList[index].SumNumber;
    goodList[index].SumNumber++;
    this.setData({
      'goodList': goodList
    });
    this.calculateTotal();
  },
  /**
   * 用户选择购物车商品
   */
  checkboxChange: function (e) {
    console.log(123)
    console.log('checkbox发生change事件，携带value值为：', e.detail.value);   
    var checkboxItems = this.data.goodList;
    var values = e.detail.value;
    for (var i = 0; i < checkboxItems.length; ++i) {
      checkboxItems[i].checked = false;
      for (var j = 0; j < values.length; ++j) {
        if (checkboxItems[i].Id == values[j]) {
          checkboxItems[i].checked = true;
          break;
        }
      }
    }


    var checkAll = false;
    if (checkboxItems.length == values.length) {
      checkAll = true;
    }


    this.setData({
      'goodList': checkboxItems,
      'checkAll': checkAll
    });
    this.calculateTotal();
  },


  /**
   * 用户点击全选
   */
  selectalltap: function (e) {
    console.log('用户点击全选，携带value值为：', e.detail.value);
    var value = e.detail.value;
    var checkAll = false;
    if (value && value[0]) {
      checkAll = true;
    }


    var goodList = this.data.goodList;
    for (var i = 0; i < goodList.length; i++) {
      var good = goodList[i];
      good['checked'] = checkAll;
    }


    this.setData({
      'checkAll': checkAll,
      'goodList': goodList
    });
    this.calculateTotal();
  }

})








































// Page({
//   data: {
//     windowWidth: wx.getSystemInfoSync().windowWidth,
//     windowHeight: wx.getSystemInfoSync().windowHeight,
//     hiddenSmallImg: true,
//     countsArray: [1, 2, 3, 4, 5, 6, 7, 8, 9, 10],
//     productCounts: 1,
//     currentTabsIndex: 0,
//     cartTotalCounts: 0,
//   },