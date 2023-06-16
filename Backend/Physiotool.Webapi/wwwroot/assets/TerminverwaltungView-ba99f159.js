import{_ as c,o as s,c as d,a as t,C as i,A as v,G as C,B as $,z as m,H as u,I as h,J as _,D as p,F as g,E as y,d as M,K as b,e as S}from"./index-7518c454.js";const l=e=>(u("data-v-5c39a84f"),e=e(),h(),e),k={class:"confirmAppointment popup"},D={class:"popup-inner"},A=l(()=>t("h2",null,"Termin bestätigen",-1)),T=l(()=>t("label",{style:{"margin-right":"13px"},for:"duration"},"Termin Dauer:",-1)),N=l(()=>t("option",{value:"00:30:00"},"30 Minuten",-1)),F=l(()=>t("option",{value:"00:45:00"},"45 Minuten",-1)),I=l(()=>t("option",{value:"01:00:00"},"60 Minuten",-1)),V=[N,F,I],O=l(()=>t("label",null,"Zusätzliche Information:",-1)),J={data(){return{}},props:{appointment:Object},methods:{async saveForm(){try{await m.post(`appointment/confirm/${this.appointment.guid}`,this.appointment)}catch(e){console.log(e),e.response?alert(JSON.stringify(e.response.data)):alert("Fehler beim Speichern der Termindaten.")}this.$emit("close")}}},L=Object.assign(J,{__name:"ConfirmAppointment",setup(e){return(n,a)=>(s(),d("div",k,[t("div",D,[A,t("p",null,"für "+i(e.appointment.patientFirstname)+" "+i(e.appointment.patientLastname)+" am "+i(new Date(e.appointment.timestamp).toDateString())+" um "+i(new Date(e.appointment.timestamp).toLocaleString("de-AT",{hour:"2-digit",minute:"2-digit"})),1),t("div",null,[T,v(t("select",{"onUpdate:modelValue":a[0]||(a[0]=o=>e.appointment.duration=o),id:"duration"},V,512),[[C,e.appointment.duration]])]),t("div",null,[O,v(t("input",{type:"text","onUpdate:modelValue":a[1]||(a[1]=o=>e.appointment.infotext=o)},null,512),[[$,e.appointment.infotext]])]),t("button",{class:"btn3",onClick:a[2]||(a[2]=o=>n.saveForm()),type:"button"},"Speichern"),t("button",{class:"btn4",onClick:a[3]||(a[3]=o=>n.$emit("close"))},"Abbrechen")])]))}}),B=c(L,[["__scopeId","data-v-5c39a84f"]]);const j=e=>(u("data-v-de28930c"),e=e(),h(),e),z={class:"confirmAppointment popup"},H={class:"popup-inner"},Y=j(()=>t("h2",null,"Termin löschen",-1)),P={data(){return{}},props:{appointment:Object},methods:{async deleteAppointment(){try{await m.delete(`appointment/${this.appointment.guid}`)}catch(e){console.log(e),e.response?alert(JSON.stringify(e.response.data)):alert("Fehler beim Speichern der Termindaten.")}this.$emit("close")}}},E=Object.assign(P,{__name:"DeleteAppointment",setup(e){return(n,a)=>(s(),d("div",z,[t("div",H,[Y,t("p",null,"Soll der Termin mit "+i(e.appointment.patientFirstname)+" "+i(e.appointment.patientLastname)+" am "+i(new Date(e.appointment.timestamp).toDateString())+" um "+i(new Date(e.appointment.timestamp).toLocaleString("de-AT",{hour:"2-digit",minute:"2-digit"}))+" storniert werden?",1),t("button",{class:"btn3",onClick:a[0]||(a[0]=o=>n.deleteAppointment()),type:"button"},"Ja"),t("button",{class:"btn4",onClick:a[1]||(a[1]=o=>n.$emit("close"))},"Nein")])]))}}),U=c(E,[["__scopeId","data-v-de28930c"]]);const f=e=>(u("data-v-5bc5e429"),e=e(),h(),e),G={class:"terminverwaltungView"},K={class:"calendarHeader"},W={class:"headerMonth"},Z={class:"kalender"},q=M('<div class="headerCell" data-v-5bc5e429>Montag</div><div class="headerCell" data-v-5bc5e429>Dienstag</div><div class="headerCell" data-v-5bc5e429>Mittwoch</div><div class="headerCell" data-v-5bc5e429>Donnerstag</div><div class="headerCell" data-v-5bc5e429>Freitag</div><div class="headerCell" data-v-5bc5e429>Samstag</div><div class="headerCell" data-v-5bc5e429>Sonntag</div>',7),Q={class:"dayHeader"},R={class:"dayNumber"},X={key:0},x={class:"holidayName"},ee={class:"appointments"},te={class:"appointmentButtons"},ne=["onClick"],ae=f(()=>t("i",{class:"fa-solid fa-circle-check"},null,-1)),oe=[ae],ie=["onClick"],se=f(()=>t("i",{class:"fa-solid fa-ban"},null,-1)),re=[se],de={data(){return{months:["","Jänner","Februar","März","April","Mai","Juni","Juli","August","September","Oktober","November","Dezember"],currentYear:2023,currentMonth:4,today:Math.floor(Date.now()/864e5)*864e5,days:[],popup:{}}},components:{},async mounted(){await this.loadCalendar()},methods:{async loadCalendar(){this.popup={};try{const e=await m.get(`calendar/${this.currentYear}/${this.currentMonth}`);this.days=e.data}catch(e){alert(JSON.stringify(e))}},async changeMonth(e){const n=Math.max(24012,Math.min(25200,this.currentYear*12+(this.currentMonth-1)+e));this.currentYear=Math.floor(n/12),this.currentMonth=n%12+1,await this.loadCalendar()},showPopup(e,n){this.popup={type:n,appointment:e}}}},le=Object.assign(de,{__name:"TerminverwaltungView",setup(e){return(n,a)=>(s(),d("div",G,[n.popup.type=="confirm"?(s(),_(B,{key:0,appointment:n.popup.appointment,onClose:a[0]||(a[0]=o=>n.loadCalendar())},null,8,["appointment"])):p("",!0),n.popup.type=="delete"?(s(),_(U,{key:1,appointment:n.popup.appointment,onClose:a[1]||(a[1]=o=>n.loadCalendar())},null,8,["appointment"])):p("",!0),t("div",K,[t("div",{class:"headerArrow",onClick:a[2]||(a[2]=o=>n.changeMonth(-1))},"⮜"),t("h3",W,i(n.months[n.currentMonth])+" "+i(n.currentYear),1),t("div",{class:"headerArrow",onClick:a[3]||(a[3]=o=>n.changeMonth(1))},"⮞")]),t("div",Z,[q,(s(!0),d(g,null,y(n.days,o=>(s(),d("div",{key:o.timestamp,class:b({dayCell:!0,disabled:o.month!=n.currentMonth,weekend:!o.isWorkingDay,holiday:o.isPublicHoliday,today:o.timestamp==n.today})},[t("div",Q,[t("div",R,[S(i(o.day),1),o.month!=n.currentMonth?(s(),d("span",X,"."+i(o.month)+".",1)):p("",!0)]),t("div",x,i(o.schoolHolidayName),1)]),t("div",ee,[(s(!0),d(g,null,y(o.appointments,r=>(s(),d("div",{class:"appointment",key:r.guid},[t("div",{class:b(["appointmentData",{notConfirmed:!r.confirmed}])},i(new Date(r.timestamp).toLocaleString("de-AT",{hour:"2-digit",minute:"2-digit"}))+" - "+i(new Date(r.end).toLocaleString("de-AT",{hour:"2-digit",minute:"2-digit"}))+" "+i(r.patientFirstname)+" "+i(r.patientLastname),3),t("div",te,[t("span",{onClick:w=>n.showPopup(r,"confirm"),title:"Termin bestätigen"},oe,8,ne),t("span",{onClick:w=>n.showPopup(r,"delete"),title:"Termin stornieren"},re,8,ie)])]))),128))])],2))),128))])]))}}),ce=c(le,[["__scopeId","data-v-5bc5e429"]]);export{ce as default};