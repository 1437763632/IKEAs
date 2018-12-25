// pages/mycollect/mycollect.js
var goodList = [];
Page({

  /**
   * 页面的初始数据
   */
  data: {
    delBtnWidth: 180,

    goodList: '',//存储请求回来的数组
    ini: 0,
    uhide: '',
    add_car_num: 0,//控制是否初次进入界面
    delBtnWidth: 134,//删除按钮宽度单位（rpx）
   // Price: '0.00'//价钱
  },

 onLoad: function (options) {
    //获取收货地址 省略
    var that = this;

    wx.request({
      url: 'http://localhost:8765/TProduct/GetCart',
      method: 'GET',
      data: {
        Id: 1,
      },
      success: function (res) {
        that.setData({
          goodList: res.data,
          // hasList:true,length
        })
      }

    })
  },

  edit: function (e) {
    //编辑收货地址 省略
  },

  add: function () {
    //增加收货地址 省略
  },

  delItem: function (e) {
    var id = e.currentTarget.dataset.id;
    var index = e.currentTarget.dataset.index;
    this.data.goodList.splice(index, 1);
    this.setData({
      goodList: this.data.goodList
    })
  },

  touchS: function (e) {
    if (e.touches.length == 1) {
      this.setData({
        //设置触摸起始点水平方向位置
        startX: e.touches[0].clientX
      });
    }
  },

  touchM: function (e) {
    if (e.touches.length == 1) {
      //手指移动时水平方向位置
      var moveX = e.touches[0].clientX;
      //手指起始点位置与移动期间的差值
      var disX = this.data.startX - moveX;
      var delBtnWidth = this.data.delBtnWidth;
      var txtStyle = "";
      if (disX == 0 || disX < 0) {//如果移动距离小于等于0，文本层位置不变
        txtStyle = "left:0rpx";
      } else if (disX > 0) {//移动距离大于0，文本层left值等于手指移动距离
        txtStyle = "left:-" + disX + "rpx";
        if (disX >= delBtnWidth) {
          //控制手指移动距离最大值为删除按钮的宽度
          txtStyle = "left:-" + delBtnWidth + "rpx";
        }
      }
      //获取手指触摸的是哪一项
      var index = e.currentTarget.dataset.index;
      var list = this.data.goodList;
      list[index]['txtStyle'] = txtStyle;
      //更新列表的状态
      this.setData({
        goodList: list
      });
    }
  },
  touchE: function (e) {
    if (e.changedTouches.length == 1) {
      //手指移动结束后水平位置
      var endX = e.changedTouches[0].clientX;
      //触摸开始与结束，手指移动的距离
      var disX = this.data.startX - endX;
      var delBtnWidth = this.data.delBtnWidth;
      //如果距离小于删除按钮的1/2，不显示删除按钮
      var txtStyle = disX > delBtnWidth / 2 ? "left:-" + delBtnWidth + "rpx" : "left:0rpx";
      //获取手指触摸的是哪一项
      var index = e.currentTarget.dataset.index;
      var list = this.data.goodList;
      var del_index = '';
      disX > delBtnWidth / 2 ? del_index = index : del_index = '';
      list[index].txtStyle = txtStyle;
      //更新列表的状态
      this.setData({
        goodList: list,
        del_index: del_index
      });
    }
  },
  //清空缓存收藏
  go: function (e) {
    this.setData({
      goodList: []
    })
    wx.setStorageSync("goodList", [])
  },

})
