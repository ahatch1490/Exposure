
        const path = require('path');
        var webpack = require('webpack');

        
        module.exports = {
            entry: './wwwroot/Source/Script/app.ts',
            output: {
                path: path.resolve(__dirname, 'wwwroot/App'),
                filename: 'bundle.js'
            },
            devtool: 'inline-source-map',
            module: { 
                rules: [
                    {
                        test: /\.tsx?$/,
                        use: {loader: 'ts-loader'},
                        exclude: /node_modules/,
                    },

                    {
                        test: /\.css$/,
                        exclude: ['node_modules'],
                        use: [
                            {loader: "style-loader"},
                            {loader: "css-loader"}
                        ]
                    }]
            },
            resolve: {
                extensions: [ '.tsx', '.ts', '.js' ]
            },
            plugins: [
                new webpack.ProvidePlugin({
                    $: 'jquery',
                    jQuery: 'jquery'
                })
            ]
      
        };




