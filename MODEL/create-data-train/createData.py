from os import listdir
import cv2
import pickle
import json


def save_data(raw_folder="Data\\"):
    print("Bắt đầu xử lý ảnh...")

    pixels = []
    labels = []

    # Lặp qua các folder con trong thư mục raw
    for folder in listdir(raw_folder):
        if folder != '.DS_Store':
            # Lặp qua các file trong từng thư mục chứa các item
            for file in listdir(raw_folder + folder):
                if file != '.DS_Store':
                    print("File=", file)
                    pixels.append(cv2.resize(cv2.imread(raw_folder + folder + "/" + file), dsize=(224, 224)))
                    labels.append(folder)

    list_label = sorted(set(labels), key=labels.index)
    print(list_label)

    with open('List_Labels.txt', "w") as f:
        f.write(json.dumps(list_label))
        f.close()

    
    with open('Data-224x224.data', 'wb') as f:
        # dump information to that file
        pickle.dump((labels, pixels), f)
        # close the file
        f.close()

        
    print("success")
    return

save_data()