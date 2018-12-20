//index.js
//获取应用实例
const app = getApp()

Page({
  data: {
    currentTap: 0,
    totalPrice: 0, // 总价，初始为0
    selectAllStatus: false // 全选状态，默认全选
  },

  onLoad: function () {
    var that = this;
    wx.request({
      url: 'http://localhost:8765/test/GetOrderlist?userid=1',
      method: 'get',
      success: function (q) {
        console.log(q)
        that.setData({
          lists: q.data,
        })
      }
    }),
      wx.request({
        url: 'http://localhost:8765/test/GetOrdrepayment?userid=1&state=0',
        method: 'get',
        success: function (q) {
          console.log(q)
          that.setData({
            daifu: q.data,
          })
        }
      })
      wx.request({
        url: 'http://localhost:8765/test/GetOrdrepayment?userid=1&state=1',
        method: 'get',
        success: function (q) {
          console.log(q)
          that.setData({
            daifa: q.data,
          })
        }
      }),
      wx.request({
        url: 'http://localhost:8765/test/GetOrdrepayment?userid=1&state=2',
        method: 'get',
        success: function (q) {
          console.log(q)
          that.setData({
            daishou: q.data,
          })
        }
      }),
      wx.request({
        url: 'http://localhost:8765/test/GetOrdrepayment?userid=1&state=3',
        method: 'get',
        success: function (q) {
          console.log(q)
          that.setData({
            daiping: q.data,
           })
         }
       })
  },
  shanchu: function (e) {
    var that = this;
    var id = e.currentTarget.dataset.id;
    wx.request({
      url: 'http://localhost:8765/test/Delete?id=' + id,
      method: 'get',
      success: function (q) {
        wx.showToast({
          title: '删除成功',
          success: function (res) {
            console.log(res.data);
            wx.redirectTo({
              url: 'http://localhost:8765/test/GetOrderlist?userid=1',
            })
          }

        })
      }

    })
  },
  // 跳转至详情页
  navigateDetail: function (e) {
    var id = e.currentTarget.dataset.id;//获取显示界面的Id值
    wx.navigateTo({
      url: '../commodity details_spxiangqing/index?id=' + e.currentTarget.dataset.id
    })
  },

  /*当前商品选中事件*/
  select(e) {
    const index = e.currentTarget.dataset.index;
    let carts = this.data.lists;
    var id = e.currentTarget.dataset.id; //获取显示界面的商品Id值
    const selected = carts[index].selected;
    carts[index].selected = !selected;
    this.setData({
      lists: carts
    });
    this.getTotalPrice();
  },
  /*当前商品选中事件*/
  selectt(e) {
    const index = e.currentTarget.dataset.index;
    let carts = this.data.daiping;
    var id = e.currentTarget.dataset.id; //获取显示界面的商品Id值
    const selected = carts[index].selected;
    carts[index].selected = !selected;
    this.setData({
      daiping: carts
    });
    this.getPrice();
  },
  /**
     * 购物车全选事件
     */
  selectAll(e) {
    let selectAllStatus = this.data.selectAllStatus;
    selectAllStatus = !selectAllStatus;
    let carts = this.data.lists;

    for (let i = 0; i < carts.length; i++) {
      carts[i].selected = selectAllStatus;
    }
    this.setData({
      lists: carts,
      selectAllStatus: selectAllStatus,
    });
    this.getTotalPrice();
  },


  /**
      * 购物车全选事件
      
  selectall(e) {
    let selectAllStatus = this.data.selectAllStatus;
    selectAllStatus = !selectAllStatus;
    let carts = this.data.daiping;

    for (let i = 0; i < carts.length; i++) {
      carts[i].selected = selectAllStatus;
    }
    this.setData({
      daiping:cart,
      selectAllStatus: selectAllStatus,
    });
    this.getPrice();
  },*/
  /*计算总价*/
  getTotalPrice() {
    let carts = this.data.lists; // 获取购物车列表
    let total = 0;
    for (let i = 0; i < carts.length; i++) { // 循环列表得到每个数据
      if (carts[i].selected) { // 判断选中才会计算价格
        total += carts[i].BuyNumber * carts[i].RealPrice; // 所有价格加起来
      }
    }
    this.setData({ // 最后赋值到data中渲染到页面
      lists: carts,
      totalPrice: total.toFixed(2),

    });
  },

  /*计算总价*/
  getPrice() {
    let carts = this.data.daiping; // 获取购物车列表
    let total = 0;
    for (let i = 0; i < carts.length; i++) { // 循环列表得到每个数据
      if (carts[i].selected) { // 判断选中才会计算价格
        total += carts[i].BuyNumber * carts[i].RealPrice; // 所有价格加起来
      }
    }
    this.setData({ // 最后赋值到data中渲染到页面
      daiping: carts,
      totalPrice: total.toFixed(2),

    });
  },


  order_status: function (e) {
    var current = e.currentTarget.dataset.current
    this.setData({
      currentTap: current
    })
  },

  commentOrder: function (e) {
    var id = e.currentTarget.dataset.id;
    wx.navigateTo({
      url: '../commentOrder/index?id=' + e.currentTarget.dataset.id
    })
  }
})
