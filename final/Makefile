ui:
	pyuic5 -x DIP_ui/ui.ui -o DIP_ui/ui_py.py
	python DIP_ui/start.py

predict:
	python segment/DIP_predict.py --weights best.pt --save-txt --source datasets_V2/Test/images/


train:
	python segment/train.py --data PID1.yaml --batch 8 --weights yolov7-seg.pt --cfg yolov7-seg.yaml --epochs 300 --name yolov7-1 --img 540 --hyp hyp.scratch-high.yaml --cache disk
	python segment/train.py --data PID2.yaml --batch 8 --weights runs/train-seg/yolov7-1/weights/best.pt --cfg yolov7-seg.yaml --epochs 300 --name yolov7-2 --img 540 --hyp hyp.scratch-high.yaml --cache disk
	python segment/train.py --data PID3.yaml --batch 8 --weights runs/train-seg/yolov7-2/weights/best.pt --cfg yolov7-seg.yaml --epochs 300 --name yolov7-3 --img 540 --hyp hyp.scratch-high.yaml --cache disk
	python segment/train.py --data PID4.yaml --batch 8 --weights runs/train-seg/yolov7-3/weights/best.pt --cfg yolov7-seg.yaml --epochs 300 --name yolov7-4 --img 540 --hyp hyp.scratch-high.yaml --cache disk