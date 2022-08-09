# encoding=utf-8
# Programmer: 劉志俊
# Date: 2019/10/02
# OpenCV: X 光影像平滑化去雜訊

import cv2 
from matplotlib import pyplot as plt
import numpy as np 
  
# 讀取帶雜訊 X 光影像
img2 = cv2.imread('X-Ray-Noisy.jpg', cv2.IMREAD_GRAYSCALE)

# 定義 5x5 平滑化核心
kernel = np.ones((5,5),np.float32)/25

# 去雜訊
dst = cv2.filter2D(img2,-1,kernel)

# X 光影像平滑化去雜訊前後比較繪圖
res2 = np.hstack((img2, dst)) 
plt.figure(figsize=(15,15), dpi=100)
plt.imshow(res2,cmap="gray")
plt.xticks([]), plt.yticks([])
plt.show()