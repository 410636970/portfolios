# encoding=utf-8
# Programmer: 劉志俊
# Date: 2019/10/02
# OpenCV: 邊緣偵測

import cv2
import numpy as np
from matplotlib import pyplot as plt
 
img_bgr = cv2.imread('Manhattan.PNG') # OpenCV2 載入影像
img = img_bgr[:,:,::-1]  # cv2的藍綠紅 轉為 紅綠藍
 
kernel1 = np.array([[-1,0,1],   # 用 NumPy 建立邊緣偵測過濾器核心
                   [-1,0,1],    # Prewitt operator
                   [-1,0,1]])

kernel2 = np.array([[-1,0,1],   # 用 NumPy 建立邊緣偵測過濾器核心
                   [-2,0,2],    # Sobel operator
                   [-1,0,1]])

dst1 = cv2.filter2D(img,-1,kernel1) # 2D影像摺積運算
dst2 = cv2.filter2D(img,-1,kernel2) # 2D影像摺積運算

plt.figure(figsize=(15,15), dpi=100) # 設定影像大小與解析度
plt.subplot(131),plt.imshow(img),plt.title('Original')
plt.xticks([]), plt.yticks([])
plt.subplot(132),plt.imshow(dst1),plt.title('Prewitt')
plt.xticks([]), plt.yticks([])
plt.subplot(133),plt.imshow(dst2),plt.title('Sobel')
plt.xticks([]), plt.yticks([])
plt.show()
