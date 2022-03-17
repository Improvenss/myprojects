import pyqrcode
#from pyzbar.pyzbar import decode
#from PIL import Image

qr = pyqrcode.create('http://threshlife.blogspot.com/')
qr.png('ready_qr/qr_code_my_website2.png', scale = 10)
