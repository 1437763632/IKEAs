// pages/shopcart/shopcart.js
Page({

  /**
   * 页面的初始数据
   */

  data: {

    goodList: [
      {
    
        'name': 'goodList.ProductName',
        'author': '余光中，林清玄，白先勇 等 著',
        'isbn': '9787535482051',
        'cover': '/images/床02.jpg',
        'desc': '缅怀乡愁诗人余光中。余光中、林清玄、白先勇联手巨献，重温经典，送别先生。总有一天，你会明白，孤独才是生命的常态。一部直击现代人孤独的精神献礼。中国散文协会推荐！',
        'press': '长江文艺出版社',
        'price': 888,
        'count': 1,
        'checked': false
      },
      {

        'name': 'goodList.ProductName',
        'author': '余光中，林清玄，白先勇 等 著',
        'isbn': '9787535482058',
        'cover': '/images/床02.jpg',
        'desc': '缅怀乡愁诗人余光中。余光中、林清玄、白先勇联手巨献，重温经典，送别先生。总有一天，你会明白，孤独才是生命的常态。一部直击现代人孤独的精神献礼。中国散文协会推荐！',
        'press': '长江文艺出版社',
        'price': 888,
        'count': 1,
        'checked': false
      },
     
    ],
    'checkAll': false,
    'totalCount': 0,
    'totalPrice': 0
  },
  onLoad: function () {
    var that = this;
    wx.request({
      url: 'http://localhost:8765/TProduct/GetProduct',
      method: 'GET',
      data: {
        Id: 1,
      },
      success: function (res) {
        console.log(res.data)
        that.setData({
          goodLists: res.data
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
        totalCount += good.count;
        totalPrice += good.count * good.price; 
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
    var count = goodList[index].count;
    if (count <= 1) {
      return;
    } else {
      goodList[index].count--;
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
    var count = goodList[index].count;
    goodList[index].count++;
    this.setData({
      'goodList': goodList
    });
    this.calculateTotal();
  },
  /**
   * 用户选择购物车商品
   */
  checkboxChange: function (e) {
    console.log('checkbox发生change事件，携带value值为：', e.detail.value);
    var checkboxItems = this.data.goodList;
    var values = e.detail.value;
    for (var i = 0; i < checkboxItems.length; ++i) {
      checkboxItems[i].checked = false;
      for (var j = 0; j < values.length; ++j) {
        if (checkboxItems[i].isbn == values[j]) {
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
//   onLoad: function () {
//     var that = this;
//     wx.request({
//       url: 'http://localhost:8765/TProduct/GetProduct',
//       method: 'GET',
//       data:{
//         Id:1,
//       },
//       success: function (res) {
//         console.log(res.data)
//         that.setData({
//           items: res.data
//         })

//       }
//     })
//   },
//   detall: function () {
//     wx.navigateTo({
//       url: "/pages/commodity details_spxiangqing/index",
//     })
//   },






//   /*添加到购物车*/
//   onAddingToCartTap: function (events) {
//     // var currentFly = e.currentTarget.dataset.id
//     // this.setData({
//     //       flayTo:currentFly 
//     //   }); 
//     //防止快速点击
//     if (this.data.flayTo) {
//       return;
//     }
//     this._flyToCartEffect(events);

//   },

//   _flyToCartEffect: function (events) {
//     //获得当前点击的位置，距离可视区域左上角
//     console.log(events);
//     var touches = events.touches[0];
//     var diff = {
//       x: -touches.clientX * 0.3 + 'px',
//       y: 25 + this.data.windowHeight - touches.clientY - 140 + 'px',

//     },

//       style = 'display: block;-webkit-transform:translate(' + diff.x + ',' + diff.y + ') rotate(350deg) scale(0.3); opacity: 1;',  //移动距离
//       style1 = '-webkit-transform:scale(1.1)'

//     this.setData({
//       flayTo: events.target.dataset.num,
//       //isFly:events.target.dataset.num,
//       translateStyle: style,
//       shoppingStyle: style1,
//     });
//     var that = this;
//     setTimeout(() => {
//       that.setData({
//         flayTo: false,
//         translateStyle: '-webkit-transform: none;',  //恢复到最初状态
//         isShake: true,

//       });
//       setTimeout(() => {
//         var counts = that.data.cartTotalCounts + that.data.productCounts;
//         that.setData({
//           isShake: false,
//           cartTotalCounts: counts
//         });
//       }, 200);
//     }, 500);

//   },







//   buyCount: function (e) {
//     var id = e.currentTarget.id;
//     var count = this.data.buyCount;
//     if (id == "add") {
//       count = (count > 0) ? count + 1 : 1
//     } else {
//       count = (count > 0) ? count - 1 : 0
//     }
//     this.setData({ buyCount: count });

//     this.buyNow('');
//   },

//   buyNow: function (e) {

//     var count = this.data.buyCount;
//     count = (count > 0) ? count : 1;
//     var goods = this.data.goods;
//     //取出购物车商品
//     goods = { id: goods.id, name: goods.title, img: goods.thumb, price: goods.price, buycount: count };
//     try {
//       var allGoods = wx.getStorageSync('shoppingcar')
//       if (allGoods == "") {
//         allGoods = []
//       }
//       //检查购物车是否有此商品
//       var hasCount = 0;
//       for (var i = 0; i < allGoods.length; i++) {
//         var temp = allGoods[i];
//         if (temp.id == goods.id) {
//           hasCount = temp.buycount;
//           allGoods.splice(i, 1);
//           break;
//         }
//       }
//       goods.buycount = goods.buycount + hasCount;
//       allGoods.push(goods);
//       wx.setStorageSync('shoppingcar', allGoods);
//     } catch (m) {
//       console.log('立即购买失败!');
//     }
//     if (e != '') {
//       var currentPagess = getCurrentPages();
//       wx.navigateBack({
//         delta: 1, // 回退前 delta(默认为1) 页面
//         success: function (res) {
//           // success
//           wx.navigateTo({ url: '/pages/shoppingcar/index' })
//         }
//       })
//     }
//   },




// })
