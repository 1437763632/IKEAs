var tcity = require("../../utils/citys.js");
const constant = require("../../utils/constant.js");
const http = require('../../utils/http.js');
const util = require('../../utils/util.js');

var app = getApp()
Page({
  data: {
    provinces: [],
    province: "",
    citys: [],
    city: "",
    countys: [],
    county: '',
    value: [0, 0, 0],
    values: [0, 0, 0],
    condition: false,
    userInfo: {},
  },
  bindChange: function (e) {
    //console.log(e);
    var val = e.detail.value
    var t = this.data.values;
    var cityData = this.data.cityData;

    if (val[0] != t[0]) {
      console.log('province no ');
      const citys = [];
      const countys = [];

      for (let i = 0; i < cityData[val[0]].sub.length; i++) {
        citys.push(cityData[val[0]].sub[i].name)
      }
      for (let i = 0; i < cityData[val[0]].sub[0].sub.length; i++) {
        countys.push(cityData[val[0]].sub[0].sub[i].name)
      }

      this.setData({
        province: this.data.provinces[val[0]],
        city: cityData[val[0]].sub[0].name,
        citys: citys,
        county: cityData[val[0]].sub[0].sub[0].name,
        countys: countys,
        values: val,
        value: [val[0], 0, 0]
      })

      return;
    }
    if (val[1] != t[1]) {
      console.log('city no');
      const countys = [];

      for (let i = 0; i < cityData[val[0]].sub[val[1]].sub.length; i++) {
        countys.push(cityData[val[0]].sub[val[1]].sub[i].name)
      }

      this.setData({
        city: this.data.citys[val[1]],
        county: cityData[val[0]].sub[val[1]].sub[0].name,
        countys: countys,
        values: val,
        value: [val[0], val[1], 0]
      })
      return;
    }
    if (val[2] != t[2]) {
      console.log('county no');
      this.setData({
        county: this.data.countys[val[2]],
        values: val
      })
      return;
    }


  },
  open: function () {
    this.setData({
      condition: !this.data.condition
    })
  },
  onLoad: function (resd) {
    console.log(resd.ID) 
    console.log("onLoad");
    var that = this;

    tcity.init(that);

    var cityData = that.data.cityData;
    const provinces = [];
    const citys = [];
    const countys = [];

    for (let i = 0; i < cityData.length; i++) {
      provinces.push(cityData[i].name);
    }
    console.log('省份完成');
    for (let i = 0; i < cityData[0].sub.length; i++) {
      citys.push(cityData[0].sub[i].name)
    }
    console.log('city完成');
    for (let i = 0; i < cityData[0].sub[0].sub.length; i++) {
      countys.push(cityData[0].sub[0].sub[i].name)
    }

    that.setData({
      'provinces': provinces,
      'citys': citys,
      'countys': countys,
      'province': cityData[0].name,
      'city': cityData[0].sub[0].name,
      'county': cityData[0].sub[0].sub[0].name
    })
    console.log('初始化完成');

    var that = this;
    wx.login({
      success: function () {
        wx.getUserInfo({
          success: function (res) {
            that.setData({
              userInfo: res.userInfo
            })
          }
        })
      }
    });
  
  // 根据主键获取地址信息     
    var id = resd.ID;
    console.log(id)
    wx.request({
      url: 'http://localhost:8765/ShoppingCar/GetAdderssID?ID=' + id,
      method: 'get',
      success: function (res) {
        console.log(res.data);
        var addressArray=res.data.AddressName.split('-');
        console.log(addressArray)
        that.setData({
          addressID: res.data,
          address: addressArray
        })
      }
    })  
  },
  // 修改地址
  addressSubmit: function (add) {
    var userName = add.detail.value.userName;
    var phone = add.detail.value.phone;
    var delivery_address = add.detail.value.delivery_address;
    var detailAddress = add.detail.value.detailAddress;
    var ID = add.detail.value.ID;
    if (userName == '') {
      util.showFailToast({
        title: '请输入收货人',
        icon: Error,
      });
      return;
    }

    if (phone == '') {
      util.showFailToast({
        title: '请输入手机号码',
        icon: Error,
      });
      return;
    }
     else {
      if (!util.isPhone(phone)) {
        util.showFailToast({
          title: '手机格式不对'
        });

        return;
      }
    }
    if (this.data.area == '') {
      util.showFailToast({
        title: '请选择省市区'
      });

      return;
    }


    if (detailAddress == '') {
      util.showFailToast({
        title: '请输入详细地址',
        icon: Error,
      });
      return;
    }



    wx.request({
      url: 'http://localhost:8765/ShoppingCar/UpdateAddres',
      method: 'post',
      data: {
        Id: ID,
        UserName: userName,
        Phone: phone,
        AddressName: delivery_address,
        DetailAddress: detailAddress,
      },
      success: function (data) {
         console.log(data)
        wx.showToast({      
          title: '修改成功!',
          icon: 'success',
          success: function () {
           // wx.navigateBack();
            wx.redirectTo({
              url: '/pages/manageAddress/manageAddress',
            })    
          }
        })
      }
    })
  },




  // backAddress: function () {
  //   wx.navigateTo({
  //     url: '/pages/manageAddress/manageAddress'
  //   })
  // },



})
