//index.js
//获取应用实例
const app = getApp()

Page({
  data: {
    tapCurrent: 0,
  },

  onLoad: function () {
    var that =this;
    // 根据用户ID获取地址信息 
    wx.getStorage({
      key: 'token',
      success: function(res) {
        wx.request({
          url: 'http://localhost:8765/ShoppingCar/GetAddress',
          method: 'get',
          header:{
              'content-type': 'application/json',
              'Authorization': 'BasicAuth ' + res.data
          },
          data: {
            UserID: 0,
          },
          success: function (res) {
            console.log(res.data);
            that.setData({
              address: res.data
            })
          }
        })
      }
    })
    
  },
// 根据主键ID删除地址信息   
  DelAddress: function (e) {
    var id = e.currentTarget.dataset.aid
    console.log(id)
    wx.getStorage({
      key: 'token',
      success: function(res) {
        wx.request({
          url: 'http://localhost:8765/ShoppingCar/DelAddress?ID=' + id,
          method: 'get',
          header:{
            'content-type':'applicatio/json',
            'Authorization': 'BasicAuth ' + res.data
          },
          success: function () {
            wx.showToast({
              title: '删除成功',
              success: function (res) {
                console.log(res.data);
                wx.redirectTo({
                  url: '/pages/manageAddress/manageAddress',
                })
              }
            })

          }
        })
      },
    
    })
   
  },



  // userInfo: function () {
  //   wx.navigateTo({
  //     url: '/pages/userInfo/userInfo'
  //   })
  // },
  // bindDateChange: function (e) {
  //   this.setData({
  //     date: e.detail.value
  //   })
  // },
  // discount: function (e) {
  //   var current = e.currentTarget.dataset.current;
  //   this.setData({
  //     tapCurrent: current
  //   })
  // },
 
  //跳转到添加地址(或修改)
  newAddress: function () {
    wx.navigateTo({
      url: '/pages/newAddress/newAddress'
    })
  },
  UptAddress: function (resd) {
    var id = resd.currentTarget.dataset.aid;
    console.log(id)
    wx.navigateTo({
      url: '/pages/UpdateAddress/index?ID=' + id,
    })
  },
})
