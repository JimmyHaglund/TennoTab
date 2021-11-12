import csv
import os
import datareader
import data_extractor_warframe_components
import data_extractor_weapon_blueprints

component_category_name = 'Component'
resource_category_name = 'Resource'

def write_csv(name, data):
   directory = "D:/Projects/WarframeProgressTracker/Data/Out/"
   suffix = '.csv'
   path = os.path.join(directory, name + suffix)
   with open(path, 'w', newline="") as outfile:
      writer = csv.writer(outfile, delimiter=",")
      for row in data:
         writer.writerow(row)

frames_raw = datareader.read_frame_files()
weapons_raw = datareader.read_weapon_files()

result = []

print('processing ' + str(len(weapons_raw)) + ' weapons')

for frame in frames_raw:
   data = data_extractor_warframe_components.extract_warframe_components_row_data(frame)
   if len(data) == 0:
      continue
   result = result + data

for weapon in weapons_raw:
   data = data_extractor_weapon_blueprints.extract_weapon_components_row_data(weapon)
   if len(data) == 0:
      continue
   result = result + data
   
for value in result:
   print(value)
