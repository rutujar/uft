If wpfwindow("HPE MyFlight Sample Applicatio").Exist(20) Then
WpfWindow("HPE MyFlight Sample Applicatio").WpfEdit("agentName").Set "john"
'wait(10)
WpfWindow("HPE MyFlight Sample Applicatio").WpfEdit("password").SetSecure "5d7b11a45520bdcff34f"
WpfWindow("HPE MyFlight Sample Applicatio").WpfButton("OK").Click
Reporter.ReportEvent micPass, "login process", "login found in 20s and executed successfully"
else
msgbox "FLights GUI application not found"
Reporter.ReportEvent micFail, "login process", "login not found"
End If
