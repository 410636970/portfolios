# -*- coding: utf-8 -*-
import cv2
import numpy as np
from matplotlib import pyplot as plt



image = cv2.imread('input/input38.png')
gray_image = cv2.cvtColor(image, cv2.COLOR_RGB2GRAY)
smoothed = cv2.GaussianBlur(gray_image, (9, 9), 0) 
minVal = 60
maxVal = 120
canny_image = cv2.Canny(smoothed, minVal, maxVal)
region_of_interest_vertices = np.array([[(100,360),(600,360),(300,210),(400,210)]])
#梯形第一點,梯形第二點,梯形第三點,梯形第四點
mask = np.zeros_like(canny_image)
cv2.fillPoly(mask, region_of_interest_vertices, 255)
masked_image = cv2.bitwise_and(canny_image, mask)
lines = cv2.HoughLinesP(masked_image,
                            rho=2,
                            theta=np.pi/180,
                            threshold=50,
                            lines=np.array([]),
                            minLineLength=40,
                            maxLineGap=100)

for x in range(0,len(lines)):
    #cv2.line(image, (x1,y1), (x2,y2), (0, 255, 0), thickness=10)
    for x1, y1, x2, y2 in lines[x]:
        cv2.line(image, (x1,y1), (x2,y2), (0, 255, 0), thickness=10)


#img = cv2.addWeighted(image, 0.8, masked_image, 1, 0.0)
plt.imshow(image)