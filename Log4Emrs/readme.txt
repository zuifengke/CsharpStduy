��������2����Ŀ��
1��	����ʱ��log�������ĿLog4Emrs������Log4Emrs.dll�������ý�����־��¼��
2��	WinStopwatch��Ŀ��ʹ��stopwatch��Log4Emrs.dll�ֱ������־��¼Demo��

��ʽ���£�
Button_1       	2013/09/17 22:21:30.939       	����Button����ӵ�Panel-begin                 	
Button_2       	2013/09/17 22:21:31.783       	����Button����ӵ�Panel-end                   	844.0482ms
RadioButton_1  	2013/09/17 22:21:34.918       	����RadioButton����ӵ�Panel-begin            	3135.1794ms
RadioButton_2  	2013/09/17 22:21:35.756       	����RadioButton����ӵ�Panel-end              	838.0479ms
CheckBox_1     	2013/09/17 22:21:37.758       	����CheckBox����ӵ�Panel-begin               	2002.1145ms
CheckBox_2     	2013/09/17 22:21:38.623       	����CheckBox����ӵ�Panel-end                 	865.0495ms
TextBox_1      	2013/09/17 22:21:40.813       	����TextBox����ӵ�Panel-begin                	2190.1253ms
TextBox_2      	2013/09/17 22:21:42.226       	����TextBox����ӵ�Panel-end                  	1413.0808ms

����ʾ����
Log4Emr.Restart("CheckBox");
    Log4Emr.LogInfo("����CheckBox����ӵ�Panel-begin");
    for (int i = 0; i < nNum; i++)
    {
        CheckBox cb = new CheckBox();
        pnlContent.Controls.Add(cb);
    }
    Log4Emr.LogInfo("����CheckBox����ӵ�Panel-end");
Log4Emr.Stop();
