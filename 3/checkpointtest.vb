WpfWindow("HPE MyFlight Sample Applicatio").WpfEdit("agentName").Set "john"
WpfWindow("HPE MyFlight Sample Applicatio").WpfEdit("agentName").Check CheckPoint("agentName")
WpfWindow("HPE MyFlight Sample Applicatio").WpfEdit("password").SetSecure "5d79eb021e6f617edcd1"
WpfWindow("HPE MyFlight Sample Applicatio").WpfEdit("password").Check CheckPoint("password")
WpfWindow("HPE MyFlight Sample Applicatio").WpfButton("OK").Click
