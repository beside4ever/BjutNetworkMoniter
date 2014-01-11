BjutNetworkMoniter
==============

简介
--------------
一个.net框架的小程序，用来自动登陆工大校园网，以及监控校园网的使用情况和当前网络状态。
最新的版本是V1.3.111.1。

功能
--------------
1.显示网络状态：包括即时网速，自开机以来的总上传/下载流量。<br>
2.自动登陆校园网：程序会自动判断当前校园网是否已登陆，如果没有登陆会自动尝试登陆。<br>
3.保存登陆状态：输入账号密码可进行登陆，选中“保存密码”即可始终用此账号密码进行自动登陆。<br>
4.显示校园网状态：显示本月已使用流量、账号余额，并自动计算之前的日均流量统计。<br>
5.开机自运行：选中开机自运行后，即可开机自动启动程序登陆校园网，免去了之前需要打开浏览器手动登陆的麻烦。

注意事项
--------------
网络状态显示的都是ipv4的数据统计，包括网速和流量，ipv6不进入统计，正好与校园网不计算ipv6流量相契合。

改进
--------------
想帮助改进程序或提出建议，请Fork本项目于GitHub：
https://github.com/beside4ever/BjutNetworkMoniter

更新日志
--------------
V1.3.0111.1 - 2014/1/11
  修复了在没有网络连接的情况下程序崩溃的问题。

联系作者
--------------
beside4ever@gmail.com
