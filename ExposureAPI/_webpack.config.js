
        const path = require('path');
        var webpack = require('webpack');
        const precss = require('precss');
        const autoprefixer = require('autoprefixer');
        const TransferWebpackPlugin = require('transfer-webpack-plugin');
        const ExtractTextPlugin = require('extract-text-webpack-plugin');

        
        module.exports = {
            entry: ['./wwwroot/Source/Script/app.ts',
                './node_modules/font-awesome/scss/font-awesome.scss',],
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
                        test: /\.css$/, use: ['style-loader', 'css-loader']
                    },

                    {
                        test: /\.scss$/,
                        exclude: ['node_modules'],
                        use: [
                            
                            {loader: "style-loader"},
                            {loader: "css-loader"},
                            {loader: "postcss-loader",
                                options: {
                                    plugins() {
                                        return [
                                            precss,
                                            autoprefixer
                                        ];
                                    }}
                            },
                            {loader: 'sass-loader'}
                        ]
                    },
                    
                    {
                        test: /\.woff2?(\?v=[0-9]\.[0-9]\.[0-9])?$/,
                        use: 'url-loader?limit=10000',
                    },
                    {
                        test: /\.(ttf|eot|svg)(\?[\s\S]+)?$/,
                        use: 'file-loader',
                    },
                    {
                        test: /\.(jpe?g|png|gif|svg)$/i,
                        use: [
                            'file-loader?name=images/[name].[ext]',
                            'image-webpack-loader?bypassOnDebug'
                        ]
                    },
                    {
                        test: /font-awesome\.config\.js/,
                        use: [
                            { loader: 'style-loader' },
                            { loader: 'font-awesome-loader' }
                        ]
                    }
                    
                ]
                
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




