# encoding=utf-8
# Programmer: 劉志俊
# Date: 2019/09/27
# OpenCV: 銳利化

import cv2
import numpy as np
from matplotlib import pyplot as plt
 
img = cv2.imread('Lena.JPG') # OpenCV2 載入影像
# matplotlib 與 OpenCV 顏色次序轉換 RGB => BGR
img_bgr = img[:,:,::-1]  # cv2的藍綠紅 轉為 紅綠藍

kernel1 = np.array([[0,-1,0],    # 用 NumPy 建立銳化過濾器核心
                   [-1,5,-1],
                   [0,-1,0]])

kernel2 = np.array([[-1,-1,-1],  # 用 NumPy 建立銳化過濾器核心
                    [-1,9,-1],
                    [-1,-1,-1]])

dst1 = cv2.filter2D(img_bgr,-1,kernel1) # 2D影像摺積運算
dst2 = cv2.filter2D(img_bgr,-1,kernel2) # 2D影像摺積運算
 
plt.figure(figsize=(15,15), dpi=100) # 設定影像大小與解析度
plt.subplot(131),plt.imshow(img_bgr),plt.title('Original')
plt.xticks([]), plt.yticks([])
plt.subplot(132),plt.imshow(dst1),plt.title('Box Blur')
plt.xticks([]), plt.yticks([])
plt.subplot(133),plt.imshow(dst2),plt.title('Gaussian Blur')
plt.xticks([]), plt.yticks([])
plt.show()
