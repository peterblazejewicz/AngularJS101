# AngularJS101

A `generator-aspnet` rewrite of the [ASP.Net 5: Jump Start to AngularJS With MVC 6 Web API' article](http://www.c-sharpcorner.com/UploadFile/8c19e8/Asp-Net-5-jump-start-to-angularjs-with-mvc-6-web-api/). Please consult the original article to get idea what we are doing here. 

Thanks!

## Prerequisites

* No `Visual Studio 2015` the original article is using. You can use `Visual Studio Code` or any other editor of your choice

* the `Node`, `Yeoman` and `generator-aspnet` tools installed on your machine. See introductory article: [Building Projects with Yeoman](http://docs.asp.net/en/latest/client-side/yeoman.html)

* you are somehow comfortable with command-line tools

## Steps

### Creating an ASP.NET 5 Project

> To start fire up Visual Studio 2015 and create a new ASP.NET 5 project by selecting File > New  Project. In the dialog, under Templates > Visual C#, select ASP.NET Web Application

[...]

> Name your project to whatever you like and then click OK. For the example I named the project as “AngularJS101”

[...]

> Now select ASP.NET 5 Preview Empty template from the dialog above. Then click OK to let Visual Studio generate the necessary files and templates needed for you.

Let's translate it!

Start your terminal and type `yo aspnet` (see requirements):
```bash
yo aspnet
```
From the option offered choose `Empty application':
```bash
     _-----_
    |       |    .--------------------------.
    |--(o)--|    |      Welcome to the      |
   `---------´   |   marvellous ASP.NET 5   |
    ( _´U`_ )    |        generator!        |
    /___A___\    '--------------------------'
     |  ~  |     
   __'.___.'__   
 ´   `  |° ´ Y ` 

? What type of application do you want to create? 
❯ Empty Application 
  Console Application 
  Web Application 
  Web Application Basic [without Membership and Authorization] 
  Web API Application 
  Nancy ASP.NET Application 
  Class Library 
```
Choose `AngularJS101` as the name of the application:
```bash
? What's the name of your ASP.NET application? (EmptyApplication) AngularJS101
```
The Yeoman generator will generate empty web application template project:
```bash
   create AngularJS101/.gitignore
   create AngularJS101/hosting.ini
   create AngularJS101/Startup.cs
   create AngularJS101/project.json
   create AngularJS101/wwwroot/README.md


Your project is now created, you can use the following commands to get going
    cd "AngularJS101"
    dnu restore
    dnu build (optional, build will also happen when it's run)
    dnx . run for console projects
    dnx . kestrel or dnx . web for web projects
```

**Note**: make sure that you `cd` into project directory to work within project context now!
```bash
cd AngularJS101/
```
### Adding the Scripts folder

> The next thing to do is to create a new folder called “Scripts”. This folder will contain all the JavaScript files needed in our application

In the project directory create new scripts folder:

```bash
mkdir Scripts
```


### Getting the Required Packages

> For this example we need to use NPM to install the resources we need in our application such as Grunt and the Grunt plugins. To do this just right-click in the Project (in this case AngularJS101) and select Add > New Item. In the dialog select NPM configuration file

The `generator-aspnet` ships with individual files templates for nearly all type of client or server side items in `Visual Studio`. To generate `NPM` package use package subgenerator which has a syntax `yo aspnet:PackageJson [options]`. So from comamnd-line type:
```
yo aspnet:PackageJson
```
This creates `package.json` file in your current directory. Modify its content as described in article:
```JSON
{
   "version": "1.0.0",
   "name": "AngularJS101",
   "private": true,
   "devDependencies": {
   "grunt": "0.4.5",
   "grunt-contrib-uglify": "0.9.1",
   "grunt-contrib-watch": "0.6.1"
   }
}
```

### Restore Packages

> Right-click on the NPM folder and select Restore Packages to download all the packages required. Note that this may take a bit to finish the download so just be patient and wait ;). Then the grunt, grunt-contrib-uglify and grunt-contrib-watch NPM packages should now be installed

No, there is no right-click in the terminal. So just use NPM to install packages added in previous step:
```bash
npm install
grunt-contrib-watch@0.6.1 node_modules/grunt-contrib-watch
├── async@0.2.10
├── lodash@2.4.2
├── gaze@0.5.1 (globule@0.1.0)
└── tiny-lr-fork@0.0.5 (debug@0.7.4, faye-websocket@0.4.4, noptify@0.0.3, qs@0.5.6)

grunt-contrib-uglify@0.9.1 node_modules/grunt-contrib-uglify
├── uri-path@0.0.2
├── chalk@1.1.0 (escape-string-regexp@1.0.3, supports-color@2.0.0, ansi-styles@2.1.0, has-ansi@2.0.0, strip-ansi@3.0.0)
├── lodash@3.10.0
├── uglify-js@2.4.23 (uglify-to-browserify@1.0.2, async@0.2.10, yargs@3.5.4, source-map@0.1.34)
└── maxmin@1.1.0 (figures@1.3.5, gzip-size@1.0.0, pretty-bytes@1.0.4)

grunt@0.4.5 node_modules/grunt
├── dateformat@1.0.2-1.2.3
├── which@1.0.9
├── eventemitter2@0.4.14
├── getobject@0.1.0
├── rimraf@2.2.8
├── colors@0.6.2
├── async@0.1.22
├── grunt-legacy-util@0.2.0
├── hooker@0.2.3
├── exit@0.1.2
├── nopt@1.0.10 (abbrev@1.0.7)
├── glob@3.1.21 (inherits@1.0.0, graceful-fs@1.2.3)
├── lodash@0.9.2
├── minimatch@0.2.14 (sigmund@1.0.1, lru-cache@2.6.5)
├── coffee-script@1.3.3
├── underscore.string@2.2.1
├── iconv-lite@0.2.11
├── findup-sync@0.1.3 (glob@3.2.11, lodash@2.4.2)
├── grunt-legacy-log@0.1.2 (grunt-legacy-log-utils@0.1.1, underscore.string@2.3.3, lodash@2.4.2)
└── js-yaml@2.0.5 (esprima@1.0.4, argparse@0.1.16)
```

## Author

@blazejewicz

## License

MIT