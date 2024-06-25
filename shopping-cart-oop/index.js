// [原始數據] 儘量不改動
console.log({goods});

/* [轉換數據] 單件商品
UiGoods:{
    data: goods[index],
    choose: 0
}
*/


/**
 * [ES6的語法] 單件商品
 * @class
 */
class UiGoods{
    constructor(g){
        this.data=g
        this.choose=0
    }
    getTotalPrice=function(){
        return this.data.price*this.choose;
    }
    isChoose=function(){
        return this.choose>0;
    }
    increase(){
        this.choose++;
        return this.choose;
    }
    decrease(){
        if (this.choose===0) {
            return this.choose;
        }
        this.choose--;
        return this.choose;
    }
};
// const uig=new UiGoods(goods[0]);
// console.log({uig});

/** 整個介面的數據
 */
class UiData{
    constructor(){
        const uiGoodsList=[];
        goods.forEach(element => {
            uiGoodsList.push(new UiGoods(element));
        });
        // console.log({uiGoodsList});
        this.uiGoodsList=uiGoodsList;
        this.deliveryThreshold=200;
        this.deliveryPrice=50;
    }
    getTotalPrice(){
        let sum=0;
        this.uiGoodsList.forEach(element => {
            // console.log(element.data.price);
            // console.log(element.choose);
            // sum+=element.data.price*element.choose;
            sum+=element.getTotalPrice();
        });
        return sum
    }
    /**
     * 增加某件商品的數量
     * @param {int} index
     * @returns {goods}
     */
    increase(index){
        this.uiGoodsList[index].increase();
        return this.uiGoodsList[index];
    }
    decrease(index){
        this.uiGoodsList[index].decrease();
        return this.uiGoodsList[index];
    }

    /** 得到總共商品的選中數量
     */
    getTotalChooseNumber(){
        let totalChoose=0;
        this.uiGoodsList.forEach(element=>{
            // console.log({element});
            totalChoose+=element.choose;
        })
        return totalChoose;
    }

    hasGoodsInCart(){
        return this.getTotalChooseNumber() > 0;
    }

    isCrossDeliveryThreshold(){
        return this.getTotalPrice() >= this.deliveryThreshold;
    }

    isChoose(index){
        return this.uiGoodsList[index].isChoose();
    }
}
// const uiData=new UiData();

// [整個介面]
class Ui{
    constructor(){
        this.uiData=new UiData();
        this.doms={
            goodsList: document.querySelector(".goods-list"),
            footerPrice: document.querySelector(".footer-price"),
            footerTip: document.querySelector(".footer-tip"),
            footerPay: document.querySelector(".footer-pay"),
            badgeIcon: document.querySelector(".badge-icon"),
            badgeNumber: document.querySelector(".badge-number")
        }
        // [元素信息] 購物車 (位置不會變, 初始化時就可以計算)
        const cartRect=this.doms.badgeIcon.getBoundingClientRect();
        const jumpTarget={
            x: cartRect.left+cartRect.width/2,
            y: cartRect.top
        }
        this.jumpTarget=jumpTarget;
        this.createHtml();
        this.updateFooter();
        this.listenEvent();
    }

    /**
     * 監聽各種事件
     */
    listenEvent(){
        this.doms.badgeIcon.addEventListener("animationend", function(){
            console.log("animate over");
            this.classList.remove("animate");
        })

    }

