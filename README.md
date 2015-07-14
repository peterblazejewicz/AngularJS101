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
### Configuring Grunt

> Grunt is an open-source tool that enables you to build client-side resources for your project.

[..]
> In this example, we will use Grunt to combine and minify JavaScript files. We will configure Grunt so that it will take all the JavaScript files from the Scripts folder that we created earlier, combine and minify the files and finally save the results to a file named app.js within the wwwroot folder.

[...]
> Now right-click on your project and select Add > New Item. Select Grunt Configuration file

We will again use `generator-aspnet` subgenerator to create `Grunt` configuration file template:

```bash
yo aspnet:Gruntfile
```

This creates `Gruntfile.js` in current directory. Modify its content as described in article:
```JavaScript
module.exports = function (grunt) {
   grunt.loadNpmTasks('grunt-contrib-uglify');
   grunt.loadNpmTasks('grunt-contrib-watch');

   grunt.initConfig({
      uglify: {
         my_target: {
         files: { 'wwwroot/app.js': ['Scripts/app.js', 'Scripts/**/*.js'] }
      }
},
watch: {
   scripts: {
      files: ['Scripts/**/*.js'],
         tasks: ['uglify']
      }
   }
});
   grunt.registerTask('default', ['uglify', 'watch']);
};
```
> Now save the file and let's run the Grunt file using Visual Studio Task Runner Explorer. To do this, go to View > Other Windows > Task Runner Explorer in Visual Studio main menu.

[...]
> Now right-click on the default task and select Run.

From your console just run Grunt and it will use default task:

```bash
grunt
```

### Configuring ASP.NET MVC

> First, we need to modify the project.json file to in include MVC 6 under dependencies:

Please note that this rewrite `project.json` configuration file is using `beta5` related packages, so there is an update compared to original article. The repository `project.json` created with generator is updated to current beta.

```JSON
"dependencies": {
    "Microsoft.AspNet.Server.IIS": "1.0.0-beta5",
    "Microsoft.AspNet.Server.WebListener": "1.0.0-beta5",
    "Kestrel": "1.0.0-beta5",
    "Microsoft.AspNet.Mvc": "6.0.0-beta5"
  }
```

### Adding Models

> The next step is to create model that we can use to pass data from the server to the browser /client. Now create a folder named “Models” under the root of your project. Within the “Models” folder, create a class named “DOTAHero”

Again, create a directory `Models`, switch to it and invoke subgenerator for `Class` template. Note that you will have to modify namespace as generator does not yet support project-based template generation (so namespaces are not read from `project.json` file):

```bash
Models ✗ yo aspnet:Class DOTAHero
You called the aspnet subgenerator with the arg DOTAHero
DOTAHero.cs created.
   create DOTAHero.cs
```

Repeat the same for `HeroManager.cs` class described in the article:
```bash
Models ✗ yo aspnet:Class HeroManager
You called the aspnet subgenerator with the arg HeroManager
HeroManager.cs created.
   create HeroManager.cs
```

### Adding Web API Controller

> Now add an “API” folder under the root of the project

```bash
mkdir API
```

> Then add a Web API controller by right-clicking the API folder and selecting Add > New Item. Select Web API Controller Class and name the controller as “HeroesController”

Again, we will use subgenerator template here, so first navigate to `API` directory, generate file and then make sure to modify namespace. We will use dedicated template available in generator `yo aspnet:WebApiController [options] <name>`:

```bash
API ✗ yo aspnet:WebApiController HeroesController
You called the aspnet subgenerator with the arg HeroesController
HeroesController.cs created.
   create HeroesController.cs
```

At this point you should be able to test created WebAPI controller by running application:
```bash
dnx . kestrel
started
```
The WebAPI endpoint should be available at [http://localhost:5000/api/heroes](http://localhost:5000/api/heroes) and [http://localhost:5000/api/heroes/7](http://localhost:5000/api/heroes/7):

```bash
curl http://localhost:5000/api/heroes
[{"ID":1,"Name":"Bristleback","Type":"Strength"},{"ID":2,"Name":"Abbadon","Type":"Strength"},{"ID":3,"Name":"Spectre","Type":"Agility"},{"ID":4,"Name":"Juggernaut","Type":"Agility"},{"ID":5,"Name":"Lion","Type":"Intelligence"},{"ID":6,"Name":"Zues","Type":"Intelligence"},{"ID":7,"Name":"Trent","Type":"Strength"}]
```
```bash
http://127.0.0.1:5000/api/heroes/7
{"ID":7,"Name":"Trent","Type":"Strength"}
```

## Author

@blazejewicz

## License

MIT
