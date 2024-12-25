import { createRouter, createWebHistory } from "vue-router";
import AssetList from '@/view/asset/AssetList'
import ReportPage from '@/view/report/ReportPage'
import AssetTranferList from '@/view/assetTranfer/AssetTranferList'
import LoginPage from '@/view/auth/Login'
import RegisterPage from "@/view/auth/Register";

const routers = [
    {
        path: '/',
        redirect: '/login'
    },
    {
        path: '/asset',
        component: AssetList,
    },
    {
        path: '/assetincrease',
        component: AssetList
    },
    {
        path: '/changeinfor',
        component: AssetList
    },
    {
        path: '/assetassessment',
        component: AssetList
    },
    {
        path: '/assettranfer',
        component: AssetTranferList
    },
    {
        path: '/receiptreccommend',
        component: AssetList
    },
    {
        path: '/assetreducing',
        component: AssetList
    },
    {
        path: '/depreciationbusiness',
        component: AssetList
    },
    {
        path: '/depreciationasset',
        component: AssetList
    },
    {
        path: '/assetinventory',
        component: AssetList
    },
    {
        path: '/tai-san-ht',
        component: ReportPage,
    },
    {
        path: '/login',
        component: LoginPage
    }, {
        path: '/register',
        component: RegisterPage
    }

];

const vueRouter = createRouter({
    history: createWebHistory(),
    routes: routers
})

export default vueRouter;