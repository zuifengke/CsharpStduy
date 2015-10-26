附件包含2个项目。
1、	用于时间log的类库项目Log4Emrs，生成Log4Emrs.dll，供调用进行日志记录。
2、	WinStopwatch项目，使用stopwatch及Log4Emrs.dll分别进行日志记录Demo。

格式如下：
Button_1       	2013/09/17 22:21:30.939       	创建Button并添加到Panel-begin                 	
Button_2       	2013/09/17 22:21:31.783       	创建Button并添加到Panel-end                   	844.0482ms
RadioButton_1  	2013/09/17 22:21:34.918       	创建RadioButton并添加到Panel-begin            	3135.1794ms
RadioButton_2  	2013/09/17 22:21:35.756       	创建RadioButton并添加到Panel-end              	838.0479ms
CheckBox_1     	2013/09/17 22:21:37.758       	创建CheckBox并添加到Panel-begin               	2002.1145ms
CheckBox_2     	2013/09/17 22:21:38.623       	创建CheckBox并添加到Panel-end                 	865.0495ms
TextBox_1      	2013/09/17 22:21:40.813       	创建TextBox并添加到Panel-begin                	2190.1253ms
TextBox_2      	2013/09/17 22:21:42.226       	创建TextBox并添加到Panel-end                  	1413.0808ms

调用示例：
Log4Emr.Restart("CheckBox");
    Log4Emr.LogInfo("创建CheckBox并添加到Panel-begin");
    for (int i = 0; i < nNum; i++)
    {
        CheckBox cb = new CheckBox();
        pnlContent.Controls.Add(cb);
    }
    Log4Emr.LogInfo("创建CheckBox并添加到Panel-end");
Log4Emr.Stop();
