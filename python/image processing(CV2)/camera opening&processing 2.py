# -*- coding: utf-8 -*-
# Programmer: 劉志俊
# Date: 2020/05/26
# OpenCV 使用教學範例程式
# opencv02.py  影像處理(2) 變形: Erosion, Dilation, Opening, Closing
# Note: 如使用防毒軟體 Kaspersky 須關閉

import cv2
import numpy as np

cap = cv2.VideoCapture(1)                 # 連接電腦的第一台 WebCam
cap.set(cv2.CAP_PROP_FRAME_WIDTH, 640)    # 設定影像寬度 640
cap.set(cv2.CAP_PROP_FRAME_HEIGHT, 480)   # 設定影像高度 480

while (cap.isOpened()):                   # 攝影機開啟狀態
    
    #print("攝影機開啟!")
    ret, frame = cap.read()               # 從攝影機擷取一張影像

    if ret == True:                       # 攝影機影像擷取成功

        # 影像轉灰階
        gray = cv2.cvtColor(frame, cv2.COLOR_BGR2GRAY) # 影像轉灰階
        kernel = np.ones((5,5),np.uint8)
        erosion = cv2.erode(gray,kernel,iterations = 1) # 侵蝕 Erosion
        dilation = cv2.dilate(gray,kernel,iterations = 1) # 擴張 Dilation
        opened = cv2.morphologyEx(gray, cv2.MORPH_OPEN, kernel) # 開啟 Opening
        closed = cv2.morphologyEx(gray, cv2.MORPH_CLOSE, kernel) # 關閉 Closing
        
        # 顯示影像處理結果
        cv2.imshow('gray', gray)            # 顯示灰階影像
        cv2.imshow('erosion', erosion)      # 顯示侵蝕影像
        cv2.imshow('dilation', dilation)    # 顯示擴張影像
        cv2.imshow('opened', opened)        # 顯示開啟影像
        cv2.imshow('closed', closed)        # 顯示關閉影像
        if cv2.waitKey(1) & 0xFF == 32:     # 按下空白鍵(ASCII 32)結束程式
            break
    else:
        break
    
cap.release()                             # 釋放攝影機
cv2.destroyAllWindows()                   # 關閉所有 OpenCV 視窗