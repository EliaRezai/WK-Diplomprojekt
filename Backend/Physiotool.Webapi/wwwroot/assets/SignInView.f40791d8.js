import{_,j as f,o as n,c as r,a as s,w as d,v as l,h as u,f as i,t as h,k as g,l as v,g as m,p as w,i as k}from"./index.8506567a.js";const c=e=>(w("data-v-44ff9f48"),e=e(),k(),e),y={class:"loginView"},V={key:0},I={class:"formRow"},S=c(()=>s("label",null,"Username:",-1)),b={class:"formRow"},$=c(()=>s("label",null,"Password:",-1)),D={key:1},U={setup(){},data(){return{message:"",model:{username:"admin",password:"1111"}}},mounted(){this.message=""},methods:{async sendLoginData(){try{const e=(await m.post("user/login",this.model)).data;m.defaults.headers.common.Authorization=`Bearer ${e.token}`,this.$store.commit("authenticate",e),this.message=`User ${e.username} logged in.`}catch(e){e.response.status==401&&alert("Login failed. Invalid credentials.")}}},computed:{authenticated(){return!!this.$store.state.userdata.username},userdata(){return this.$store.state.userdata}}},B=Object.assign(U,{__name:"SignInView",setup(e){return(t,a)=>{const p=f("router-link");return n(),r("div",y,[t.authenticated?u("",!0):(n(),r("div",V,[s("div",I,[S,d(s("input",{class:"form-control","onUpdate:modelValue":a[0]||(a[0]=o=>t.model.username=o),type:"text"},null,512),[[l,t.model.username]])]),s("div",b,[$,d(s("input",{class:"form-control","onUpdate:modelValue":a[1]||(a[1]=o=>t.model.password=o),type:"password"},null,512),[[l,t.model.password]])]),s("div",null,[s("button",{class:"btn btn-outline-primary",onClick:a[2]||(a[2]=o=>t.sendLoginData())},"Submit")])])),t.authenticated?(n(),r("div",D,[i("User "+h(t.userdata.username)+" ist angemeldet. Du kannst jetzt die ",1),g(p,{to:"/terminverwaltung"},{default:v(()=>[i("Termine verwalten")]),_:1}),i(".")])):u("",!0)])}}}),N=_(B,[["__scopeId","data-v-44ff9f48"]]);export{N as default};
