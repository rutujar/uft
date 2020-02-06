WpfWindow("HPE MyFlight Sample Applicatio").WpfEdit("agentName").WaitProperty "enabled", true, 10000
WpfWindow("HPE MyFlight Sample Applicatio").WpfEdit("agentName").Set "john"
WpfWindow("HPE MyFlight Sample Applicatio").WpfEdit("password").SetSecure "5d7b1ada0f83573d5ece"
