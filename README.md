## 简介

QCloudIM.AspNetCore 是基于 .NET Core / ASP.NET Core 开发，实现腾讯云 IM 服务端 SDK 的调用。.Net Framework 版本请查看：<a href="https://github.com/antony10291029/QCloudIMSDK">
https://github.com/antony10291029/QCloudIMSDK</a>

## Package

| Package             | NuGet                                                                                                                  |
| ------------------- | ---------------------------------------------------------------------------------------------------------------------- |
| QCloudIM.AspNetCore | [![NuGet](https://img.shields.io/nuget/v/QCloudIM.AspNetCore.svg)](https://www.nuget.org/packages/QCloudIM.AspNetCore) |

## 使用方式

1.引入项目

```
Install-Package QCloudIM.AspNetCore -Version 1.0.0
```

2.在 StartUp 中注册并配置参数

```C#
  services.AddQCloudIM(options =>
            {
                options.Identifier = "";
                options.SdkAppid = "";
                options.PrivateKey = "";
            });
```

3.使用配置文件的方式设置参数(选项配置)

- 设置配置文件 appsettings.json

```C#
{
  "QCloudIM": {
    "Identifier": "",
    "SdkAppid": "",
    "PrivateKey": ""
  }
}
```

- 配置选项

```C#
services.Configure<QCloudIMOption>(Configuration.GetSection("QCloudIM"));
```

4.在业务类中注入对应的 client 并调用。

```C#
   private IQCloudIMGroupClient _groupClient;

        public GroupController(IQCloudIMGroupClient groupClient)
        {
            _groupClient = groupClient;
        }

        public async Task<ActionResult<GetGroupListResult>> GetGroupList(GetGroupListRequest request)
        {
            return await _groupClient.GetGroupListAsync(request);
        }
```

## Client 说明

Client 根据腾讯云通信服务端 REST API 定义，接口名称与官方 command 基本一致。官方文档：<a href="https://cloud.tencent.com/document/product/269/1520">https://cloud.tencent.com/document/product/269/1520</a>

IQCloudIMGroupClient：群组管理

IQCloudIMConfigClient：全局禁言管理

IQCloudIMDirtywordsClient：脏字管理

IQCloudIMOLoginClient：账号管理

IQCloudIMOpenImClient：消息管理

IQCloudIMProfileClient：资料管理

IQCloudIMSnsClient：关系链管理

IQCloudIMSvcClient：数据下载
