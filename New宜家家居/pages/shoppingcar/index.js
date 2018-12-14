// pages/shopcart/shopcart.js

var goodList= [];//购物车
Page({
  /**
   * 页面的初始数据
   */

  data: {

    // goodList: [
    //   {
    
    //     'name': 'goodList.ProductName',
    //     'author': '余光中，林清玄，白先勇 等 著',
    //     //'isbn': '9787535482051',
    //     'cover': '/images/床02.jpg',
    //     'desc': '缅怀乡愁诗人余光中。余光中、林清玄、白先勇联手巨献，重温经典，送别先生。总有一天，你会明白，孤独才是生命的常态。一部直击现代人孤独的精神献礼。中国散文协会推荐！',
    //     'press': '长江文艺出版社',
    //     'price': 8888,
    //     'count': 1
       
    //   },
      // {

      //   'name': 'goodList.ProductName',
      //   'author': '余光中，林清玄，白先勇 等 著',
      //   'isbn': '9787535482058',
      //   'cover': '/images/床02.jpg',
      //   'desc': '缅怀乡愁诗人余光中。余光中、林清玄、白先勇联手巨献，重温经典，送别先生。总有一天，你会明白，孤独才是生命的常态。一部直击现代人孤独的精神献礼。中国散文协会推荐！',
      //   'press': '长江文艺出版社',
      //   'price': 888,
      //   'count': 1,
      //   'checked': false
      // },
     
    //],

   
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
        // console.data(res.data);
        that.setData({
          goodList: res.data,
         // hasList:true,
        })

      }
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