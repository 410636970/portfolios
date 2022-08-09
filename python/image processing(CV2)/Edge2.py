# encoding=utf-8
# Programmer: 劉志俊
# Date: 2019/10/02
# OpenCV: Laplacian, Sobel, Canny 邊緣偵測法

import cv2
import numpy as np
from matplotlib import pyplot as plt
 
img_bgr = cv2.imread('X-Ray-Pacemaker.jpg') # OpenCV2 載入影像
img = img_bgr[:,:,::-1]  # cv2的藍綠紅 轉為 紅綠藍

# OpenCV 邊緣偵測: 方法一 Laplacian  
img_gray = cv2.cvtColor(img, cv2.COLOR_BGR2GRAY)
lap = cv2.Laplacian(img_gray, cv2.CV_64F)
lap = np.uint8(np.absolute(lap))

# OpenCV 邊緣偵測: 方法二 Sobel
sobelX = cv2.Sobel(img_gray, cv2.CV_64F, 1, 0)
sobelY = cv2.Sobel(img_gray, cv2.CV_64F, 0, 1)
sobelX = np.uint8(np.absolute(sobelX))
sobelY = np.uint8(np.absolute(sobelY))
sobelCombined = cv2.bitwise_or(sobelX, sobelY)

# OpenCV 邊緣偵測: 方法三 Canny
canny = cv2.Canny(img, 30, 120)

plt.figure(figsize=(15,15), dpi=100) # 設定影像大小與解析度
plt.subplot(141),plt.imshow(img),plt.title('Original')
plt.xticks([]), plt.yticks([])
plt.subplot(142),plt.imshow(lap,cmap="gray"),plt.title('Laplacian')
plt.xticks([]), plt.yticks([])
plt.subplot(143),plt.imshow(sobelCombined,cmap="gray"),plt.title('Sobel')
plt.xticks([]), plt.yticks([])
plt.subplot(144),plt.imshow(canny,cmap="gray"),plt.title('Canny')
plt.xticks([]), plt.yticks([])
plt.show()


