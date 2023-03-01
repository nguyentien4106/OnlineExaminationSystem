const path = require('path');

module.exports = {
    entry: [
        './src/js/manageUser/index.js',
        './src/js/manageCDIO/index.js',

    ],
    output: {
        filename: '[name].js',
        path: path.resolve(__dirname, '..', 'wwwroot', 'admin')
    },
    devtool: 'source-map',
    mode: 'development',
    module: {
        rules: [
            {
                test: /\.css$/,
                use: ['style-loader', 'css-loader'],
            },
            {
                test: /\.(eot|woff(2)?|ttf|otf|svg)$/i,
                type: 'asset'
            },
        ]
    }
};