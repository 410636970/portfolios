#encodong = utf-8
#Programmer:張珈維
#Date:2020/05/29

# import the necessary packages
import imutils
import cv2

#顯示影像+長寬高
image = cv2.imread("1.png")
print("影像資料型態:",type(image))
(h, w, d) = image.shape
print("width={}, height={}, depth={}".format(w, h, d))
cv2.imshow("Image", image)

#RGB值
(B, G, R) = image[100, 50]
print("R={}, G={}, B={}".format(R, G, B))

#切割原影像
roi = image[60:160, 320:420]
cv2.imshow("ROI", roi)

#800*800
resized = cv2.resize(image, (800, 800))
cv2.imshow("Fixed Resizing", resized)

r = 300.0 / w
dim = (300, int(h * r))
resized = cv2.resize(image, dim)
cv2.imshow("Aspect Ratio Resize", resized)

#設寬度500
resized = imutils.resize(image, width=500)
cv2.imshow("Imutils Resize", resized)

#轉60度
center = (w // 2, h // 2)
M = cv2.getRotationMatrix2D(center, 60, 1.0)
rotated = cv2.warpAffine(image, M, (w, h))
cv2.imshow("OpenCV Rotation", rotated)

#轉90度不切割
rotated = imutils.rotate_bound(image, 90)
cv2.imshow("Imutils Bound Rotation", rotated)

#模糊化
blurred = cv2.GaussianBlur(image, (11, 11), 0)
cv2.imshow("Blurred", blurred)

# 紅色矩形
output = image.copy()
cv2.rectangle(output, (320, 60), (420, 160), (0, 0, 255), 2)
cv2.imshow("Rectangle", output)

# 繪製5px寬藍線, 由 x=60,y=20 至 x=400,y=200
output = image.copy()
cv2.line(output, (60, 20), (400, 200), (255, 0, 0), 5)
cv2.imshow("Line", output)

# 繪製綠色圓形, 中心在 x=300,y=150
output = image.copy()
cv2.circle(output, (300, 150), 20, (0, 255, 0), -1)
cv2.imshow("Circle", output)

# 繪製黃色文字
output = image.copy()
cv2.putText(output, "Hello,Python", (10, 25), 
cv2.FONT_HERSHEY_SIMPLEX, 0.7, (0, 255, 255), 2)
cv2.imshow("Text", output)
cv2.waitKey(0)