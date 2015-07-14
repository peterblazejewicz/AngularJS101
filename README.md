# AngularJS101

A `generator-aspnet` rewrite of the [ASP.Net 5: Jump Start to AngularJS With MVC 6 Web API' article](http://www.c-sharpcorner.com/UploadFile/8c19e8/Asp-Net-5-jump-start-to-angularjs-with-mvc-6-web-api/)

## Prerequisitues

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


## Author

@blazejewicz

## License

MIT