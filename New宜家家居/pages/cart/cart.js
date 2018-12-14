//var json = require('../../data/Home_data.js')

Page({
  data: {
    cartItems:[
      {
    id:0,
    title:"X9 全网通",
    titleTwo:"前置2000万柔光双摄",
    price: "2250",
    value:"1",
    image:"https://shopstatic.vivo.com.cn/vivoshop/commodity/51/4151_1496689455875hd_530x530.png",
    Imgone: "https://shopstatic.vivo.com.cn/vivoshop/commodity/51/4151_1496689455875hd_530x530.png",
    Imgtwo:"https://shopstatic.vivo.com.cn/vivoshop/commodity/71/4171_1482112378797_530x530.png",
    selected:true,
    // img:[
    //   {name:55},
    //   {name:666}
    // ]
    img:[
      { image: "https://shopstatic.vivo.com.cn/vivoshop/commodity/20171115/20171115110719510981_original.jpg", mode: 'widthFix'},
      { image: "https://shopstatic.vivo.com.cn/vivoshop/commodity/20161219/20161219093807784269_original.jpg", mode: 'widthFix'},
      { image: "https://shopstatic.vivo.com.cn/vivoshop/commodity/20161219/20161219093810349285_original.jpg", mode: 'widthFix'},
      { image: "https://shopstatic.vivo.com.cn/vivoshop/commodity/20161219/20161219093813167921_original.jpg", mode: 'widthFix' },
      { image: "https://shopstatic.vivo.com.cn/vivoshop/commodity/20161219/20161219093814935600_original.jpg", mode: 'widthFix' },
      { image: "https://shopstatic.vivo.com.cn/vivoshop/commodity/20161219/20161219093817527717_original.jpg", mode: 'widthFix' },
      { image: "https://shopstatic.vivo.com.cn/vivoshop/commodity/20161219/20161219093822750588_original.jpg", mode: 'widthFix' },
      { image: "https://shopstatic.vivo.com.cn/vivoshop/commodity/20161219/20161219093824598774_original.jpg", mode: 'widthFix' },
      { image: "https://shopstatic.vivo.com.cn/vivoshop/commodity/20161219/20161219093827290232_original.jpg", mode: 'widthFix' },
      { image: "https://shopstatic.vivo.com.cn/vivoshop/commodity/20161219/20161219093829298284_original.jpg", mode: 'widthFix' },
      { image: "https://shopstatic.vivo.com.cn/vivoshop/commodity/20161219/2016121909383925061_original.jpg", mode: 'widthFix' },
      { image: "https://shopstatic.vivo.com.cn/vivoshop/commodity/20161219/2016121909383925061_original.jpg", mode: 'widthFix' },
      { image: "https://shopstatic.vivo.com.cn/vivoshop/commodity/20170629/2017062914535078223_original.jpg", mode: 'widthFix' },
    ]
  },

    ],
    total:0,
    CheckAll:true
  },
  onLoad:function(e){
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
          cartItems111: res.data,
         
          hasList: true,
        })

      }
    })
  },
   onShow: function () {
     var cartItems = wx.getStorageSync("cartItems")
     this.setData({
       cartList: false,
       cartItems: cartItems
     })
     this.getsumTotal()
     
   },
  ass:function(){
    wx.navigateTo({
      url: "/pages/home/home",
    })
  },
  //选择
   select:function(e){
    var CheckAll = this.data.CheckAll;
    CheckAll = !CheckAll
    var cartItems = this.data.cartItems

    for(var i=0;i<cartItems.length;i++){
      cartItems[i].selected = CheckAll
    }

    this.setData({
      cartItems: cartItems,
      CheckAll: CheckAll
    })
    this.getsumTotal()
   },
   add:function (e) {
     var cartItems = this.data.cartItems   //获取购物车列表
     var index = e.currentTarget.dataset.index //获取当前点击事件的下标索引
     var value = cartItems[index].value  //获取购物车里面的value值
     
     value++
     cartItems[index].value = value;
     this.setData({
       cartItems: cartItems
     });
     this.getsumTotal()
     
     wx.setStorageSync("cartItems", cartItems)  //存缓存
   },
   
    //减
   reduce: function (e){
     var cartItems = this.data.cartItems  //获取购物车列表
     var index = e.currentTarget.dataset.index  //获取当前点击事件的下标索引
     var value = cartItems[index].value  //获取购物车里面的value值

    if(value==1){
       value --
       cartItems[index].value = 1
     }else{
       value --
       cartItems[index].value = value;
     }
     this.setData({
       cartItems: cartItems
     });
     this.getsumTotal()
     wx.setStorageSync("cartItems", cartItems)
   },
  
    // 选择
   selectedCart:function(e){
     
    var cartItems = this.data.cartItems   //获取购物车列表
    var index = e.currentTarget.dataset.index;  //获取当前点击事件的下标索引
    var selected = cartItems[index].selected;    //获取购物车里面的value值

    //取反
    cartItems[index].selected =! selected;
    this.setData({
      cartItems: cartItems
    })
    this.getsumTotal();   
    wx.setStorageSync("cartItems", cartItems)
   },

  
   

   //删除
   shanchu:function(e){
     var cartItems = this.data.cartItems  //获取购物车列表
     var index = e.currentTarget.dataset.index  //获取当前点击事件的下标索引
     cartItems.splice(index,1)
     this.setData({
       cartItems: cartItems
     });
     if (cartItems.length) {
       this.setData({
         cartList: false
       });
     }
     this.getsumTotal()
     wx.setStorageSync("cartItems", cartItems)
   },

      //提示
   go:function(e){
     this.setData({
       cartItems:[]
     })
     wx.setStorageSync("cartItems", [])
   },


   //合计
   getsumTotal: function () {
     var sum = 0
     for (var i = 0; i < this.data.cartItems.length; i++) {
       if (this.data.cartItems[i].selected) {
         sum += this.data.cartItems[i].value * this.data.cartItems[i].price
       }
     }
     //更新数据
     this.setData({
       total: sum
     })
   },
})