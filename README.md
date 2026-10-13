# ASP.NETCourse

ASP.NET MVC 课程练习，已迁移到 ASP.NET Core MVC（.NET 8）。

| 项目 | 说明 | 本地地址 |
| --- | --- | --- |
| 控制器和路由 | Cookie 主题切换、文件下载 | http://localhost:5101 |
| 过滤器 | 自定义 ActionFilter 登录校验（账号/密码：123/123） | http://localhost:5102 |
| ASP.NET AJAX的应用 | jQuery Unobtrusive Ajax + EF Core 产品查询 | http://localhost:5103 |
| CopyAs | 控制台程序 | - |

## 运行

需要安装 [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)。

```bash
dotnet build ASP.NETCourse.sln
dotnet run --project 控制器和路由
```

`ASP.NET AJAX的应用` 需要 SQL Server 中的 `meixin` 数据库，连接字符串在 `appsettings.json` 的 `ConnectionStrings:meixinEntities` 中配置。
