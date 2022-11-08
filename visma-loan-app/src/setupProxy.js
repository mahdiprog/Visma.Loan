const { createProxyMiddleware } = require('http-proxy-middleware');

const context = [
    "/loans",
];

module.exports = function (app) {
    const appProxy = createProxyMiddleware(context, {
        target: 'http://localhost:5278',
        secure: false
    });

    app.use(appProxy);
};
