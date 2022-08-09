# -*- coding: utf-8 -*-
"""
Created on Wed May  4 15:42:51 2022

@author: JV
"""


import requests
from bs4 import BeautifulSoup

url = 'http://www.taiwanlottery.com.tw'
r = requests.get(url)
sp = BeautifulSoup(r.text, 'lxml')
#BINGO BINGO
print("***BINGO BINGO***")
datas = sp.find('div', class_='contents_box01')
title = datas.find('span', class_='font_black15')
print(title.text)
nums = datas.find_all('div', class_='ball_tx ball_yellow')
print('開出獎號：', end=' ')
for i in range(len(nums)):
    print(nums[i].text, end=' ')