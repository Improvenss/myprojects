import pyqrcode
#from pyzbar.pyzbar import decode
#from PIL import Image

qr = pyqrcode.create('https://forms.gle/BqWujaRRWU7fSD2Y8')
qr.png('ready_qr/1tst_film_feedback.png', scale = 100)
