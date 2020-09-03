# 先驱SDK架构

先驱框架通过bin目录的xqapi.dll于插件传递信息。  
定义了四个导出函数:XQ_Create,XQ_Event,XQ_SetUp,XQ_DestroyPlugin。   
XQ_Create传递插件信息给框架。    
XQ_Event是从框架传递所有的事件信息给插件。   
XQ_SetUp是窗口设置相关事件。  
XQ_DestroyPlugin是插件销毁事件。    
框架通过XQ_Event传递各个参数给插件，插件通过调用xqapi.dll的导出函数(根据官方公布的调用说明)实现各个功能。   
托管调用非托管，要注意参数的数据类型。多用指针IntPtr。结构要使用顺序布局StructLayoutAttribute。如果有DllExport得注明调用约定，xqapi.dll中的导出函数调用约定大部分都是stdcall。      
数据传递多用MarshalAs，即在托管代码和非托管代码之间封送数据，可以用MarshalAs来定义非托管数据类型与大小，否则很容易出现数据交换错误。  

https://youtu.be/WGT4vtj4hpU   
