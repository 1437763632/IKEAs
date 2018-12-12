// pages/bed_chuang/index.js
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
      url: 'http://localhost:8765/TProduct/GetProductchair?ProductTypeID=2',
      method: 'get',
      success: function (q) {
        console.log(q)
        that.setData({
          chuang: q.data,
        })
      }
    })
  },
  // 跳转至详情页
  navigateDetail: function (e) {
    var id = e.currentTarget.dataset.aid;//获取显示界面的Id值
    wx.navigateTo({
      url: '../commodity details_spxiangqing/index?id=' + e.currentTarget.dataset.aid
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