import csv
import os

def read_csv(name):
   result = []
   directory = "D:/Projects/WarframeProgressTracker/Data/In/"
   suffix = '.csv'
   path = os.path.join(directory, name + suffix)
   with open(path) as csvfile:
      rows = csv.reader(csvfile, delimiter=',')
      for row in rows:
         result.append(row)
   return result

def write_csv(name, data):
   directory = "D:/Projects/WarframeProgressTracker/Data/Out/"
   suffix = '.csv'
   path = os.path.join(directory, name + suffix)
   with open(path, 'w', newline="") as outfile:
      writer = csv.writer(outfile, delimiter=",")
      for row in data:
         writer.writerow(row)

# For some reason the wiki has two ways of formatting component display - 
# one where components are referred to as blueprints (e.g. neuroptics blueprint), 
# and one where they are simply referred to by their type (e.g. neuroptics).
# This causes different algorithms to be required for each format.
def extract_component_data(value):
   name = value.split('title="')[1].split('"')[0]
   print(name)

def extract_component_data_with_blueprint_in_title(value):
   name = value.split("Blueprint")[0].strip()
   component_rows = value.split('<td rowspan="2" style="')
   component_rows.pop(0)
   components = []
   for row in component_rows:
      component = extract_component_row(row)
      if len(component) > 1:
         components.append(component)

   print(name)
   for component in components:
      print(component[0] + ": " + str(component[1]))

def extract_component_row(value):
   name = ""
   amount = 0
   if 'title' in value:
      name = value.split('title="')[1].split('"')[0]
      if name == 'Platinum':
         return ''
   else:
      name = value.split('img alt="')[1].split('.png')[0]

   amount_string = value.split("<br>")[1].split("</td>")[0]
   amount_string = amount_string.strip()
   amount_string = amount_string.replace(',', '')
   amount = int(amount_string)

   # print(name)
   # print(amount_string)
   return [name, amount]


# TODO: Check if frame is research or blueprint based. Filter out research info first if research
# Will have to consider if research costs should be there as well, but that would take much more work so don't do that now
def extract_row_data(row):
   name = row[3].split('/').pop()
   data = row[6].strip()
   if data == 'null':
      return []
   if data == '':
      return []
   if "Manufacturing" not in data:
      return []
   split_data = data.split('<td colspan="6">')
   # split_data.pop(0)
   print(name)
   # Chroma has weird components so should be added manually, not worth adding an edge case for it at the moment
   if name == "Chroma":
      return
   
   if len(split_data) < 4:
      return []

   extract = extract_component_data
   if "Blueprint" in split_data[1]:
      print("Extracting data with blueprint keyword")
      extract = extract_component_data_with_blueprint_in_title

   extract(split_data[1])
   extract(split_data[2])
   extract(split_data[3])
   # print(data)
   #for entry in split_data:
      # print(entry)
   #  title = entry.split("Blueprint").pop(0)
   print("----------------------------------------------------------------------------------------------------------------------------------------------------------")

   # print('Manufacturing found in data row')
   return []
#
rows = read_csv("warframewikiframes")
rows.pop(0)
frame_data = []
for row in rows:
   # row_array = row.split(',')
   extract_row_data(row)
#   name = row[3].split('/').pop()
#   data = row[6]
#   if data != 'null' and data != '':
#      data_name = data.split('"').pop(0)
#      data_amount = data.split("<br>").pop()
#      row = [name, data_name, data_amount]
#      frame_data.append(row)

# write_csv('FrameBuildRequirements', frame_data)

