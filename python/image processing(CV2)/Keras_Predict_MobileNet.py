# encoding=utf-8
# Programmer: 張珈維
# Date: 2020/06/16
# 使用 MobileNet 辨識 3 種交通號誌

from keras.preprocessing import image
from keras.models import load_model
from keras.applications.mobilenet import preprocess_input
import numpy as np
import os
from keras.utils.generic_utils import CustomObjectScope
import keras

# 輸出交通號誌類型
classes = ['Children 當心兒童', 'Pedestrians 當心行人', 'Speed_camera 前有測速照相']

# Step 1: 載入預先訓練好的模型
with CustomObjectScope({'relu6': keras.layers.ReLU(6.),'DepthwiseConv2D': keras.layers.DepthwiseConv2D}):
   model = load_model('Sign3_MobileNet_hw.h5')


# Step 2: 指定輸入影像目錄, 影像格式轉換
TEST_DIR = 'test_images'
for f in sorted(os.listdir(TEST_DIR)):
    source = os.path.join(TEST_DIR, f)
    print("===========================================")
    print(f)
    img = image.load_img(source, target_size=(224, 224)) # 轉換解析度
    x = image.img_to_array(img)    # 影像檔轉為陣列格式
    x = np.expand_dims(x, axis=0)  # 新增一維, 記錄影像樣本個數(可批次處理多個影像檔)
    x = preprocess_input(x)        # 調整影像像素格式為各個模型要求的輸入格式 

# Step 3: 預測輸入影像的分類
    preds = model.predict(x)

# Step 4: 預測結果格式調整後印出 
#    print('Predicted:', preds)  
    index_max = np.argmax(preds[0])
    print(index_max, classes[index_max], max(preds[0]))
