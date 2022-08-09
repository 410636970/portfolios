"""
   學號：410636970  姓名：張珈維
"""

import machine
import ubinascii
import ujson
from umqtt.simple import MQTTClient
import network
import time


wlan = network.WLAN(network.STA_IF)

def connectAP(ssid, pwd):
    if not wlan.isconnected():
        wlan.active(True)
        wlan.connect(ssid, pwd)
        
        while not wlan.isconnected():
            pass

    print('network config:', wlan.ifconfig())
    print('學號：410636970 姓名：張珈維')

connectAP("minminphone", "87878787")

config = {
    'broker':'mqtt.thingspeak.com',
    'user':'s1063697',
    'key':'64EBL1N9Y8EDQT4K',
    'id' :'alphasuki/',
    'topic': b'channels/793150/subscribe/json/FBJEW3HCKTJMLA6L'
}

def subCallback(topic, msg):
    obj = ujson.loads(msg)
    print(topic, msg)
    print('----------------------')
    print('temp:',  obj['field1'])
    print('humid:', obj['field2'])
    print('')

def main():
    client = MQTTClient(client_id=config['id'], 
                        server=config['broker'],
                        user=config['user'],
                        password=config['key'])
    client.set_callback(subCallback)
    client.connect()
    client.subscribe(config['topic'])

    try:
        while True:
            client.check_msg()
            time.sleep(10)
    except:
        client.disconnect()
        print('bye!')
main()
