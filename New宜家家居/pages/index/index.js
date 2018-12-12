var app = getApp()
Page({
  data: {
    imgUrls: [
      "/images/床02.jpg",
      "/images/床02.jpg",
      "/images/床03.jpg",
      "/images/床04.jpg",
      "/images/沙发02.jpg",
      "/images/沙发01.jpg",
      '/images/椅子02.jpg',


    ],




    indicatorDots: true,
    autoplay: true,
    interval: 2000,
    duration: 1000,
    windowWidth: 320,
    sortPanelTop: '0',
    sortPanelDist: '290',
    sortPanelPos: 'relative',
    noticeIdx: 0,


    "goodsList": [


    ],
    animationNotice: {}
  },


    // 跳转至详情页
    navigateDetail: function(e) {
      var id = e.currentTarget.dataset.aid;//获取显示界面的Id值
      wx.navigateTo({
        url: '../commodity details_spxiangqing/index?id='+ e.currentTarget.dataset.aid
      })
    },

   





  type: function () {
    wx.navigateTo({
      url: '/pages/type/type',
    })


  },


  onLoad: function () {
    var me = this;
    var animation = wx.createAnimation({
      duration: 400,
      timingFunction: 'ease-out',
    });
    me.animation = animation;
    wx.getSystemInfo({
      success: function (res) {
        me.setData({ windowWidth: res.windowWidth })
      }
    });


    console.log('onLoad');
  },
  startNotice: function () {
    var me = this;
    var notices = me.data.notices || [];
    if (notices.length == 0) {
      return;
    }


    var animation = me.animation;
    //animation.translateY( -12 ).opacity( 0 ).step();
    animation.translateY(0).opacity(1).step({ duration: 0 });
    me.setData({ animationNotice: animation.export() });


    var noticeIdx = me.data.noticeIdx + 1;
    if (noticeIdx == notices.length) {
      noticeIdx = 0;
    }


    // 更换数据
    setTimeout(function () {
      me.setData({
        noticeIdx: noticeIdx
      });
    }, 400);


    // 启动下一次动画
    setTimeout(function () {
      me.startNotice();
    }, 3000);
  },
  onShow: function () {
    this.startNotice();


  },
  onToTop: function (e) {
    if (e.detail.scrollTop >= 290) {
      this.setData({ sortPanelPos: 'fixed' });
    } else {
      this.setData({ sortPanelPos: 'relative' });
    }
    console.log(e.detail.scrollTop)


  },
  //首页显示数据
  onLoad: function () {
    var that = this;
    wx.request({
      url: 'http://localhost:8765/TProduct/GetProducts',
      method: 'GET',
      data: {
        Id: 1,
      },
      success: function (res) {
        console.log(res.data)
        that.setData({
          vabage: res.data
        })


      }
    })
  },




  //跳转到床的页面
  bed: function () {
    var id = 1;//获取显示界面的Id值
    wx.navigateTo({
      url: '/pages/bed_chuang/index'
    })
  },

//跳转沙发的页面
  sofa: function () {
    wx.navigateTo({
      url: '/pages/sofa_shafa/index',
    })
  },
  //跳转椅子的页面
  chair_yizi: function () {
    wx.navigateTo({
      url: '/pages/chair_yizi/index',
    })
  },
  //跳转热卖的页面
  sale_remai: function () {
    wx.navigateTo({
      url: '/pages/hot sale_remai/index',
    })
  },


})