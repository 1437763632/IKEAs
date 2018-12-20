// pages/FindShop/index.js
Page({

  /**
   * 页面的初始数据
   */
  data: {

  },

  //首页显示数据
  onLoad: function (resd) {   
    var that = this;     
    var productName = resd.ProductName;
    console.log(productName);
    console.log(1111);
    wx.request({
      url: 'http://localhost:8765/TProduct/GetProductName',
      data:{
        ProductName: productName
      },
      method: 'GET',
      success: function (res) {
        console.log(res.data)
        that.setData({
          vabage: res.data
        })


      }
    })
  },

  /**
   * 生命周期函数--监听页面初次渲染完成
   */
  onReady: function () {

  },

  /**
   * 生命周期函数--监听页面显示
   */
  onShow: function () {

  },

  /**
   * 生命周期函数--监听页面隐藏
   */
  onHide: function () {

  },

  /**
   * 生命周期函数--监听页面卸载
   */
  onUnload: function () {

  },

  /**
   * 页面相关事件处理函数--监听用户下拉动作
   */
  onPullDownRefresh: function () {

  },

  /**
   * 页面上拉触底事件的处理函数
   */
  onReachBottom: function () {

  },

  /**
   * 用户点击右上角分享
   */
  onShareAppMessage: function () {

  }
})