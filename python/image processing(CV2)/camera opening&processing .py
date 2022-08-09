# -*- coding: utf-8 -*-
# Programmer: 張珈維
# Date: 2020/05/29
# opencv02.py  影像處理: 灰階, 模糊化, 邊緣偵測
# Note: 如使用防毒軟體 Kaspersky 須關閉

import cv2

cap = cv2.VideoCapture(0)                 # 連接電腦的第一台 WebCam
cap.set(cv2.CAP_PROP_FRAME_WIDTH, 640)    # 設定影像寬度 640
cap.set(cv2.CAP_PROP_FRAME_HEIGHT, 480)   # 設定影像高度 480

while (cap.isOpened()):                   # 攝影機開啟狀態
    
    #print("攝影機開啟!")
    ret, frame = cap.read()               # 從攝影機擷取一張影像

    if ret == True:                       # 攝影機影像擷取成功

        # 影像轉灰階
        gray = cv2.cvtColor(frame, cv2.COLOR_BGR2GRAY) # 影像轉灰階
        blur = cv2.GaussianBlur(gray, (9, 9), 0)       # 高斯模糊化
        edges = cv2.Canny(blur,30,120)                 # Canny邊緣偵測
        
        # 顯示影像處理結果
        cv2.imshow('frame', frame)          # 顯示原始影像
        cv2.imshow('gray', gray)            # 顯示灰階影像
        cv2.imshow('blur', blur)            # 顯示高斯模糊化影像
        cv2.imshow('Canny', edges)          # 顯示Canny邊緣偵測影像
        if cv2.waitKey(1) & 0xFF == 32:     # 按下空白鍵(ASCII 32)結束程式
            break
    else:
        break
    
cap.release()                             # 釋放攝影機
cv2.destroyAllWindows()                   # 關閉所有 OpenCV 視窗