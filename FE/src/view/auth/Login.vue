<template>
  <div class="customer-login">
    <m-loading v-if="isLoading"></m-loading>
    <div class="tab-navigate flex-row">
      <h4 class="active dn">Đăng nhập</h4>
      <h4 @click="navigateToRegister" class="dki">Đăng ký</h4>
    </div>
    <div class="tab-login">
      <div v-if="error" class="error">
        Số điện thoại/Email hoặc mật khẩu không đúng
      </div>
      <div class="field email">
        <m-input
          v-model="user.email"
          type="text"
          :placeHolder="'Email hoặc Số điện thoại'"
          name="Email"
          className="input__text input__full"
          :required="true"
          :requiredNot="true"
          :isLabel="false"
          ref="Email"
        ></m-input>
      </div>
      <div class="field password">
        <m-input
          v-model="user.password"
          type="password"
          :placeHolder="'Mật khẩu'"
          name="Password"
          className="input__text input__full"
          :required="true"
          :requiredNot="true"
          :isLabel="flase"
          ref="Password"
        ></m-input>
      </div>
      <div class="btn-login">
        <m-button
          type="button"
          :content="'Đăng nhập'"
          className="btn__sub btn--form btn-login"
          @click="handleLogin"
        ></m-button>
      </div>
    </div>
  </div>
</template>

<script>
import { request } from "@/services/request";
import MLoading from "@/components/base/MLoading.vue";

export default {
  name: "LoginPage",
  components: {
    "m-loading": MLoading,
  },
  data() {
    return {
      user: {
        email: "",
        password: "",
      },
      error: false,
      config: { headers: { "Access-Control-Allow-Origin": "*" } },
      isErrorControl: false,
      isLoading: false,
    };
  },
  methods: {
    navigateToRegister() {
      this.$router.push("/register");
    },
    validateControl() {
      let listRef = this.$refs;
      for (const ref in listRef) {
        if (
          typeof listRef[ref].validate === "function" &&
          listRef[ref].validate()
        ) {
          this.isErrorControl = true;
        } else {
          this.isErrorControl = false;
        }
      }
    },
    async handleLogin() {
      this.validateControl();
      if (this.error) this.error = false;

      if (this.isErrorControl) {
        return;
      }
      if (this.user?.email?.length > 0 && this.user?.password?.length > 0) {
        var res = await request.login(this.user);
        this.isLoading = true;
        if (res && res.data && res.data.isLogin) {
          setTimeout(() => {
            this.isLoading = false;

            this.$router.push("/asset");
          }, 500);
        } else {
          setTimeout(() => {
            this.isLoading = false;
            this.error = true;
          }, 500);
        }
      }
    },
  },
};
</script>

<style>
.error {
  margin-bottom: 10px;
  color: red !important;
}
.btn-login {
  width: 100%;
  background-color: var(--blue-color-primary);
  border-radius: 2px;
}
.customer-login {
  margin-top: 127px;
  font-family: RobotoRegular;
  width: 620px;
  height: 350px;
  margin: 35px auto 50px;
  background: #fff;
  padding: 25px 30px 30px;
}
.tab-navigate {
  margin-bottom: 45px;
  align-items: center;
  justify-content: center;
}
h4 {
  padding: 0px 30px;
  font-size: 24px;
  font-weight: bold;
  cursor: pointer;
  margin: 0;
  line-height: 1.2;
  color: #cacaca;
  transition: 0.3s ease;
}
h4:hover {
  color: #000;
}
h4 + h4 {
  border-left: 2px solid gray;
}
.active {
  color: #000;
}
.tab-login {
}
.field {
  margin-bottom: 30px;
}

.btn-login {
}
.error {
  margin-bottom: 10px;
  color: red;
}
.google {
  display: inline-block;
  margin-top: 8px;
  text-decoration: underline;
}
.flex-row {
  display: flex;
  flex-direction: row;
}
</style>