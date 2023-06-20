import { createRouter, createWebHashHistory, createWebHistory } from 'vue-router'
import store from '../store.js'
import HomeView from '../views/HomeView.vue'
import PatientView from '../views/PatientView.vue'

const router = createRouter({
  history: createWebHashHistory(),
  routes: [
    {
      path: '/',
      name: 'home',
      component: HomeView,
    },
    {
      path: '/praxis',
      name: 'praxis',
      component: () => import('../views/PraxisView.vue'),
    },
    {
      path: '/therapie',
      name: 'therapie',
      component: () => import('../views/TherapieView.vue'),
    },
    {
      path: '/opening',
      name: 'opening',
      component: () => import('../views/OpeningView.vue'),
    },
    {
      path: '/termin',
      name: 'termin',
      component: () => import('../views/TerminView.vue'),
    },
    {
      path: '/patient/:id',
      component: PatientView,
    },    
    {
      path: '/terminverwaltung',
      name: 'terminverwaltung',
      meta: { authorize: true },
      component: () => import('../views/TerminverwaltungView.vue'),
    },
    {
      path: '/signin',
      name: 'signin',
      component: () => import('../views/SignInView.vue'),
    }
  ]
});

router.beforeEach((to, from, next) => {
  const authenticated = store.state.userdata.username ? true : false;
  if (to.meta.authorize && !authenticated) {
    next("/signin");
    return;
  }
  next();
  return;
});

export default router;