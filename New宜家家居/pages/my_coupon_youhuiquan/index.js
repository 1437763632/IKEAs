// pages/my_coupon_youhuiquan/index.js
Page({

  /**
   * 页面的初始数据
   */
  data: {

  },

  /**
   * 生命周期函数--监听页面加载
   */
  onLoad: function () {
    var that = this;
    wx.request({
      url: 'http://localhost:8765/TDisCount/GetDisCount?id=3',
      method: 'get',
      success: function (q) {
        console.log(q)
        that.setData({
          Pricec: q.data,
        })
      }
    })
  }
})