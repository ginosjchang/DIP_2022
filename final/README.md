# DIP 2022 Final Project
## Background
  Metal laser melting manufacturing (MAM) has been widely applied in the medical industry, manufacturing, aerospace and boutique industries in recent years. However, defects during the selective laser melting (SLM) manufacturing process can result from thermal stress or hardware failure during the selective laser melting (SLM) manufacturing process. To improve the product's quality, the use of defect detection during manufacturing is necessary.
## Objective
  An accurate detection of defects is very important. There have three powder-spreading defect types: powder uneven, powder uncovered and recoater scratches.
Target:
  Automatically detect and segment the defect during manufacturing.
    
## Goal
1. Using Yolo-V7 to segment the defects of manufacturing from given images.
2. You are given with total 450 images and ground truth annotations (mask and bounding box positions).
3. You can use the image processing skills as well as deep learning methods for this homework.

## Evaluation
1. Inersection over Union (IoU).
2. Average Precision when IoU > 0.5 (AP50).
3. Dice Coefficent.
4. Frames Per Sencond (FPS).

## Training
``` shell
make train
```

## Show with GUI
```shell
make ui
```
