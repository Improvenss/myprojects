import pyqrcode
#from pyzbar.pyzbar import decode
#from PIL import Image

qr = pyqrcode.create('http://threshlife.blogspot.com/')
qr.png('qr_code_my_website.png', scale = 10)