    /**
     * 根據商品數據創建商品列表
     * 1. 生成html字符串 (執行效率低 -> 網頁渲染過程: parse html)
     * 2. 一個一個創建元素 (開發效率低)
     */
    createHtml(){
        let html="";
        this.uiData.uiGoodsList.forEach((item, index) => {
            // console.log({item});
            html+=/* html */`
                <li class="goods-item">
                    <div class="goods-title">
                        <img class="goods-img" src="${item.data.pic}" alt="">
                    </div>
                    <div class="goods-content">
                        <span class="goods-name">${item.data.title}</span>
                        <span class="goods-description">${item.data.desc}</span>
                        <div class="goods-detail">
                            <span class="goods-sellNumber">月售 ${item.data.sellNumber}</span>
                            <span class="goods-favorite">好評率 ${item.data.favorRate}%</span>
                        </div>
                        <div class="goods-price">
                            <i class="goods-cost">$ ${item.data.price}</i>
                            <span class="goods-switchNumber">
                                <button class="goods-decrease" data-index="${index}">-</button>
                                <i class="goods-number">${item.choose}</i>
                                <button class="goods-increase" data-index="${index}">+</button>
                            </span>
                        </div>
                    </div>
                </li>
            `;
        });
        this.doms.goodsList.innerHTML=html;
    }
    increase(index){
        this.uiData.increase(index);
        this.updateGoodsItem(index);
        this.updateFooter();
        this.jump(index);
    }
    decrease(index){
        this.uiData.decrease(index);
        this.updateGoodsItem(index);
        this.updateFooter();
        this.cartCreateAnimate();
    }
    /**
     * 更新某個商品元素的顯示數量
     * @param {int} index
     */
    updateGoodsItem(index){
        const goodsDom=this.doms.goodsList.children[index];
        // console.log({goodsDom});
        if (this.uiData.isChoose(index)) {
            goodsDom.classList.add("active");
        }else{
            goodsDom.classList.remove("active");
        }
        const span=goodsDom.querySelector(".goods-number");
        span.textContent=this.uiData.uiGoodsList[index].choose;
    }

    /**
     * 更新頁角
     */
    updateFooter(){
        // [總價]
        const total=this.uiData.getTotalPrice();
        this.doms.footerPrice.textContent="$ "+total;

        //[運費相關]
        this.doms.footerTip.textContent="運費: $ " + this.uiData.deliveryPrice;
        if(this.uiData.isCrossDeliveryThreshold()){
            this.doms.footerPay.textContent=`去付款`;
            this.doms.footerPay.classList.add("active");
        }else{
            const canDeliveryPrice=this.uiData.deliveryThreshold - total;
            this.doms.footerPay.textContent=`差${canDeliveryPrice}元可外送`;
            this.doms.footerPay.classList.remove("active");
        }

        // [購物車] 樣式
        if (this.uiData.hasGoodsInCart()) {
            this.doms.badgeIcon.classList.add("active");
        }else{
            this.doms.badgeIcon.classList.remove("active");
        }
        // [購物車] 數量
        this.doms.badgeNumber.textContent=this.uiData.getTotalChooseNumber();
    }
    // [購物車] 動畫
    cartCreateAnimate(){
        this.doms.badgeIcon.classList.add("animate");
        /* 每次調用都會新增事件監聽器...
        this.doms.badgeIcon.addEventListener("animationend", function(){
            console.log("animate over");
            this.classList.remove("animate");
        })
        */
    }

    // [拋物線跳躍的元素]
    jump(index){
        // [對應商品的加號]
        const btnAdd=this.doms.goodsList.children[index].querySelector(".goods-increase");
        const rect=btnAdd.getBoundingClientRect();
        const start={
            x: rect.left,
            y: rect.top
        }
        // console.log(rect, start, this.jumpTarget);
        const div=document.createElement("div");
        const iElement=document.createElement("i");
        div.className="add-to-cart";
        iElement.textContent="+";
        iElement.className="cart-increase";
        // [設置初始位置] 一個設x: 勻速運動, 一個設y, 向上拋的運動曲線 (實現拋物線)
        div.style.transform=`translateX(${start.x}px)`;
        iElement.style.transform=`translateY(${start.y}px)`;
        div.appendChild(iElement);
        document.querySelector(".app").appendChild(div);
        // [強行渲染] 因為在js執行完後才會渲染, 也可使用requestAnimationFrame();
        div.clientHeight;
        // [拋物線過渡css] 一個設x: 勻速運動, 一個設y, 向上拋的運動曲線 (實現拋物線)
        div.style.transform=`translateX(${this.jumpTarget.x}px)`;
        iElement.style.transform=`translateY(${this.jumpTarget.y}px)`;

        // [監聽過度結束] 會觸發2次, 因為事件冒泡div跟iElement各觸發一次transitionend
        div.addEventListener("transitionend", ()=>{
            console.log("過渡結束...");
            div.remove(); //刪除元素
            // [購物車] 動畫(使用箭頭函數, 外部作用域的this)
            this.cartCreateAnimate();
        }, {once: true}); // [事件僅觸發一次]
    }

}

const ui=new Ui();

