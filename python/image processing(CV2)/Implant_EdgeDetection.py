# encoding=utf-8
# Programmer: 劉志俊
# Date: 2019/10/02
# OpenCV: Canny 邊緣偵測方法 X 光影像植入物偵測

import cv2
import numpy as np
from matplotlib import pyplot as plt
 
img_bgr = cv2.imread('X-Ray-Pacemaker.jpg') # OpenCV2 載入影像
img = img_bgr[:,:,::-1]  # cv2的藍綠紅 轉為 紅綠藍

img_gray = cv2.cvtColor(img, cv2.COLOR_BGR2GRAY)
blur_gray = cv2.GaussianBlur(img_gray,(5, 5), 0)

# OpenCV 邊緣偵測: 方法 Canny
canny = cv2.Canny(blur_gray, 80, 150)

plt.figure(figsize=(15,15), dpi=100) # 設定影像大小與解析度
plt.subplot(121),plt.imshow(img),plt.title('Original')
plt.xticks([]), plt.yticks([])
plt.subplot(122),plt.imshow(canny,cmap="gray"),plt.title('Canny')
plt.xticks([]), plt.yticks([])
plt.show()


