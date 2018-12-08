var app = getApp()
Page({
  data: {
    imgUrls: [
      '/images/椅子02.jpg',
      'https://onegoods.nosdn.127.net/resupload/2016/9/18/4082e075e9ff72110bb1d73750be065b.jpg',
      'https://onegoods.nosdn.127.net/resupload/2016/9/20/01d732b0c46a38fc07bbc887dfe23af9.jpg',
      'https://onegoods.nosdn.127.net/resupload/2016/9/19/777e4b1711fb1b0283726cb0b197e8ba.jpg',
      'https://onegoods.nosdn.127.net/resupload/2016/9/20/f2f210633ca371ea6dc56a4b8916a15d.jpg',
      'https://onegoods.nosdn.127.net/resupload/2016/9/21/33c38d5283a862b2523fe2e085355cb2.jpg',
      'https://res.126.net/p/dbqb/resupload/onlinepath/2016/7/28/0/69e1275c4460f97f2d4b26d716348892.jpg'
      
    ],

  
    indicatorDots: true,
    autoplay: true,
    interval: 5000,
    duration: 1000,
    windowWidth: 320,
    sortPanelTop: '0',
    sortPanelDist: '290',
    sortPanelPos: 'relative',
    noticeIdx: 0,
   
     "goodsList": [
    //   {
    //     "goods": {
    //       "buyUnit": 10,
    //       "desc": "唯一的不同，是处处不同",
    //       "id": 1093,
    //       "imgUrl": "http://res.126.net/p/dbqb/one/93/1093/a9cf9389428aa00af8508727427cb1c5.png",
    //       "name": "【预售】Apple iPhone6s Plus 128G 颜色随机",
    //       "tag": "ten"
    //     },
    //     "period": 211116272,
    //     "takeRate": 0.01,
    //     "takeChances": 70,
    //     "totalChances": 8090
    //   },
      // {
      //   "goods": {
      //     "buyUnit": 1,
      //     "desc": "颜色随机",
      //     "id": 348,
      //     "imgUrl": "http://res.126.net/p/dbqb/one/98/348/b73494078d526fcb5ead4201ec29daef.png",
      //     "name": "Apple Watch Sport 38毫米 铝金属表壳 运动表带",
      //     "tag": ""
      //   },
      //   "period": 211116207,
      //   "takeRate": 0.19,
      //   "takeChances": 632,
      //   "totalChances": 3288
      // },
      // {
      //   "goods": {
      //     "buyUnit": 1,
      //     "desc": "配备 Retina 显示器",
      //     "id": 510,
      //     "imgUrl": "http://res.126.net/p/dbqb/one/112/112/b246c1f56b1b10de718d21a6aa7349ac.png",
      //     "name": "Apple MacBook Pro 15.4英寸笔记本",
      //     "tag": ""
      //   },
      //   "period": 211116244,
      //   "takeRate": 0.26,
      //   "takeChances": 3760,
      //   "totalChances": 14288
      // },
      // {
      //   "goods": {
      //     "buyUnit": 10,
      //     "desc": "超长续航 智能防盗",
      //     "id": 1168,
      //     "imgUrl": "http://res.126.net/p/dbqb/one/168/1168/6abc05894e903b9749166c224d739838.png",
      //     "name": "【预售】小牛电动N1电动踏板车 动力版 约11月20日发货",
      //     "tag": "ten"
      //   },
      //   "period": 211116256,
      //   "takeRate": 0.05,
      //   "takeChances": 300,
      //   "totalChances": 5990
      // },
      // {
      //   "goods": {
      //     "buyUnit": 1,
      //     "desc": "因工艺原因重量略有浮动",
      //     "id": 979,
      //     "imgUrl": "http://res.126.net/p/dbqb/one/229/979/defc72da941c4705fcdbb2a7ee03dbf1.png",
      //     "name": "周生生 黄金 足金旋转木马吊坠",
      //     "tag": ""
      //   },
      //   "period": 211116138,
      //   "takeRate": 0.17,
      //   "takeChances": 514,
      //   "totalChances": 2999
      // },
      // {
      //   "goods": {
      //     "buyUnit": 10,
      //     "desc": "颜色随机 支持专柜验货",
      //     "id": 673,
      //     "imgUrl": "http://res.126.net/p/dbqb/one/173/673/47c126b7bb39524d3d62151b2ef76629.png",
      //     "name": "Coach 蔻驰 抛光粒面皮革铆钉COACH CENTRAL手提包",
      //     "tag": "ten"
      //   },
      //   "period": 211115685,
      //   "takeRate": 0.13,
      //   "takeChances": 630,
      //   "totalChances": 4950
      // },
      // {
      //   "goods": {
      //     "buyUnit": 10,
      //     "desc": "颜色随机 美式奢侈生活风格的代表",
      //     "id": 943,
      //     "imgUrl": "http://res.126.net/p/dbqb/one/193/943/0994bfbd54c668fed6db160afd84eff4.png",
      //     "name": "MICHAEL KORS 迈克高仕 十字纹皮革钱包",
      //     "tag": "ten"
      //   },
      //   "period": 211114592,
      //   "takeRate": 0.45,
      //   "takeChances": 680,
      //   "totalChances": 1500
      // },
      // {
      //   "goods": {
      //     "buyUnit": 1,
      //     "desc": "吴晓波酿吴酒 一半清醒一半醉",
      //     "id": 1095,
      //     "imgUrl": "http://res.126.net/p/dbqb/one/95/1095/0176dd96dcc8b4188e6b2bbf85102304.png",
      //     "name": "【预售】吴酒 2016年贺年年酒 圣诞节开始派送",
      //     "tag": ""
      //   },
      //   "period": 211116226,
      //   "takeRate": 0.04,
      //   "takeChances": 7,
      //   "totalChances": 199
      // },
      // {
      //   "goods": {
      //     "buyUnit": 10,
      //     "desc": "珍贵绝伦",
      //     "id": 140,
      //     "imgUrl": "http://res.126.net/p/dbqb/one/140/140/ea7f0892ce49c332e2280513ee94a439.png",
      //     "name": "中国黄金 AU9999万足金50g薄片",
      //     "tag": "ten"
      //   },
      //   "period": 211116228,
      //   "takeRate": 0.95,
      //   "takeChances": 14200,
      //   "totalChances": 14990
      // }, {
      //   "goods": {
      //     "buyUnit": 10,
      //     "desc": "唯一的不同，是处处不同",
      //     "id": 1093,
      //     "imgUrl": "http://res.126.net/p/dbqb/one/93/1093/a9cf9389428aa00af8508727427cb1c5.png",
      //     "name": "【预售】Apple iPhone6s Plus 128G 颜色随机",
      //     "tag": "ten"
      //   },
      //   "period": 211116272,
      //   "takeRate": 0.01,
      //   "takeChances": 70,
      //   "totalChances": 8090
      // }
   ],
    animationNotice: {}
  },
  // onReady: function () {

  // },
//跳转到详情页
  product:function(){
wx.navigateTo({
  url:'/pages/commodity details_spxiangqing/index',
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



//跳转到床的页面
bed: function () {
    wx.navigateTo({
      url: '/pages/bed_chuang/index'
    })
  },

  sofa:function(){wx.navigateTo({
    url:'/pages/sofa_shafa/index',
  })
  },
  chair_yizi:function(){
    wx.navigateTo({
      url:'/pages/chair_yizi/index',
    })
  },
  sale_remai:function(){
    wx.navigateTo({
      url:'/pages/hot sale_remai/index',
    })
  },

})















// var config = require('../../config.js')
// var http = require('../../utils/httpHelper.js')
// //index.js
// //获取应用实例
// var app = getApp()
// var sta = require("../../utils/statistics.js");
// Page({
//   data: {
//     indicatorDots: false,//是否显示面板指示点
//     autoplay: false,  //是否自动切换
//     current:0,      //当前所在index
//     interval: 0, //自动切换时间
//     duration: 200,  //滑动时间
//     clas:["action"]
//   },
//   onLoad:function(){
    
//       var that = this;
//       app.getUserInfo(function(userInfo){
//           that.setData({userInfo:userInfo});
//           that.getGoodsType();
//       })
//        http.httpGet("?c=banner&a=getBanner",{
//         appid:config.APPID,
//       },function (res){
//         console.log(res);
//           that.setData({
//             bander:res.data
//           });
//       });
//         //获取商品列表
//       that.getGoodsList("",'1,2',function(list){
//           that.setData({
//             IndexList:list
//           });
//       })
//   },
//   onShow:function(){
  
//         sta();
//         app.getAppInfo(
//           function (appInfo){
//                 wx.setNavigationBarTitle({
//                   title: appInfo.title
//                 })
//             }
//         );
        
//   },
//   getGoodsType:function(){
//         var that = this;
//         var data = {appid:config.APPID,userid:this.data.userInfo.id}
//         http.httpGet("?c=type&a=getTypeList" ,data,function(res){
//             if(res.code == '200' && res.msg == 'success'){
//                 var list = res.data.list;
//                 var goodsData = [{type:0,title:"全部"}];
//                 for(var i=1;i<list.length+1;i++){
//                     goodsData[i]= {type:list[i-1].id,title:list[i-1].typename};
//                 }
//                 that.setData({goodsData:goodsData});
//                 that.loadTabGoodsList(0);
                
//             }
//         });
//   },
//   getGoodsList:function(type,status,callback){
//         var that = this;
//         var data = {appid:config.APPID,typeid:type,status:status}
//         if(status != '' || status != 0){
//             //data.status = status;
//         }
//         http.httpGet("?c=goods&a=getGoodsList" ,data,function(res){
//                 if(res.code == '200' && res.msg == 'success'){
//                     var list = res.data.list;
//                     typeof callback == "function" && callback(list)
//                 }
//         });
//   },
//   loadTabGoodsList:function(index){
//         var that = this;
//         var goodsData = that.data.goodsData;
//         if(goodsData[index].banner == undefined || goodsData[index].list ==undefined){
//               var type = goodsData[index].type; 
//               //获取推荐商品
//               this.getGoodsList(type,'2',function(list){
//                     var goods = that.data.goodsData;
//                     goods[index].banner = list;
//                     that.setData({goodsData:goods});
//               })
//                //获取商品列表
//               this.getGoodsList(type,'1,2',function(list){
//                     var goods = that.data.goodsData;
//                     goods[index].list = list;
//                     that.setData({goodsData:goods});
//               })
//         }
        
//   },
//   //事件处理函数
//   switchs: function(e) {
//     var index = e.detail.current;
//     this.loadTabGoodsList(index);
//     this.setData({clas:[]});

//     var data = [];
//     data[index] = "action";
//     this.setData({clas:data });
//   },
//   xun:function (e){
//       var index = e.target.dataset.index;
//       this.setData({current:index });
//       //this.loadTabGoodsList(index);
//   },
//   todetail:function(e){
//         var id = e.currentTarget.id;
//         wx.navigateTo({
//           url: '../detail/index?id='+id,
//           success: function(res){
//             // success
//           },
//           fail: function() {
//             // fail
//           },
//           complete: function() {
//             // complete
//           }
//         })
//   },
//   //处理分页
//   bindlower:function(e){
//     console.log(e)
//   }
  
// })
