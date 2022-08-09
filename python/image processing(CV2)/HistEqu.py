# encoding=utf-8
# Programmer: 劉志俊
# Date: 2019/10/02
# OpenCV: 直方圖均衡化

import cv2 
from matplotlib import pyplot as plt
  
# import Numpy 
import numpy as np 
  
# read a image using imread 
img = cv2.imread('X-Ray.jpg', cv2.IMREAD_GRAYSCALE) 
  
# 直方圖均衡化(Histogram Equalization)
# 使用 cv2.equalizeHist() 
equ = cv2.equalizeHist(img) 
  
# 限制對比度自適應直方圖均衡化 CLAHE
# 使用 cv2.createCLAHE()
clahe = cv2.createCLAHE(clipLimit=2.0, tileGridSize=(8,8))
cl1 = clahe.apply(img)
  
res = np.hstack((img, equ, cl1)) 

plt.figure(figsize=(15,36), dpi=100) # 設定影像大小與解析度
plt.imshow(res,cmap="gray")
plt.xticks([]), plt.yticks([])
plt.show()