# -*- coding: utf-8 -*-
"""
Created on Mon Jun 13 15:18:32 2022

@author: JV
"""

"""
from selenium import webdriver

driver = webdriver.Chrome()
driver.get("http://www.google.com/")
#driver.quit()
"""

from selenium import webdriver
from selenium.webdriver.common.by import By
from selenium.webdriver.support.ui import Select
#from selenium.common.exceptions import NoSuchElementException
import time


url = "https://www.thsrc.com.tw/ArticleContent/a3b630bb-1066-4352-a1ef-58c7b4e8ef7c"
driver = webdriver.Chrome()
driver.get(url)


ss = '台北'
es = '彰化'
Ttype = '單程'
date = '2022.07.01'
times = '07:00'
offer = '早鳥'

headers = {
    "cookie" : "",
    "user-agent" : "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/102.0.5005.115 Safari/537.36"
    }

#window size
#driver.set_window_size(1920, 1080)

#personal data agreement
driver.find_element(by=By.XPATH, value='/html/body/div[5]/div/div[3]/button[1]').click()
time.sleep(2)

#fill in the form
#Starting Station
driver.find_element(by=By.XPATH, value='//*[@id="select_location01"]').send_keys(ss)
#Ending Station
driver.find_element(by=By.XPATH, value='//*[@id="select_location02"]').send_keys(es)
#Ticket Type
driver.find_element(by=By.XPATH, value='//*[@id="typesofticket"]').send_keys(Ttype)
#date //*[@id="Departdate03"]
driver.execute_script("document.getElementById('Departdate03').value='" + date + "'");
#time //*[@id="outWardTime"]
driver.execute_script("document.getElementById('outWardTime').value='" + times + "'");
#offer
select = Select(driver.find_element(by=By.ID, value="offer"))
select.deselect_all()
select.select_by_visible_text(offer)

#search 
driver.find_element(by=By.XPATH, value='//*[@id="start-search"]').click()
time.sleep(3)

"""
text = driver.page_source
text.find_element(by=By.XPATH, value='//*[@id="timeTableTrain_S"]')
"""




