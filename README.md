# AspNetCourse

ASP.NET MVC 课程练习，已迁移到 ASP.NET Core MVC（.NET 8）。

| 项目 | 说明 | 本地地址 |
| --- | --- | --- |
| RoutingDemo | Cookie 主题切换、文件下载 | http://localhost:5101 |
| FilterDemo | 自定义 ActionFilter 登录校验（账号/密码：123/123） | http://localhost:5102 |
| AjaxDemo | jQuery Unobtrusive Ajax + EF Core 产品查询 | http://localhost:5103 |
| CopyAs | 控制台程序 | - |

## 运行

需要安装 [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)。

```bash
dotnet build AspNetCourse.sln
dotnet run --project RoutingDemo
```

`AjaxDemo` 需要 SQL Server 中的 `meixin` 数据库，连接字符串在 `AjaxDemo/appsettings.json` 的 `ConnectionStrings:meixinEntities` 中配置。

## 命名约定

- 项目目录、项目文件和命名空间统一使用英文 PascalCase，并保持名称一致。
- 保留 ASP.NET Core 的标准文件名（如 `appsettings.json`、`launchSettings.json`、`wwwroot`）。
- 页面文案可以使用中文；现有数据库表名和 EF 实体名保持不变，避免影响数据库映射。
