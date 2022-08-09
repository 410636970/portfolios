import network
wlan = network.WLAN(network.STA_IF) 
def connectAP(ssid, pwd):
	if not wlan.isconnected():
		wlan.active(True)
		wlan.connect(ssid, pwd)        
		while not wlan.isconnected():
			pass 

connectAP("minminphone", "87878787")
print('network config:', wlan.ifconfig())

