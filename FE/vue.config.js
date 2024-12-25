const AutoImport = require('unplugin-auto-import/webpack');
const Components = require('unplugin-vue-components/webpack');
const { ElementPlusResolver } = require('unplugin-vue-components/resolvers');

module.exports = {
  // ...
  configureWebpack: {
    plugins: [
      AutoImport({
        resolvers: [ElementPlusResolver()],
        sourcemap: true,
      }),
      Components({
        resolvers: [ElementPlusResolver()],
        sourcemap: true,
      }),
    ],
    devtool: 'source-map',
  },
  productionSourceMap: true,
};
