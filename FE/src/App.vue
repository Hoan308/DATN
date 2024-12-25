<template>
  <div
    class="container"
    :style="isLogin ? 'background-color: var(--blue-color-third);' : ''"
  >
    <router-view v-if="isLogin"></router-view>
    <template v-else>
      <m-sidebar></m-sidebar>
      <disv :class="[`${!isCollapsed ? 'main' : 'main--active'}`]">
        <m-header></m-header>
        <router-view />
      </disv>
    </template>
  </div>
</template>

<script>
import { mapState } from "vuex";

import TheSidebar from "./layout/TheSidebar.vue";
import TheMainHeader from "./layout/TheMainHeader.vue";
import { useRoute } from "vue-router";
import { computed } from "vue";

export default {
  name: "App",
  components: {
    "m-sidebar": TheSidebar,
    "m-header": TheMainHeader,
  },

  computed: {
    ...mapState("sideBar", ["isCollapsed"]),
  },
  setup() {
    const route = useRoute();
    const isLogin = computed(
      () => route.path === "/login" || route.path === "/register"
    );
    return {
      isLogin,
    };
  },
};
</script>
<style scoped>
@import "@/css/main.css";
@import "@/css/base/layout.css";
</style>
