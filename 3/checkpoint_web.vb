Browser("Welcome: Mercury Tours").Page("Welcome: Mercury Tours").Check CheckPoint("Welcome: Mercury Tours_2")
Browser("Welcome: Mercury Tours").Page("Welcome: Mercury Tours").Image("Featured Destination: Aruba").Check CheckPoint("Featured Destination: Aruba")
Browser("Welcome: Mercury Tours").Page("Welcome: Mercury Tours").WebTable("Home").Check CheckPoint("Home")
Browser("Welcome: Mercury Tours").Page("Welcome: Mercury Tours").Check CheckPoint("Welcome: Mercury Tours")
Browser("Welcome: Mercury Tours").Page("Welcome: Mercury Tours").WebEdit("userName").Set "mercury"
Browser("Welcome: Mercury Tours").Page("Welcome: Mercury Tours").WebEdit("password").SetSecure "5d7a0dbbe32c5955dcc03f7e3724c2655d25b42b"
Browser("Welcome: Mercury Tours").Page("Welcome: Mercury Tours").Image("Sign-In").Click 24,7
Browser("Welcome: Mercury Tours").Page("Welcome: Mercury Tours").Sync
Browser("Welcome: Mercury Tours").CloseAllTabs
