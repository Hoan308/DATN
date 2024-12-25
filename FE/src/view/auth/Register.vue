<template>
  <div class="customer-register">
    <m-loading v-if="isLoading"></m-loading>
    <div class="tab-navigate flex-row">
      <h4 @click="navigateToLogin">Đăng nhập</h4>
      <h4 class="active">Đăng ký</h4>
    </div>
    <div class="tab-register">
      <div v-if="error" class="error">Số điện thoại/Email đã được đăng ký</div>
      <div class="field name">
        <m-input
          v-model="form.name"
          type="text"
          :placeHolder="'Họ và tên'"
          className="input__text input__full"
          :required="true"
          name="FullName"
          :requiredNot="true"
          :isLabel="false"
          ref="FullName"
        ></m-input>
      </div>
      <div class="field address">
        <m-input
          v-model="form.address"
          type="text"
          :placeHolder="'Địa chỉ'"
          className="input__text input__full"
          :required="false"
          :requiredNot="true"
          :isLabel="false"
          ref="Address"
          name="Address"
        ></m-input>
      </div>
      <div class="field tel">
        <m-input
          v-model="form.telephone"
          type="text"
          :placeHolder="'Số điện thoại'"
          className="input__text input__full"
          :required="false"
          :requiredNot="true"
          :isLabel="false"
          ref="Telephone"
          name="Telephone"
        ></m-input>
      </div>
      <div class="field email">
        <m-input
          v-model="form.email"
          type="text"
          :placeHolder="'Email'"
          name="Email"
          className="input__text input__full"
          :required="false"
          :requiredNot="true"
          :isLabel="false"
          ref="Email"
        ></m-input>
      </div>
      <div class="field password">
        <m-input
          v-model="form.password"
          type="password"
          :placeHolder="'Mật khẩu'"
          name="Password"
          className="input__text input__full"
          :required="false"
          :requiredNot="true"
          :isLabel="false"
          ref="Password"
        ></m-input>
      </div>
      <div class="btn-login">
        <m-button
          type="button"
          :content="'Đăng ký'"
          className="btn__sub btn--form btn-login"
          @click="handleRegister"
        ></m-button>
      </div>
    </div>
  </div>
</template>

<script>
import { request } from "@/services/request";
import MLoading from "@/components/base/MLoading.vue";

export default {
  name: "ResgisterPage",
  components: {
    "m-loading": MLoading,
  },
  data() {
    return {
      form: {
        name: "",
        address: "",
        telephone: "",
        email: "",
        password: "",
      },
      invalidity: {
        name: false,
        address: false,
        tel: false,
        email: false,
        pwd: false,
      },
      isErrorControl: false,
      isLoading: false,
      error: false,
    };
  },
  methods: {
    navigateToLogin() {
      this.$router.push("/login");
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

    async handleRegister() {
      this.validateControl();

      if (this.isErrorControl) {
        return;
      }
      if (
        this.form?.email?.length > 0 &&
        this.form?.name?.length > 0 &&
        this.form?.telephone.length > 0 &&
        this.form?.password.length > 0 &&
        this.form?.address?.length > 0
      ) {
        var res = await request.register(this.form);
        this.isLoading = true;
        if (res && res.data && res.data.isSuccess) {
          setTimeout(() => {
            this.isLoading = false;

            this.$router.push("/asset");
          }, 500);
        } else if (res.data.ErrorCode === "DUPLICATE") {
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
.btn-login {
  width: 100%;
  background-color: var(--blue-color-primary);
  border-radius: 2px;
}
.customer-register {
  margin-top: 127px;
  font-family: RobotoRegular;
  width: 620px;
  height: 500px;
  margin: 35px auto 50px;
  background: #ffffff;
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
  margin-bottom: 25px;
}
.btn-login {
}
.error {
  margin-bottom: 10px;
  color: #252a2b;
}
</style>