// [事件]
ui.doms.goodsList.addEventListener("click", (e)=>{
    if (e.target.classList.contains("goods-increase")) {
        console.log("[點擊] 加號");
        const index=e.target.dataset.index;
        ui.increase(index);
    }else if(e.target.classList.contains("goods-decrease")) {
        console.log("[點擊] 減號");
        const index=e.target.dataset.index;
        ui.decrease(index);
    }
});

/** [構造函數] 創建一個對象
 * @param {object} g
 * @returns {object} {
        data: g,
        choose: 0
    }

function UiGoods(g){
    this.data=g;
    this.choose=0;
    // this.totalPrice=0; [總價] 是可以當屬性, 但會冗餘
}

// 將公用事件綁定在原型對象上prototype

// [計算總價] 單個商品 (價格*選中數量)
UiGoods.prototype.getTotalPrice=function(){
    return this.data.price*this.choose;
}
// [判斷選中] 單個商品 (選中數量>0)
UiGoods.prototype.isChoose=function(){
    return this.choose>0;
}
const uig=new UiGoods(goods[0]);
console.log({uig});
 */

/* [一般函數] 返回一個對象 (創建對象可使用構造函數)
function createUiGoods(g){
    return {
        data: g,
        choose: 0
    }
}
console.log(createUiGoods(goods[0]))
*/


/* ==================== [屬性描述符] ==================== */
/* [屬性描述符] 更細緻的控制屬性
class UiGoodsTest{
    constructor(g){
        Object.defineProperty(this, "data", {
            value: g,
            writable: false,
            enumerable: true,
            configurable: false,
        });
    }
};

const uig=new UiGoods(goods);
uig.data="test";
console.log({uig});

const uigTest=new UiGoodsTest(goods);
uigTest.data="test"; // [報錯] 不符規則, 應該報錯
console.log({uigTest});

const obj={};
*/

/* [訪問器]
let internalValue=undefined;
Object.defineProperty(obj, 'a', {
    // [讀取器] getter
    get: function(){
        console.log("getter");
        return internalValue;
    },
    // [設置器] setter
    set: function(value){
        console.log("setter");
        internalValue=value;
    },
});

// obj.a=3+2; // set(3+2);
// console.log(obj.a); // console.log(get());

// obj.a=obj.a+2; // set(get()+2);
// obj.a=123;
// console.log(obj.a);
*/

/* [只讀屬性]
Object.defineProperty(obj, 'b', {
    // [讀取器] getter
    get: function(){
        return "read only";
    },
    // [設置器] setter
    set: function(value){
        throw new Error("cant set read only value");
    },
});
obj.b="test";
*/

class UiGoodsTest_1{
    constructor(g){
        g={...g};
        Object.freeze(g);
        Object.defineProperty(this, "data", {
            get: function(){
                return g;
            },
            set: function(){
                throw new Error("data cant set, data is read only.");
            }
        });
        let internalChoose=0;
        Object.defineProperty(this, "choose", {
            configurable: false,
            get: function(){
                return internalChoose;
            },
            set: function(value){
                if (typeof value!=="number") {
                    throw new Error("choose type should be number.")
                }
                let temp=parseInt(value); // ~~value, ex. 1 / 1.5
                if (temp!==value) {
                    throw new Error("choose should be integer.")
                }
                if (value<0) {
                    throw new Error("choose should be > 0.")
                }
                internalChoose=value;
            }
        });
        // Object.defineProperty(this, "totalPrice", {
        //     get: function(){
        //         return this.choose*this.data.price;
        //     }
        // });
        this.test="a";
        // Object.freeze(this);
        Object.seal(this);
    }

    // [ES6語法糖]
    get totalPrice(){
        return this.choose*this.data.price;
    }
    get isChoose(){
        return this.choose>0;
    }

}
const uiGoodsTest_1=new UiGoodsTest_1(goods[0]);
// uiGoodsTest_1.data="test";
// uiGoodsTest_1.choose="test";
// uiGoodsTest_1.choose=0.5;
// uiGoodsTest_1.choose=-1;
uiGoodsTest_1.choose=2;
// console.log(uiGoodsTest_1.totalPrice);
uiGoodsTest_1.data.price="test";
uiGoodsTest_1.data.abc="test";
Object.freeze(UiGoodsTest_1.prototype);
UiGoodsTest_1.prototype.testAdd="g";
console.log({uiGoodsTest_1});
