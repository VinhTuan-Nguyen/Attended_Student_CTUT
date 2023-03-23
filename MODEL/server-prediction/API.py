import base64
import io
import numpy as np
import uvicorn
import cv2
from pydantic import BaseModel
from PIL import Image
from fastapi import FastAPI, Form

class Picture(BaseModel):
    data: str


app = FastAPI()



from tensorflow.python.keras.models import load_model
model = load_model('model.h5')

with open('List_Labels.txt', 'r') as file:
    list_label = file.read().split()
    file.close()


@app.post("/predict")
async def predict_IMG(data: Picture):
    result = {
        'label':'',
        'accuracy':''
        }
    img =data.data
    if img != "":
        imgdata = base64.b64decode(img)
        image = np.array(convertImg(imgdata))
        image = cv2.cvtColor(image, cv2.COLOR_BGR2RGB)
        
        face = cv2.resize(image, dsize=(224, 224))
        face = face.astype('float') * 1./255
        face = np.expand_dims(face, axis=0)
        predict = model.predict(face)
        result['label'] = str(list_label[np.argmax(predict[0])])
        result['accuracy'] = str(np.max(predict[0]*100, axis=0))
        return result

def convertImg(img: bytes):
    image = Image.open(io.BytesIO(img))
    return image


if __name__ == '__main__':
    uvicorn.run(app, host='127.0.0.1', port=8080)