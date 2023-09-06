from DIP_predict import run

from PyQt5 import QtWidgets
from PyQt5.QtWidgets import *
from PyQt5.QtCore import *
from PyQt5.QtGui import *

import ui_py as ui  
import os
import cv2
import json
import torch
import numpy as np
from PIL import Image, ImageQt
from utils.metrics import box_iou, compute_ap

class Main(QMainWindow, ui.Ui_MainWindow):
    def __init__(self):
        super().__init__()
        self.setupUi(self)
        self.load_btn.clicked.connect(self.load_btn_clicked)
        self.detect_btn.clicked.connect(self.detect_btn_clicked)
        self.current = 0
        self.timer = QTimer(self)
        self.timer.timeout.connect(self.on_time)
    
    def load_btn_clicked(self):
        try:
            self.floder_path = str(QFileDialog.getExistingDirectory(self, "Select Directory")) #Select floder
        except BaseException as e:
            print("\033[0;31m[ERROR] {0}\033[0;37m".format(e))
    
    def cv2qt(self, image):
        img = cv2.cvtColor(cv2.resize(image,(500,500)), cv2.COLOR_BGR2RGB)
        img = Image.fromarray(img, mode="RGB")
        qt_img = ImageQt.ImageQt(img)
        
        return QPixmap.fromImage(qt_img)
    
    def detect_btn_clicked(self):
        self.current_frame_label.setText("0")
        self.result = run(weights="DIP_ui/best.pt", source=os.path.join(self.floder_path, "image"))
        self.total_frame_label.setText(str(len(self.result)))
        self.timer.start(1000)
    
    def read_gt(self, filename):
        # print("function: read_gt")
        with open(filename) as f:
            data = json.load(f)
        gt_type_num = {
            "powder_uncover": 0,
            "powder_uneven": 0,
            "scratch": 0
        }

        gt_xyxy = []
        for shape in data['shapes']:
            gt_type_num[shape['label']] += 1

            gt_xyxy.append([shape['points'][0][0], shape['points'][0][1], shape['points'][1][0], shape['points'][1][1]])
        
        return gt_type_num, gt_xyxy
    
    def cvtBinary(self, image):
        gray = cv2.cvtColor(image, cv2.COLOR_BGR2GRAY)
        _, mask_binary = cv2.threshold(gray, 20, 255, cv2.THRESH_BINARY)
        return mask_binary

    def on_time(self):
        try:
            current = int(self.current_frame_label.text())
            data = self.result[current]
    
            json_path = data['path'].replace('image', 'label').replace('.png', '.json')
            mask_path = data['path'].replace('image', 'mask')

            gt_type_num, gt_xyxy = self.read_gt(json_path)

            total_num = len(gt_xyxy)
            
            gt_xyxy = torch.from_numpy(np.array(gt_xyxy)).cuda()

            pre_xyxy = []
            for i in data['xyxy']:
                pre_xyxy.append([i[0].tolist(), i[1].tolist(), i[2].tolist(), i[3].tolist()])
            pre_xyxy = torch.from_numpy(np.array(pre_xyxy)).cuda()

            try:
                # print("function: box_iou")
                iou = box_iou(gt_xyxy, pre_xyxy)
                iou = np.max(np.array(iou.tolist()), axis = 0)

                # print("r p")
                c, p, r = 0, [], []
                for i in iou:
                    if i > 0.5: c += 1
                    r.append(c/total_num if total_num != 0 else 0)
                    p.append(c/(len(p) + 1))
                
                # print("ap50")
                ap50, _, _ = compute_ap(r, p)
                
                IoU = iou.mean()
                
                # print("mask")
                gt_mask = cv2.imread(mask_path)
                gt_mask = self.cvtBinary(gt_mask)
                pre_mask = self.cvtBinary(data['mask'])

                # print("dice")
                dice = np.sum(pre_mask[gt_mask==255]) * 2.0 / (np.sum(pre_mask) + np.sum(gt_mask))
            except:
                IoU = 0
                ap50 = 0
                dice = 0
            ## show original
            self.uncover_num_label_2.setText(str(gt_type_num['powder_uncover']))
            self.uneven_num_label_2.setText(str(gt_type_num['powder_uneven']))
            self.scratch_num_label_2.setText(str(gt_type_num['scratch']))

            ## show result
            self.image_label.setPixmap(QPixmap(data['path']))
            self.result_label.setPixmap(self.cv2qt(data['result']))
            self.uncover_num_label.setText(str(data['powder_uncover']))
            self.uneven_num_label.setText(str(data['powder_uneven']))
            self.scratch_num_label.setText(str(data['scratch']))
            self.fps_label.setText(str(int(1/data['dt'])))
            self.iou_label.setText(format(IoU, '.2f'))
            self.dice_label.setText(format(dice, '.2f'))
            self.ap_label.setText(format(ap50, '.2f'))

            self.current_frame_label.setText(str(current + 1))
        except Exception as e:
            # print(e)
            self.timer.stop()


if __name__ == '__main__':
    import sys
    app = QtWidgets.QApplication(sys.argv)
    window = Main()
    window.show()
    sys.exit(app.exec_())