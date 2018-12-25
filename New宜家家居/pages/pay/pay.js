
var goodList = []; //购物车
Page({

  /**
   * 页面的初始数据
   */
  data: {
    address: {},
    array: ['不限时送货时间', '工作日送货', '双休日、假日送货'],
    index: 0,
    hasAddress: false,
    'totalPrice': 0,
    'totalCount': 0,
  },
  select: function (e) {
    this.setData({
      index: e.detail.value
    })
  },
  goaddress: function () {
    wx.navigateTo({
<<<<<<< HEAD
      url: '../../pages/address/address',
=======
      url: '/pages/manageAddress/manageAddress',
>>>>>>> 1b8e28a0f2e80fff26e0233e85617fea50ea3232
    })
  },

  onShow: function () {
    var _this = this
    wx.getStorage({
      key: 'address',
      success(res) {
        _this.setData({
          address: res.data,
          hasAddress: true
        })
      }
    })
  },

  pay: function (e) {
    wx.showModal({
      title: '支付提示',
      content: '本程序仅用于演示，支付接口API已屏蔽！',
      showCancel: false,
      success: function (res) {
        if (res.confirm) {
          console.log('用户点击确定')
        }
      }
    })
  },

  /**
   * 生命周期函数--监听页面加载
   */
  onLoad: function (options) {
  //   var payId = options.id
  //   var data = json.homeIndex[payId]
  //   this.setData({
  //     data: data
  //   })



    var that = this;

    wx.request({
      url: 'http://localhost:8765/TProduct/GetCart',
      method: 'GET',
      data: {
        Id: 1,
      },
      success: function (res) {
<<<<<<< HEAD
=======
        console.log(res.data)
>>>>>>> 1b8e28a0f2e80fff26e0233e85617fea50ea3232
        that.setData({
          goodList: res.data,
          // hasList:true,length
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
        //totalCount += good.BuyNumber;
        totalPrice += good.BuyNumber * good.Price;
<<<<<<< HEAD
=======
      console.log(totalPrice);
      console.log(1111);
>>>>>>> 1b8e28a0f2e80fff26e0233e85617fea50ea3232
    }
    totalPrice = totalPrice.toFixed(2);
    this.setData({
      //'totalCount': totalCount,
      'totalPrice': totalPrice
    })
    
  },
})